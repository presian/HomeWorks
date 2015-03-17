﻿namespace _10_XElementDirectoryContentsAsXML
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class XElementDirectoryContentsAsXml
    {
   

        private const string DirectoryToTraverse = @"..\..\";

        internal static void Main()
        {
            Console.Write("Loading...");
            BuildXmlDirectoryTree();
            Console.Write("\r");
        }
 
        private static void BuildXmlDirectoryTree()
        {
            var startupDirectory = new DirectoryInfo(DirectoryToTraverse);
            var xmlDirectoryTree = BuildXmlDirectoryTree(startupDirectory);
            var xDocument = new XDocument(xmlDirectoryTree);
            xDocument.Save("../../directory.xml");
        }

        private static XElement BuildXmlDirectoryTree(DirectoryInfo dirInfo)
        {
            var directoriesXml = new XElement("directories");
            var subtreeXml = BuildXmlForDirectoryRecursively(dirInfo);
            directoriesXml.Add(subtreeXml);
            return directoriesXml;
        }

        private static XElement BuildXmlForDirectoryRecursively(DirectoryInfo dirInfo)
        {
            var dirXml = new XElement("dir", new XAttribute("name", dirInfo.Name));

            foreach (var file in dirInfo.GetFiles())
            {
                var fileXml = new XElement("file", new XAttribute("name", file.Name));
                dirXml.Add(fileXml);
            }

            foreach (var dir in dirInfo.GetDirectories())
            {
                dirXml.Add(BuildXmlForDirectoryRecursively(dir));
            }

            return dirXml;
        }
    }
}
