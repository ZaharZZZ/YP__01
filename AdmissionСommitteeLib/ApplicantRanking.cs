using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionСommitteeLib
{
    public class ApplicantRanking
    {
        public string FullName { get; set; } = string.Empty;
        public string ProgramName { get; set; } = string.Empty;
        public decimal TotalScore { get; set; }
        public int Position { get; set; }
        public string ListType { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{FullName} - {ProgramName} ({TotalScore} баллов)";
        }
    }
}
