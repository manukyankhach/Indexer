using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExamples
{
    public class Months
    {
        private string[] months = new string[]
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "Augost",
            "September",
            "October",
            "November",
            "December"
        };
        public string this[int index]
        {
            get { return months[index]; }
            set { months[index] = value; }
        }
    }
}
