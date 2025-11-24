using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionСommitteeLib
{
    public class StudyProgram
    {
        public int Id { get; set; }
        public string ProgramCode { get; set; } = string.Empty;
        public string ProgramName { get; set; } = string.Empty;
        public int BudgetPlaces { get; set; }
        public int ContractPlaces { get; set; }
        public decimal TuitionFee { get; set; }

        public override string ToString()
        {
            return $"{ProgramName} ({ProgramCode})";
        }
    }
}
