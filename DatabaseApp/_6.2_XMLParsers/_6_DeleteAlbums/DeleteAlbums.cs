namespace _6_DeleteAlbums
{
    using System.Globalization;
    using System.Xml;

    class DeleteAlbums
    {
        private static void Main(string[] args)
        {
            XmlDocument catalog = new XmlDocument();
            catalog.Load(@"..\..\..\catalog.xml");
            var root = catalog.DocumentElement;
            var culture = root.Attributes["culture"].Value;
            var numberFormat = new CultureInfo(culture);
            foreach (XmlNode album in root)
            {
                if (decimal.Parse(album["price"].InnerText, numberFormat) > 20m)
                {
                    root.RemoveChild(album);
                }
            }

            catalog.Save(@"..\..\..\cheap-albums-catalog.xml");
        }
    }
}
