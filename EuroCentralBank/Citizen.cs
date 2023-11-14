using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPenda
{
    public class Citizen : Person
    {
        public bool noSolde { get; set; }
        public int child { get; set; }
        public int pil { get; set; }
        public bool debit { get; set; }

        public Municipality _municipality;

       
        public Citizen(string firstName, string lastName, int _year, bool _noSolde, int _child, int _pil, bool _debit)
                : base(firstName, lastName, _year)
            {
                noSolde = _noSolde;
                child = _child;
                pil = _pil;
                debit = _debit;
                _municipality.AddCitizen(this);

            }

        public void ChangeMunicipality(Municipality municipality)
        {
            _municipality.RemoveCirizen();
            _municipality = municipality;

        }

    }
}
