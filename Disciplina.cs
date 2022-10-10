using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incercare_proiect
{
    public class Disciplina:Date
    {
       
        public string Materie;
        public string GradObligativitate;
        
        public Disciplina(string _sp, string _fac,string _mat,  string _gradob):
            base(_sp,_fac)
        {
            
            Materie = _mat;
            GradObligativitate = _gradob;
           

        }
    }
}
