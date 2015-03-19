//Problem 1.	Download the content of the SoftUni RSS feed
//SoftUni RSS Feed: https://softuni.bg/Feed/News
//Your task is to download SoftUni RSS feed programmatically. You can use WebClient.DownloadFile().

namespace Json.Net.Problems
{
    using System.Net;

    public static class DownloadSoftUniRss
    {
        public static void DownloadFile(string url, string filePath)
        {
            var client = new WebClient();
            client.DownloadFile(Utility.Url, Utility.XmlPath);
        }
    }
}
