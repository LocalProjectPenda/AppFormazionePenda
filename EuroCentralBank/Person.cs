using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPenda
{
   public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int _year { get; set; }
        public string CodeFiscal { get; set; }



        public Person(string modelFirstName, string modellastName, int modelYear)
        {
            firstName = modelFirstName;
            lastName = modellastName;
            _year = modelYear;

        }
        public string fullName
        {
            get { return $" {firstName} {lastName}"; }
            set { }
        }
    }
}
