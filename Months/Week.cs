using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExamples
{
    public class Week
    {
        private string[] week = new string[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        public string this[int index]
        {
            get { return week[index]; }
            set { week[index] = value; }
        }
    }
}
