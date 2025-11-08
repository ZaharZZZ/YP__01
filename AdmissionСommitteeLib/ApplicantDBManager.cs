using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionСommitteeLib
{
    public class ApplicantDBManager : IApplicantDBManager
    {
        public bool CheckApplicantExists(int id)
        {
            // Реализация проверки существования абитуриента в БД
            return false;
        }

        public bool InsertApplicant(Applicant applicant)
        {
            // Реализация вставки абитуриента в БД
            return true;
        }

        public bool DeleteApplicant(int id)
        {
            // Реализация удаления абитуриента из БД
            return true;
        }

        public string GetDeleteResultMessage(int id, bool success)
        {
            return success ? "Абитуриент успешно удалён" : "Абитуриент с указанным ID не найден";
        }
    }

  
}
