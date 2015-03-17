namespace _5_ExtractArtistsAndNumberOfAlbumsWithXpath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class ExtractArtistsAndNumberOfAlbumsWithXpath
    {
        static void Main(string[] args)
        {
            var catalog = new XmlDocument();
            catalog.Load(@"..\..\..\catalog.xml");
            string artistQuery = "/albums/album";
            XmlNodeList albums = catalog.SelectNodes(artistQuery);
            var artistAlbums = new Dictionary<string, int>();
            foreach (XmlNode album in albums)
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

            foreach (var item in artistAlbums)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}
