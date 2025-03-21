using McTools.Xrm.Connection;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using XrmToolBox.Extensibility;

namespace MsCrmTools.FetchXmlTester.AppCode
{
    public class QueryInfo
    {
        private string filename;

        public QueryInfo(string fetchXml)
        {
            var x = new XmlDocument();
            x.LoadXml(fetchXml);

            Table = x.SelectSingleNode("//entity").Attributes["name"].Value;
            FetchXml = PrintXML(fetchXml);
            Date = DateTime.Now;
        }

        public QueryInfo(FileInfo fi)
        {
            filename = fi.FullName;
            var nameParts = fi.Name.Split('_');
            Table = nameParts[1];
            Date = DateTime.ParseExact(nameParts[2].Split('.')[0], "yyyyMMdd-HHmmss", DateTimeFormatInfo.InvariantInfo);

            using (var sr = new StreamReader(fi.FullName))
            {
                FetchXml = sr.ReadToEnd();

                var x = new XmlDocument();
                x.LoadXml(FetchXml);

                foreach (XmlNode node in x.ChildNodes)
                {
                    if (node.NodeType == XmlNodeType.Comment)
                    {
                        var valueParts = node.Value.Split(':');
                        if (valueParts[0]?.ToLower().Trim() == "description")
                        {
                            Description = valueParts[1]?.Trim();
                        }
                        else if (valueParts[0]?.ToLower().Trim() == "environment")
                        {
                            Environment = valueParts[1]?.Trim();
                        }
                    }
                    else
                    {
                        FetchXml = PrintXML(node.OuterXml);
                    }
                }
            }
        }

        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Environment { get; set; }
        public string FetchXml { get; set; }
        public string Table { get; set; }

        public static QueryInfo[] LoadQueries(Guid value)
        {
            var folderInfo = new DirectoryInfo(Path.Combine(Paths.SettingsPath, "FetchXmlTester"));
            if (!folderInfo.Exists)
            {
                return new QueryInfo[0];
            }

            var files = folderInfo.GetFiles(value == Guid.Empty ? "*.xml" : $"{value}_*.xml");

            return files.Select(f => new QueryInfo(f)).ToArray();
        }

        public static string PrintXML(string xml)
        {
            string result = "";

            using (MemoryStream mStream = new MemoryStream())
            {
                using (XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode))
                {
                    XmlDocument document = new XmlDocument();

                    try
                    {
                        // Load the XmlDocument with the XML.
                        document.LoadXml(xml);

                        writer.Formatting = Formatting.Indented;

                        // Write the XML into a formatting XmlTextWriter
                        document.WriteContentTo(writer);
                        writer.Flush();
                        mStream.Flush();

                        // Have to rewind the MemoryStream in order to read
                        // its contents.
                        mStream.Position = 0;

                        // Read MemoryStream contents into a StreamReader.
                        StreamReader sReader = new StreamReader(mStream);

                        // Extract the text from the StreamReader.
                        string formattedXml = sReader.ReadToEnd();

                        result = formattedXml;
                    }
                    catch (XmlException)
                    {
                        // Handle the exception
                    }
                }
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Date} - {Table}";
        }

        internal void Delete()
        {
            if (!File.Exists(filename)) return;

            File.Delete(filename);
        }

        internal void Save(ConnectionDetail detail)
        {
            var path = Path.Combine(Path.GetFullPath(Paths.SettingsPath), "FetchXmlTester");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            filename = Path.Combine(Path.GetFullPath(Paths.SettingsPath), "FetchXmlTester", $"{detail.ConnectionId.ToString()}_{Table}_{Date:yyyyMMdd-HHmmss}.xml");

            var doc = new XmlDocument();
            doc.LoadXml(FetchXml);
            doc.InsertBefore(doc.CreateComment($"Environment:{detail.ConnectionName}"), doc.ChildNodes[0]);
            doc.InsertBefore(doc.CreateComment($"Description:{Description}"), doc.ChildNodes[0]);

            using (var sw = new StreamWriter(filename))
            {
                sw.WriteLine(PrintXML(doc.OuterXml));
            }
        }
    }
}