using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Week Days - {week[i]}");
            }

            Console.WriteLine("==========================");

            Months months = new Months();
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Months of Year - {months[i]}");
            }

            Console.WriteLine("==========================");

            Company company = new Company();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Person of Company - {company[i].FirstName} {company[i].LastName}");
            }

            Console.ReadLine();
        }
    }
}
