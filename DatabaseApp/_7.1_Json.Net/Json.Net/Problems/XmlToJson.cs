// Problem 2.	Parse the XML from the feed to JSON
namespace Json.Net.Problems
{
    using System.Xml.Linq;

    using Newtonsoft.Json;

    public static class XmlToJson
    {
        public static string ConvertToJson()
        {
            XDocument doc = XDocument.Load(Utility.XmlPath);
            var result = JsonConvert.SerializeXNode(doc, Formatting.Indented);
            return result;
        }
    }
}
