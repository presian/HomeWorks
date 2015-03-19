//Problem 4.	Parse the JSON string to POCO

namespace Json.Net.Problems
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public static class PocoToHtml
    {
        public static void MakeHtml(List<JsonToPoco> pocos)
        {
            var result = new StringBuilder();
            result.Append("<!DOCTYPE html><html><head></head><body>");
            foreach (var jsonToPoco in pocos)
            {
                result.Append(jsonToPoco.ToString());
            }

            result.Append("</body></html>");
            File.WriteAllText(Utility.HtmlPath, result.ToString());


        }
    }
}
