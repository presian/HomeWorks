namespace _4_ExtractArtistsAndNumberOfAlbums
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class ExtractArtistsAndNumberOfAlbums
    {
        static void Main(string[] args)
        {
            var catalog = new XmlDocument();
            catalog.Load(@"..\..\..\catalog.xml");
            var root = catalog.DocumentElement;
            var artistAlbums = new Dictionary<string, int>();
            foreach (XmlNode album in root)
            {
                var artistName = album["artist"].InnerText;
                if (artistAlbums.ContainsKey(artistName))
                {
                    artistAlbums[artistName] = artistAlbums[artistName] + 1;
                }
                else
                {
                    artistAlbums[artistName] = 1;
                }
            }

            foreach (var artistAlbum in artistAlbums)
            {
                Console.WriteLine("{0}: {1}", artistAlbum.Key, artistAlbum.Value);
            }
        }
    }
}
