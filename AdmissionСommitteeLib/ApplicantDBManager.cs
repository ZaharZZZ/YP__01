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
    }
}
