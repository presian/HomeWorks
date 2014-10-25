using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_StringBuilder_Extensions
{
    public static class Extensions
    {
        // Substring
        public static string Substring(this StringBuilder str, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex > str.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (startIndex + length > str.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            StringBuilder resultStr = new StringBuilder("");
            for (int i = startIndex; i < startIndex + length; i++)
            {
                resultStr.Append(str[i]);
            }
            return resultStr.ToString();
        }

        // RemoveText
        public static StringBuilder RemoveText(this StringBuilder str, string sub)
        {
            int length = sub.Length;
            sub = sub.ToLower();
            string checker = str.ToString().ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if ((checker[i] == sub[0]) && (i + length < checker.Length))
                {
                    string temp = "" + checker[i];
                    for (int j = 1; j < sub.Length; j++)
                    {
                        if (checker[i + j] == sub.ToLower()[j])
                        {
                            temp += sub[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (temp == sub)
                    {
                        str.Remove(i, length);
                    }
                }
            }
            return str;
        }

        // AppendAll
        public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> itemes)
        {

            foreach (T iteme in itemes)
            {
                str.Append(iteme.ToString());
            }
            return str;
        }
    }
}
