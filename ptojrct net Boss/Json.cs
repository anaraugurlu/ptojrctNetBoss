using CvNamespace;
using EmployerNamespace;
using HumanNamespace;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyNamespace;
using WorkerNamespace;

namespace JsonNamespace
{
    class Json
    {
        #region DesiralizeANdSerialize
        public static void JsonSerialize
            (List<Worker> workers, List<Employer> employeers, List<CV> cvs1, List<CV> cvs2, List<CV> cvs3, List<CV> cvs4, List<CV> cvs5, List<CV> cvs6, List<Vacancy> vacancies1)
        {


            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("boss.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, cvs6);
                    serializer.Serialize(jw, cvs5);
                    serializer.Serialize(jw, cvs4);
                    serializer.Serialize(jw, cvs3);
                    serializer.Serialize(jw, cvs2);
                    serializer.Serialize(jw, cvs1);
                    serializer.Serialize(jw, workers);
                    serializer.Serialize(jw, vacancies1);

                    serializer.Serialize(jw, employeers);

                }
            }





        }







        public static void JsonDesirislizeEmployers()
        {
            Employer[] employers = null;

            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("boss.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    employers = serializer.Deserialize<Employer[]>(jr);
                }
                foreach (var employer in employers)
                {
                    Console.WriteLine(employer);
                }
            }
        }
        public static void JsonDesirializeVacancy()
        {
            Vacancy[] vacancies = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("boss.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    vacancies = serializer.Deserialize<Vacancy[]>(jr);
                }
                foreach (var vacancy in vacancies)
                {
                    Console.WriteLine(vacancy);
                }
            }

        }

        public static void JsonDeserelizeCv()
        {

            CV[] Cvs = null;
            var serializer = new JsonSerializer();


            using (var sr = new StreamReader("boss.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {

                    Cvs = serializer.Deserialize<CV[]>(jr);


                }
                foreach (var cv in Cvs)
                {
                    Console.WriteLine(cv);
                }

            }
        }
        #endregion
    }
}