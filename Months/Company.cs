using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExamples
{
    public class Company
    {
        private Person[] people;
        public Company()
        {
            people = new Person[]
            {
                new Person("Khachatur","Manukyan"),
                new Person("Suren", "Avdalyan"),
                new Person("Mher", "Paronyan"),

            };
        }

        public Person this[int index]
        {
            get { return people[index]; }
            set { people[index] = value; }
        }
    }
}
