using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AdmissionСommitteeForm
{
    public partial class EducationalDocumentsForm : Form
    {
        public string DocumentType { get; private set; } = string.Empty;
        public string DocumentSeries { get; private set; } = string.Empty;
        public string DocumentNumber { get; private set; } = string.Empty;
        public int YearOfGraduation { get; private set; }
        public decimal GPA { get; private set; }
        public EducationalDocumentsForm()
        {
            InitializeComponent();
            cmbDocumentType.SelectedIndex = 0; // Выбираем первый элемент
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            DocumentType = cmbDocumentType.SelectedItem.ToString();
            DocumentSeries = txtDocumentSeries.Text.Trim();
            DocumentNumber = txtDocumentNumber.Text.Trim();
            YearOfGraduation = (int)nudYearOfGraduation.Value;
            GPA = nudGPA.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateForm()
        {
            if (cmbDocumentType.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип документа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDocumentType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumentSeries.Text))
            {
                MessageBox.Show("Введите серию документа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumentSeries.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumentNumber.Text))
            {
                MessageBox.Show("Введите номер документа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumentNumber.Focus();
                return false;
            }

            return true;
        }
    }
}
