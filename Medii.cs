using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incercare_proiect
{
    public class Medii:Disciplina
    {
       public double nota;

        public Medii(string _sp, string _fac,string _mat, string _gradob, double _nota):
            base(_sp,_fac,_mat, _gradob)
        {
            nota = _nota;

        }

        public Medii():base(" "," ", " "," ")
        {

        }

    }
}
