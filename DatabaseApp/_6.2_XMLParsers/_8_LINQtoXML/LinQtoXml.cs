namespace _8_LINQtoXML
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class LinQtoXml
    {
        static void Main()
        {
            XDocument catalog = XDocument.Load(@"..\..\..\catalog.xml");
            var albums =
                catalog.Elements("albums").Elements("album")
                .Where(p => int.Parse(p.Element("year").Value) <= DateTime.Now.Year - 5)
                .Select(a=> new
                {
                    Title = a.Element("name").Value,
                    Price = decimal.Parse(a.Element("price").Value)
                });

            foreach (var album in albums)
            {
                Console.WriteLine("{0}: {1}", album.Title, album.Price);
            }
        }
    }
}
