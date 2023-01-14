using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCommonLib.DataProvider
{
    public class Config
    {
        public string TestUrl { get; set; }

        public string Browser { get; set; }

        public string BrowserLanguage { get; set; }

        public int ExplWaitOnMinutes { get; set; }
    }
}
