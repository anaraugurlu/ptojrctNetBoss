using CvNamespace;
using EmployerNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyNamespace;
using WorkerNamespace;

namespace BossProject
{
    class BossProgram
    {

        public static void ShowVacanciesBySpeciality(List<Worker> worker, List<Vacancy> vacancies1)
        {
            foreach (var item in worker)
            {

                foreach (var item2 in item.Cvs)
                {
                    foreach (var item3 in vacancies1)
                    {

                        if (item2.Speciality == item3.Speciality)
                        {
                            Console.WriteLine(item3);
                        }

                    }
                }
            }
        }
        public static void ShowAllProgramCvs(List<CV> cvs1, List<CV> cvs2, List<CV> cvs3, List<CV> cvs4, List<CV> cvs5, List<CV> cvs6)
        {
            foreach (var c1 in cvs1)
            {
                Console.WriteLine(c1.ToString());
            }
            foreach (var c2 in cvs2)
            {
                Console.WriteLine(c2.ToString());
            }
            foreach (var c3 in cvs3)
            {
                Console.WriteLine(c3.ToString());
            }
            foreach (var c4 in cvs4)
            {
                Console.WriteLine(c4.ToString());
            }
            foreach (var c5 in cvs5)
            {
                Console.WriteLine(c5.ToString());
            }
            foreach (var c6 in cvs6)
            {
                Console.WriteLine(c6.ToString());
            }
        }
        public static void WorkerSection
            (bool istrue2, string username, string password, List<Worker> workers, List<Employer> employeers, List<CV> cvs1, List<CV> cvs2, List<CV> cvs3, List<CV> cvs4, List<CV> cvs5, List<CV> cvs6, List<Vacancy> vacancies1)
        {
            List<Worker> worker = workers
                             .Where(c => c.Username == username && c.Password == password && c.Password.Length == 8)
                             .ToList();


            if (worker.Count > 0)
            {
                istrue2 = false;
                bool istrue = true;
                while (istrue)
                {

                    Console.WriteLine("1-SHOW VACANCIES");
                    Console.WriteLine("2-ADD CV");
                    Console.WriteLine("3-REMOVE CV");
                    Console.WriteLine("4-UPDATE CV");
                    Console.WriteLine("5-EXIT");
                    Console.WriteLine("6-SHOW ALL CVeS ");
                    bool isint = int.TryParse(Console.ReadLine(), out int cv);
                    if (cv == 1)
                    {

                        ShowVacanciesBySpeciality(worker, vacancies1);


                    }

                    else if (cv == 2)
                    {
                        #region addCv

                        Console.WriteLine("include speciality");
                        string speciality = Console.ReadLine();
                        Console.WriteLine("School");
                        string school = Console.ReadLine();
                        Console.WriteLine("skills");
                        string skills = Console.ReadLine();
                        Console.WriteLine("companies");
                        string companies = Console.ReadLine();
                        Console.WriteLine("languages");
                        string languages = Console.ReadLine();
                        Console.WriteLine(" university admission score");
                        bool isadmissionscore = int.TryParse(Console.ReadLine(), out int admissionscore);
                        Console.WriteLine("include start work time ");
                        Console.WriteLine("year");
                        bool isyear = int.TryParse(Console.ReadLine(), out int year1);
                        Console.WriteLine("month");
                        bool ismonth = int.TryParse(Console.ReadLine(), out int month1);
                        Console.WriteLine("day");
                        bool isday = int.TryParse(Console.ReadLine(), out int day1);
                        Console.WriteLine("include end work time ");
                        Console.WriteLine("year");
                        bool isyear2 = int.TryParse(Console.ReadLine(), out int year2);
                        Console.WriteLine("month");
                        bool ismonth2 = int.TryParse(Console.ReadLine(), out int month2);
                        Console.WriteLine("day");
                        bool isday2 = int.TryParse(Console.ReadLine(), out int day2);
                        CV cv2 = new CV
                        {
                            StartWorkTiime = new DateTime(year1, month1, day1),
                            EndWorkTime = new DateTime(year2, month2, day2),
                            Speciality = speciality,
                            School = school,
                            Skills = skills,
                            IsHonorsDiplom = false,
                            Companies = companies,
                            Languages = languages,
                            UniAdmissionScore = admissionscore
                        };
                        Console.WriteLine("this cv was added");

                        foreach (var item in worker)
                        {
                            item.Cvs.Add(cv2);
                        }
                        Console.WriteLine(cv.ToString());
                        #endregion 
                    }
                    else if (cv == 3)
                    {
                        #region removeCv
                        foreach (var item in worker)
                        {
                            item.IndexOfCv();
                            Console.WriteLine("Enter the index of the CV you want to delete");
                            bool isbool = int.TryParse(Console.ReadLine(), out int result2);

                            item.Cvs.RemoveAt(result2);


                            Console.WriteLine("cv was deleted");
                        }
                        #endregion 
                    }
                    else if (cv == 4)
                    {
                        #region updateCv

                        Console.WriteLine("include speciality");
                        string speciality = Console.ReadLine();
                        Console.WriteLine("School");
                        string school = Console.ReadLine();
                        Console.WriteLine("skills");
                        string skills = Console.ReadLine();
                        Console.WriteLine("companies");
                        string companies = Console.ReadLine();
                        Console.WriteLine("languages");
                        string languages = Console.ReadLine();
                        Console.WriteLine(" university admission score");
                        bool isadmissionscore = int.TryParse(Console.ReadLine(), out int admissionscore);
                        Console.WriteLine("include start work time ");
                        Console.WriteLine("year");
                        bool isyear = int.TryParse(Console.ReadLine(), out int year1);
                        Console.WriteLine("month");
                        bool ismonth = int.TryParse(Console.ReadLine(), out int month1);
                        Console.WriteLine("day");
                        bool isday = int.TryParse(Console.ReadLine(), out int day1);
                        Console.WriteLine("include end work time ");
                        Console.WriteLine("year");
                        bool isyear2 = int.TryParse(Console.ReadLine(), out int year2);
                        Console.WriteLine("month");
                        bool ismonth2 = int.TryParse(Console.ReadLine(), out int month2);
                        Console.WriteLine("day");
                        bool isday2 = int.TryParse(Console.ReadLine(), out int day2);
                        foreach (var item in worker)
                        {
                            item.IndexOfCv();

                        }
                        Console.WriteLine("include index of cv you want update");
                        bool isindex = int.TryParse(Console.ReadLine(), out int index);


                        CV cv5 = new CV
                        {
                            StartWorkTiime = new DateTime(year1, month1, day1),
                            EndWorkTime = new DateTime(year2, month2, day2),
                            Speciality = speciality,
                            School = school,
                            Skills = skills,
                            IsHonorsDiplom = false,
                            Companies = companies,
                            Languages = languages,
                            UniAdmissionScore = admissionscore
                        };

                        foreach (var item in worker)
                        {
                            item.Cvs[index] = cv5;
                        }
                        Console.WriteLine("cv was updated");
                        #endregion 
                    }
                    else if (cv == 5)
                    {
                        istrue = false;
                        Console.WriteLine("include your username");
                        string username2 = Console.ReadLine();
                        Console.WriteLine("include password");
                        string password2 = Console.ReadLine();
                        BossProgram.WorkerSection(istrue, username2, password, workers, employeers, cvs1, cvs2, cvs3, cvs4, cvs5, cvs6, vacancies1);
                        BossProgram.EmployerSection(istrue, employeers, username2, vacancies1, password2, workers, cvs1, cvs2, cvs3, cvs4, cvs5, cvs6);
                    }
                    else if (cv == 6)
                    {
                        ShowAllProgramCvs(cvs1, cvs2, cvs3, cvs4, cvs5, cvs6);
                    }

                }
            }
        }
        public static void EmployerSection(bool istrue2, List<Employer> employeers, string username, List<Vacancy> vacancies1, string password, List<Worker> workers, List<CV> cvs1, List<CV> cvs2, List<CV> cvs3, List<CV> cvs4, List<CV> cvs5, List<CV> cvs6)
        {
            List<Employer> employer = employeers
                                 .Where(e => e.Username == username && e.Password == password && e.Password.Length == 8)
                                 .ToList();
            if (employer.Count > 0)
            {
                istrue2 = false;
                bool istrue = true;
                while (istrue)
                {

                    Console.WriteLine("1-ADD VACANCY");
                    Console.WriteLine("2-REMOVE VACANCY");
                    Console.WriteLine("3-UPDATE VACANCY");
                    Console.WriteLine("4-EXIT");
                    Console.WriteLine("5-SHOW WORKERS by filters");
                    bool isint = int.TryParse(Console.ReadLine(), out int cv);
                    if (cv == 1)
                    {
                        #region addVacancy
                        Console.WriteLine("include name of company");
                        string namecompany = Console.ReadLine();
                        string[] specialities = { "programmer", "Driver", "teacher", "operator" };

                        Console.WriteLine(" choose speciality");
                        Console.WriteLine("0-programmer");
                        Console.WriteLine("1-driver");
                        Console.WriteLine("2-teacher");
                        Console.WriteLine("3-operator");

                        bool isspec = int.TryParse(Console.ReadLine(), out int speciality);
                        Console.WriteLine("skills");
                        string skills = Console.ReadLine();
                        Console.WriteLine("companies");
                        string languages = Console.ReadLine();
                        Console.WriteLine(" choose salary ");
                        Console.WriteLine("0-1000");
                        Console.WriteLine("1-2000");
                        Console.WriteLine("2-3000");
                        Console.WriteLine("3-4000");
                        bool issalary = int.TryParse(Console.ReadLine(), out int salary);
                        int[] salaryies = { 1000, 2000, 3000, 4000 };
                        Vacancy vc = new Vacancy
                        {
                            Speciality = specialities[speciality],
                            Skills = skills,
                            Languages = languages,
                            Salary = salaryies[salary],
                            NameCompany = namecompany
                        };
                        Console.WriteLine("this vacancy was added");

                        foreach (var item in employer)
                        {
                            item.Vacansies.Add(vc);
                        }
                        Console.WriteLine(vc.ToString());

                    }
                    else if (cv == 2)
                    {
                        foreach (var item in employer)
                        {
                            item.IndexOfVacansies();
                            Console.WriteLine("Enter the index of the Vacancy you want to delete");
                            bool isbool = int.TryParse(Console.ReadLine(), out int result2);

                            item.Vacansies.RemoveAt(result2);


                            Console.WriteLine("vacancy was deleted");
                        }
                        #endregion 
                    }
                    else if (cv == 2)
                    {
                        #region removeVacancy
                        foreach (var item in employeers)
                        {
                            item.IndexOfVacansies();
                            Console.WriteLine("Enter the index of the Vacancy you want to delete");
                            bool isbool = int.TryParse(Console.ReadLine(), out int result2);

                            item.Vacansies.RemoveAt(result2);


                            Console.WriteLine("vacancy was deleted");
                        }
                        #endregion 
                    }
                    else if (cv == 3)
                    {
                        #region UpdateVacancy
                        Console.WriteLine("include name of company");
                        string namecompany = Console.ReadLine();
                        Console.WriteLine("Speciality");

                        string[] specialities = { "programmer", "Driver", "teacher", "operator", Console.ReadLine() };

                        Console.WriteLine(" choose city");
                        Console.WriteLine("0-programmer");
                        Console.WriteLine("1-driver");
                        Console.WriteLine("2-teacher");
                        Console.WriteLine("3-operator");
                        Console.WriteLine("4-other");
                        bool isspec = int.TryParse(Console.ReadLine(), out int speciality);


                        Console.WriteLine("skills");
                        string skills = Console.ReadLine();
                        Console.WriteLine("languages");

                        string languages = Console.ReadLine();
                        Console.WriteLine(" choose salary ");
                        Console.WriteLine("0-1000");
                        Console.WriteLine("1-2000");
                        Console.WriteLine("2-3000");
                        Console.WriteLine("3-4000");

                        bool issalary = int.TryParse(Console.ReadLine(), out int salary);




                        int[] salaryies = { 1000, 2000, 3000, 4000 };

                        foreach (var item in employer)
                        {
                            item.IndexOfVacansies();

                        }
                        Console.WriteLine("include index of vacancy you want update");
                        bool isindex = int.TryParse(Console.ReadLine(), out int index);
                        Vacancy vc = new Vacancy
                        {
                            Speciality = specialities[speciality],
                            Skills = skills,
                            Languages = languages,
                            Salary = salaryies[salary],
                            NameCompany = namecompany
                        };
                        foreach (var item in employer)
                        {
                            item.Vacansies[index] = vc;
                        }
                        Console.WriteLine("vacancy was updated");
                        #endregion 
                    }


                    else if (cv == 4)
                    {
                        istrue = false;
                        Console.WriteLine("include your username");
                        string username2 = Console.ReadLine();
                        Console.WriteLine("include password");
                        string password2 = Console.ReadLine();
                        BossProgram.WorkerSection(istrue, username2, password, workers, employeers, cvs1, cvs2, cvs3, cvs4, cvs5, cvs6, vacancies1);
                        BossProgram.EmployerSection(istrue, employeers, username2, vacancies1, password2, workers, cvs1, cvs2, cvs3, cvs4, cvs5, cvs6);
                    }
                    else if (cv == 5)
                    {


                        #region showWorkers    

                        List<Worker> workersage = workers
                                    .Where(w => w.Age > 18)
                                    .ToList();
                        List<Worker> workersInBaku = workers
                                .Where(w => w.City == "Baku")
                                .ToList();
                        List<Worker> workersSurname = workers
                                .Where(w => w.Surname.Length > 8)
                                .ToList();

                        Console.WriteLine("show Employees over 18 years of age");
                        foreach (var item in workersage)
                        {
                            Console.WriteLine(item.ToString());
                        }



                        Console.WriteLine("show workers living in Baku");
                        foreach (var item2 in workersInBaku)
                        {
                            Console.WriteLine(item2.ToString());
                        }

                        Console.WriteLine(" show employees with a surname of more than 8");
                        foreach (var item3 in workersSurname)
                        {
                            Console.WriteLine(item3.ToString());
                        }


                        Console.WriteLine(" show all workers");
                        foreach (var item in workers)
                        {
                            Console.WriteLine(item.ToString());

                        }
                        #endregion 
                    }
                }



            }
        }
    }
}



