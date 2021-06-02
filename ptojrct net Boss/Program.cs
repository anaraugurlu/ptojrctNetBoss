using CvNamespace;
using EmployerNamespace;
using JsonNamespace;
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
using BossProject;

namespace Boss
{

    class Program
    {


        static void Main(string[] args)
        {
            try
            {

                Json.JsonDesirializeVacancy();
                Json.JsonDesirislizeEmployers();
                Json.JsonDeserelizeCv();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            #region Objects


            List<CV> cvs1 = new List<CV>
                {
                    new CV
                    {
                        Speciality = "Programmer",
                        IsHonorsDiplom = true,
                        Companies = "Microsoft ,Cisco",
                        StartWorkTiime = new DateTime(2020, 1, 12),
                        EndWorkTime = new DateTime(2020, 12, 5),
                        School = "98",
                        Languages = "russian, english",
                        Skills = "c++,java,C#",
                        UniAdmissionScore = 700,
                        Id =0
                    }
                };

            List<CV> cvs2 = new List<CV>
            {
                 new CV
                {
                   Speciality =" Python-Django Engineer",
                   IsHonorsDiplom =true,
                   Companies ="Microsoft ,Cisco",
                   StartWorkTiime =new DateTime (2021,1,10),
                   EndWorkTime =new DateTime (2020,4,5),
                   School ="48",
                   Languages ="russian, english",
                   Skills ="Python",
                   UniAdmissionScore =600,
                   Id=1
                }
            };
            List<CV> cvs3 = new List<CV> {
                new CV
                {
                    Speciality = " Python-Django Engineer",
                    IsHonorsDiplom = true,
                    Companies = "Microsoft ,Cisco",
                    StartWorkTiime = new DateTime(2021, 1, 10),
                    EndWorkTime = new DateTime(2020, 4, 5),
                    School = "48",
                    Languages = "russian, english",
                    Skills = "Python",
                    UniAdmissionScore = 600,
                Id=2
                }
            };
            List<CV> cvs4 = new List<CV>
              {
  new CV
                {
                   Speciality ="programmer",
                   IsHonorsDiplom =true,
                   StartWorkTiime =new DateTime (2020,1,12),
                   EndWorkTime =new DateTime (2020,12,5),
                   School="122",
                   Languages =" english",
                   Skills ="java,C#",
                   UniAdmissionScore =500,
                   Id=3
                }
              };
            List<CV> cvs5 = new List<CV>
              {
 new CV
                {
                   Speciality ="driver",
                   IsHonorsDiplom =false,
                   StartWorkTiime =new DateTime (2019,1,12),
                   EndWorkTime =new DateTime (2020,12,5),
                   School ="55",
                   Languages =" english",
                   Skills ="B ,C",
                   UniAdmissionScore =500,
                   Id=4
                }
              };
            List<CV> cvs6 = new List<CV>
                   {
  new CV
                {
                   Speciality ="operator",
                   IsHonorsDiplom =false,
                   StartWorkTiime =new DateTime (2019,12,12),
                   EndWorkTime =new DateTime (2020,1,5),
                   School ="55",
                   Languages =" english",
                   Skills ="Word ,power point, excel",
                   UniAdmissionScore =500,
                   Id=5
                }
                   };


            List<Vacancy> vacancies1 = new List<Vacancy>
            {
                new Vacancy
                {
                    Salary =3000,
                    NameCompany ="Microsoft",
                    Languages ="English",
                    Skills ="C#",
                    Speciality ="Programmer",
                    Id=0
                },
                new Vacancy
                {
                    Salary =2500,
                    NameCompany ="Cisco",
                    Languages =" Russian ,English",
                    Skills ="C#,Java",
                    Speciality ="Programmer",
                    Id=1
                },
                new Vacancy
            {
                Salary = 1000,

                NameCompany = "Medica",
                    Skills = "b",
                Speciality = "Driver",
                Id=2
            },
                new Vacancy
                           {
                               Salary = 1000,
                               Languages ="english",
                               NameCompany = "School 78",
                                   Skills = "word excel",
                               Speciality = "Operator",
                               Id=3

                }
            };





            List<Employer> employeers = new List<Employer>
            {
                new Employer
                {
                    Name ="Kenan",
                    Surname ="Haciyev",
                    Age =30,
                    City ="baku",
                    //Id =guid,
                    PhoneNumber ="+994503332321",
                    Vacansies=vacancies1,
                    Password ="kenan123",
                    Id=0
                },
                new Employer
                {
                    Name ="Ayxan",
                    Surname ="Haciyev",
                    Age =26,
                    City ="baku",
                    //Id =guid,
                    PhoneNumber ="+996503332321",
                    Vacansies=vacancies1
                    ,Password ="ayxan123",
                    Id=1
                },
            };
            List<Worker> workers = new List<Worker>
            {
                new Worker
                {
                    Id=2,
                    Password ="nezrin12",
                    PhoneNumber ="12314255453",
                   Age =20,
                   Name ="Nezrin",
                   //Id =guid,
                   City ="Baku",
                   Surname ="Rehimli",
                  Cvs =cvs1

                },
                 new Worker
                {
                   Age =22,
                   Name ="Zeyneb",
                   Id =3,
                   City ="Baku",
                   Surname ="Esgerli",
                   Cvs=cvs2,
                   Password ="zeyneb12",
                   PhoneNumber ="12334453",

                },
                   new Worker
                {
                   Age =20,
                   Name ="Leyla",
                   Id =4,
                   City ="Gence",
                   Surname ="Memmedli",
                   Cvs=cvs3,
                   Password ="leyla123",
                   PhoneNumber ="12313432"
                },
                    new Worker
                {
                   Age =20,
                   Name ="Ferid",
                   Id =5,
                   City ="Qazax",
                   Surname ="Eliyev",
                   Cvs=cvs4,
                   Password ="ferid123",
                   PhoneNumber ="12313454"
                },
  new Worker
                {
      Password ="mahir123",
                   Age =20,
                   Name ="Mahir",
                   Id =6,
                   City ="Baku",
                   Surname ="Rehimov",
                   Cvs=cvs5,
                   PhoneNumber ="45653543"

                }
            };
            #endregion
            try

            {

                Json.JsonSerialize(workers, employeers, cvs1, cvs2, cvs3, cvs4, cvs5, cvs6, vacancies1);



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            bool istrue = true;
            while (istrue)
            {
                Console.WriteLine("include your username");
                string username2 = Console.ReadLine();
                Console.WriteLine("include password");
                string password = Console.ReadLine();

                try
                {
                    BossProgram.WorkerSection(istrue, username2, password, workers, employeers, cvs1, cvs2, cvs3, cvs4, cvs5, cvs6, vacancies1);

                    BossProgram.EmployerSection(istrue, employeers, username2, vacancies1, password, workers, cvs1, cvs2, cvs3, cvs4, cvs5, cvs6);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }








            }




        }
    }
}
