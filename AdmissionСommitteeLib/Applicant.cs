using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionСommitteeLib
{
    public class Applicant
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SNILS { get; set; }
        public string Address { get; set; }
    }
}
