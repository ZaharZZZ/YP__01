using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionСommitteeLib
{
    public interface IApplicantDBManager
    {
        bool CheckApplicantExists(int id);
        bool InsertApplicant(Applicant applicant);
    }
}
