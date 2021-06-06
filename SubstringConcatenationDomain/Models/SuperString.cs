using System;
using System.Collections.Generic;
using System.Linq;

namespace SubstringConcatenationDomain.Models
{
    public class SuperString
    {
        public static List<int> FindSubstring(string str, string[] words)
        {
            int step = words[0].Length;
            var index = 0;

            var result = new List<int>();
            int totalLength = step * words.Length;

            while (index + totalLength <= str.Length)
            {
                int begin = index;
                List<string> tempList = words.ToList();

                while (index + step <= str.Length && tempList.Count > 0)
                {
                    if (tempList.Contains(str.Substring(index, Math.Abs(index - (index + step)))))
                    {
                        tempList.Remove(str.Substring(index, Math.Abs(index - (index + step))));
                        index = index + step;
                    }
                    else
                    {
                        break;
                    }
                }

                if (tempList.Count == 0)
                {
                    result.Add(begin);
                }
                
                index = begin + 1;
            }

            return result;
        }
    }
}