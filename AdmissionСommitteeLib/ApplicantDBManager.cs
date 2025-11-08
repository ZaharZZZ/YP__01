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

    public class StorageApplicant
    {
        private readonly IApplicantDBManager _dbManager;

        public StorageApplicant(IApplicantDBManager dbManager)
        {
            _dbManager = dbManager;
        }

        public bool AddApplicant(Applicant applicant)
        {
            if (_dbManager.CheckApplicantExists(applicant.Id))
            {
                return false; // Абитуриент уже существует
            }

            return _dbManager.InsertApplicant(applicant);
        }

        public string DeleteApplicant(int applicantId, bool userConfirmation)
        {
            if (!userConfirmation)
            {
                return "Операция удаления отменена пользователем";
            }

            if (!_dbManager.CheckApplicantExists(applicantId))
            {
                return _dbManager.GetDeleteResultMessage(applicantId, false);
            }

            bool deleteSuccess = _dbManager.DeleteApplicant(applicantId);
            return _dbManager.GetDeleteResultMessage(applicantId, deleteSuccess);
        }
    }
}
