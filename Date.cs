using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incercare_proiect
{
    [Serializable]
    public class Date
    {
        public string Specializare;
        public string Facultate;



        public Date(string _sp,string _fac)
        {
            Specializare = _sp;
            Facultate = _fac;
        }
    }
}
