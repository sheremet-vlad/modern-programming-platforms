using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Xsl;
using System.Text;
using System.IO;

namespace RssReader
{
    class Rss
    {
        private string _URL;
        private string XML_FileName;
        private string HTML_FileName;
        private string XSL_FileName;
        public Rss(string URL) : this(URL, "feed.xsl") { }
        public Rss(string URL, string XSLT_File)
        {
            if (!Directory.Exists("files")) Directory.CreateDirectory("files");
            XML_FileName = @"files\" + EscapeUrl(URL) + ".xml";
            HTML_FileName = @"files\" + EscapeUrl(URL) + ".htm";
            long dt = 0;
            if (File.Exists(XML_FileName))
                dt = DateTime.Now.Ticks - File.GetCreationTime(XML_FileName).Ticks;
            XSL_FileName = XSLT_File;
            _URL = URL;
            if (!(File.Exists(XML_FileName) && dt < 3600e8))
                /* если лента уже была обновлена в течении предыдущего часа 
                * то загрузим её из локального файла */
                try
                {
                    System.Net.WebClient client = new System.Net.WebClient();
                    client.DownloadFile(_URL, XML_FileName);
                    string sXML = File.ReadAllText(XML_FileName, Encoding.GetEncoding(1251));
                    sXML = Regex.Replace(sXML, @"<\?xml-stylesheet.*\?>", "");
                    sXML = Regex.Replace(sXML, @"<\w+\sxmlns:xsi.*\.xsd.?\s*>", "");
                    sXML = Regex.Replace(sXML, @"", "");
                    File.WriteAllText(XML_FileName, sXML, Encoding.GetEncoding(1251));
                }
                catch (XmlException e)
                {
                }
        }

        private string EscapeUrl(string s)
        {
            return
            s.Replace('/', '_').Replace(".xml", "").Replace("http:__", "").Replace("www.", "");
        }
        public string TransformToHTML()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(XSL_FileName);
            xslt.Transform(XML_FileName, HTML_FileName);
            return HTML_FileName;
        }
    }
}
