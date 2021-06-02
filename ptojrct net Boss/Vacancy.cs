using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyNamespace
{
    class Vacancy
    {
        public int Id { get; set; }
        public string NameCompany { get; set; }

        public string Speciality { get; set; }
        public string Skills { get; set; }
        public string Languages { get; set; }
        public int Salary { get; set; }


        public override string ToString()
        {
            return $@"   name of company- {NameCompany }
                         speciality       {Speciality }
                         skills-       {Skills}
the language you need to know: {Languages}
                   salary   :  {Salary}";
        }
    }
}
