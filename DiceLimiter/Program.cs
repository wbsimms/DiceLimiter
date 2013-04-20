using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceLimiterLib;

namespace DiceLimiter
{
    public class Program
    {
        private static HtmlDataDumper htmlDataDumper = null; 

        public static void Main(string[] args)
        {
            string[] technologies = new[] { "jquery", ".NET", "C#", "java", "cobol", "javascript", "perl", "python", "ruby", "c++", "objective-c", "php", "wordpress", "node.js", "knockout.js", "VB" };
            if (args.Count() >= 0 && args[0] == "html") htmlDataDumper = new HtmlDataDumper();

            DiceLimit dl = new DiceLimit(); 
            foreach (string technology in technologies)
            {
                int count = dl.GetDiceCount(technology);
                if (htmlDataDumper != null) htmlDataDumper.AddRow(technology,count);
                Console.WriteLine(technology+"\t"+count);
            }
            if (htmlDataDumper != null) Console.WriteLine(htmlDataDumper.GetHtmlData());
        }
    }
}
