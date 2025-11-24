using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdmissionСommitteeLib;

namespace AdmissionСommitteeForm
{
    public partial class AddApplicantForm : Form
    {
        private IApplicantManager _applicantManager;
        public AddApplicantForm()
        {
            InitializeComponent();
            _applicantManager = new SQLApplicantManager();
            dtpBirthDate.MaxDate = DateTime.Today.AddYears(-14);
            dtpBirthDate.Value = DateTime.Today.AddYears(-18);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                var applicant = new Applicant
                {
                    FullName = txtFullName.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    PassportSeries = txtPassportSeries.Text.Trim(),
                    PassportNumber = txtPassportNumber.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    SNILS = txtSNILS.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                string result = _applicantManager.AddApplicant(applicant);

                if (result.Contains("успешно"))
                {
                    MessageBox.Show(result, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(result, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО абитуриента", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassportSeries.Text))
            {
                MessageBox.Show("Введите серию паспорта", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassportSeries.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassportNumber.Text))
            {
                MessageBox.Show("Введите номер паспорта", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassportNumber.Focus();
                return false;
            }

            return true;
        }
    }
}
