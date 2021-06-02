using CvNamespace;
using HumanNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyNamespace;

namespace WorkerNamespace
{
    class Worker : Human
    {
        public List<CV> Cvs { get; set; }
        public string Password { get; set; }

        public void IndexOfCv()
        {
            foreach (var item in Cvs)
            {
                Console.WriteLine("index of cv");
                Console.WriteLine(Cvs.IndexOf(item));
                Console.WriteLine(item.ToString());
            }
        }


        public override string ToString()
        {

            foreach (var item in Cvs)
            {
                return $"Cv:{item}";

            }

            return "empty";
        }
    }
}