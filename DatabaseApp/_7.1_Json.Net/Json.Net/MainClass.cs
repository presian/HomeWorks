namespace Json.Net
{
    using System.Diagnostics;
    using System.Linq;

    using Newtonsoft.Json;
    
    using Problems;

    class MainClass
    {
        static void Main()
        {
            //Create output folder
            Utility.CreateOutputFolder();

            // Problem 1
            DownloadSoftUniRss.DownloadFile(Utility.Url, Utility.XmlPath);

            // Open new xml
            Process.Start(Utility.XmlPath);
            
            // Problem 2
            var json = XmlToJson.ConvertToJson();

            // Preoblem 3
            var news = LinqToJson.PrintQuestionTitle(json);

            // Problem 4
            var pocos = news.Select(item => JsonConvert.DeserializeObject<JsonToPoco>(item.ToString())).ToList();

            // Problem 5
            PocoToHtml.MakeHtml(pocos);

            //Start Chreome!
            Process.Start(Utility.HtmlPath);
        }
    }
}
