using CvNamespace;
using HumanNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyNamespace;

namespace EmployerNamespace
{
    class Employer : Human
    {


        public List<Vacancy> Vacansies { get; set; }
        public string Password { get; set; }
        public void IndexOfVacansies()
        {
            foreach (var item in Vacansies)
            {
                Console.WriteLine("index of vacansies");
                Console.WriteLine(Vacansies.IndexOf(item));
                Console.WriteLine(item.ToString());

            }
        }

        public override string ToString()
        {
            return $"password{Password }";
            foreach (var vacancy in Vacansies)
            {
                return vacancy.ToString();
            }


        }


    }
}