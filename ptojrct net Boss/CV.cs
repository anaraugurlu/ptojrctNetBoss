using Boss;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvNamespace
{
    class CV
    {

        public int Id { get; set; }
        public bool IsHonorsDiplom { get; set; }
        public string Speciality { get; set; }
        public string School { get; set; }
        public int UniAdmissionScore { get; set; }
        public string Skills { get; set; }
        public string Companies { get; set; }
        public DateTime StartWorkTiime { get; set; }
        public DateTime EndWorkTime { get; set; }
        public string Languages { get; set; }
        public override string ToString()
        {

            return $@"speciality:{Speciality }
                          School:{School }
                              ID{Id }
      univercity admission score:{UniAdmissionScore }
                          Skills:{Skills }
                       Languages:{Languages }";

        }

    }
}