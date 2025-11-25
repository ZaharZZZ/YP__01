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
        private bool _documentsFilled = false;
        private bool _programSelected = false;

        public string DocumentType { get; private set; } = string.Empty;
        public string DocumentSeries { get; private set; } = string.Empty;
        public string DocumentNumber { get; private set; } = string.Empty;
        public int YearOfGraduation { get; private set; }
        public decimal GPA { get; private set; }
        public int ProgramId { get; private set; }
        public string ProgramName { get; private set; } = string.Empty;
        public string EducationForm { get; private set; } = string.Empty;
        public string FundingSource { get; private set; } = string.Empty;
        public bool OriginalProvided { get; private set; }
    

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
                // Сохраняем абитуриента
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

                string result = _applicantManager.AddApplicantWithDocuments(applicant,
                    DocumentType, DocumentSeries, DocumentNumber, YearOfGraduation, GPA,
                    ProgramId, EducationForm, FundingSource, OriginalProvided);

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
            // Проверка основных данных абитуриента
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

            // Проверка документов об образовании
            if (!_documentsFilled)
            {
                MessageBox.Show("Заполните документы об образовании", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAddDocuments.Focus();
                return false;
            }

            // Проверка выбора специальности
            if (!_programSelected)
            {
                MessageBox.Show("Выберите специальность", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectProgram.Focus();
                return false;
            }

            return true;
        }

        private void btnSelectProgram_Click(object sender, EventArgs e)
        {
            using (var programForm = new SelectProgramForm())
            {
                if (programForm.ShowDialog() == DialogResult.OK)
                {
                    ProgramId = programForm.SelectedProgramId;
                    ProgramName = programForm.SelectedProgramName;
                    EducationForm = programForm.EducationForm;
                    FundingSource = programForm.FundingSource;
                    OriginalProvided = programForm.OriginalProvided;

                    _programSelected = true;
                    lblProgramStatus.Text = ProgramName;
                    lblProgramStatus.ForeColor = Color.Green;
                }
            }

        }

        private void btnAddDocuments_Click(object sender, EventArgs e)
        {
            using (var documentsForm = new EducationalDocumentsForm())
            {
                if (documentsForm.ShowDialog() == DialogResult.OK)
                {
                    DocumentType = documentsForm.DocumentType;
                    DocumentSeries = documentsForm.DocumentSeries;
                    DocumentNumber = documentsForm.DocumentNumber;
                    YearOfGraduation = documentsForm.YearOfGraduation;
                    GPA = documentsForm.GPA;

                    _documentsFilled = true;
                    lblDocumentsStatus.Text = "Заполнено";
                    lblDocumentsStatus.ForeColor = Color.Green;
                    btnSelectProgram.Enabled = true;
                }
            }
        }
    }
}
