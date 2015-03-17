namespace _7_OldAlbums
{
    using System;
    using System.Globalization;
    using System.Xml;

    class OldAlbums
    {
        static void Main(string[] args)
        {
            var beforFiveYears = DateTime.Now.AddYears(-5).Year;
            XmlDocument catalog = new XmlDocument();
            catalog.Load(@"..\..\..\catalog.xml");
            var root = catalog.DocumentElement;
            var culture = root.Attributes["culture"].Value;
            var decimalFormat = new CultureInfo(culture);
            string query = "/albums/album";
            XmlNodeList albums = catalog.SelectNodes(query);
            foreach (XmlNode album in albums)
            {
                var year = int.Parse(album["year"].InnerText);
                if (year <= beforFiveYears)
                {
                    var price = decimal.Parse(album["price"].InnerText, decimalFormat);
                    var title = album["name"].InnerText;
                    Console.WriteLine("{0}: {1}", title, price); 
                }
            }
        }
    }
}
