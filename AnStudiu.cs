using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incercare_proiect
{
     public class AnStudiu:Disciplina
    {
        public string Numar;
        public int Nrlocuri;
        public AnStudiu(string _sp,string _fac, string _mat, string _gradob,string _numar, int _nrlocuri) :
            base(_sp,_fac,_mat,_gradob)
        {
            Numar = _numar;
            Nrlocuri = _nrlocuri;
        }
    }
}
