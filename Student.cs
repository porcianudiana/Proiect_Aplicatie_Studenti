using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incercare_proiect
{
    [Serializable]
    public class Student:Date
    {
        public string NumePrenume;
        public string Cnp;
        public string Id;
        public string Varsta;
       
       

        public Student(string _sp,string _fac,string _numeprenume,  string _cnp, string _id, string _varsta):
            base(_sp, _fac)
        {
            NumePrenume = _numeprenume;
            Cnp = _cnp;
            Id = _id;
            Varsta = _varsta;
           

        }
        public Student() : base(" ",  " ")
        {

        }

    }
}
