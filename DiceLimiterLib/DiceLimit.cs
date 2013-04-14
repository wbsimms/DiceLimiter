using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiceLimiterLib
{
    public class DiceLimit
    {
        public const string BASETEMPLATE = "http://www.dice.com/job/results?caller=basic&q={0}&x=all&p=";

        public DiceLimit()
        {
        }

        public int GetDiceCount(string technology)
        {
            string urlsafe = technology.Replace(" ", "+");
            string url = string.Format(BASETEMPLATE, urlsafe);

            WebClient webClient = new WebClient();

            Stream data  = webClient.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string html = reader.ReadToEnd();
            return ParseDicePage(html);
        }

        public int ParseDicePage(string html)
        {
            int count = 0;
            string firstMatch = "Search results: 1 - ";
            int firstMatchLength = firstMatch.Length;
            int start = html.IndexOf(firstMatch, 0);
            int end = html.IndexOf("</h2>", start);
            string found = html.Substring(start + firstMatchLength, end - start - firstMatchLength);
            string countString = found.Split(' ')[2];
            count = Int32.Parse(countString);
            return count;
        }


    }
}
