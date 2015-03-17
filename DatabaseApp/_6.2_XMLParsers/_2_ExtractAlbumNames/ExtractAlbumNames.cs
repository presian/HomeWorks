namespace _2_ExtractAlbumNames
{
    using System;
    using System.Xml;

    class ExtractAlbumNames
    {
        static void Main(string[] args)
        {
            var catalog = new XmlDocument();
            catalog.Load(@"..\..\..\catalog.xml");
            XmlNode root = catalog.DocumentElement;
            foreach (XmlNode album in root)
            {
                Console.WriteLine("Album name: {0}", album["name"].InnerText);
            }
        }
    }
}
