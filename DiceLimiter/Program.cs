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
        public static void Main()
        {
            string[] technologies = new[] {"jquery", ".NET", "C#", "java", "cobol", "javascript","perl","python","ruby","c++","objective-c","php","wordpress","node.js","knockout.js","VB"};
            DiceLimit dl = new DiceLimit(); 
            foreach (string technology in technologies)
            {
                int count = dl.GetDiceCount(technology);
                Console.WriteLine(technology+"\t"+count);
            }
        }
    }
}
