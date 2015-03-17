namespace _3_ExtractAllArtistAlphabetically
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class ExtractAllArtistAlphabetically
    {
        static void Main(string[] args)
        {
            var catalog = new XmlDocument();
            catalog.Load(@"..\..\..\catalog.xml");
            XmlNode root = catalog.DocumentElement;
            var artistNames = new SortedSet<string>();
            foreach (XmlNode album in root)
            {
                artistNames.Add(album["artist"].InnerText);
            }

            foreach (var artistName in artistNames)
            {
                Console.WriteLine(artistName);
            }
        }
    }
}
