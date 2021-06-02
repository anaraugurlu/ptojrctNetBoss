using Boss;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanNamespace
{
    abstract class Human
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username => Name + Surname;

        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $@"  ID:{Id}
                      Name:{Name }
                   Surname:{Surname }
               Phone number:{PhoneNumber }
                       City:{City}
                       Age :{Age}  
                   ";
        }
    }
}
