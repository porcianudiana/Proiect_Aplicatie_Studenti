using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incercare_proiect
{
    [Serializable]
    public class Profesor
    {
        public string NumePrenumeProf;
        public string SpecializareProf;
        public string Cod;
        public string Departament;

        public Profesor(string _numep, string _specializarep, string _cod,string _departament)
        {
            NumePrenumeProf = _numep;
            SpecializareProf = _specializarep;
            Cod = _cod;
            Departament = _departament;
        }

        public Profesor()
        {

        }

    }
}
