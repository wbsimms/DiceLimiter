using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLimiter
{
    public class HtmlDataDumper
    {
        StringBuilder sb = new StringBuilder();

        private string basestring =
            "<table><thead><tr><th>Technology</th><th>Count</th></tr></thead><tbody>{0}</tbody></table>";
        public HtmlDataDumper()
        {
        }

        public void AddRow(string technology, int count)
        {
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>\r\n",technology,count);
        }

        public string GetHtmlData()
        {
            return string.Format(basestring, sb.ToString());
        }
    }
}
