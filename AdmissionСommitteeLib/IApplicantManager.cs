using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionСommitteeLib
{
    public interface IApplicantManager
    {
        List<ApplicantRanking> GetApplicantRankings();
        List<Applicant> GetApplicants();
        string AddApplicant(Applicant applicant);
        string DeleteApplicant(int applicantId);
        List<StudyProgram> GetStudyPrograms();

        string AddApplicantWithDocuments(Applicant applicant,
    string documentType, string documentSeries, string documentNumber,
    int yearOfGraduation, decimal gpa, int programId, string educationForm,
    string fundingSource, bool originalProvided);
    }
}
