using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionСommitteeLib
{
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
                return false;
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
