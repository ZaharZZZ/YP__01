using AdmissionСommitteeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionСommitteeForm
{
    public partial class SelectProgramForm : Form
    {
        public int SelectedProgramId { get; private set; }
        public string SelectedProgramName { get; private set; } = string.Empty;
        public string EducationForm { get; private set; } = string.Empty;
        public string FundingSource { get; private set; } = string.Empty;
        public bool OriginalProvided { get; private set; }
        public SelectProgramForm()
        {
            InitializeComponent();
            LoadPrograms();
            cmbEducationForm.SelectedIndex = 0;
            cmbFundingSource.SelectedIndex = 0;
        }

        private void LoadPrograms()
        {
            try
            {
                var programs = GetStudyPrograms();
                cmbPrograms.DataSource = programs;
                cmbPrograms.DisplayMember = "Value";
                cmbPrograms.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке специальностей: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<KeyValuePair<int, string>> GetStudyPrograms()
        {
            var programs = new List<KeyValuePair<int, string>>();

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(AppSettings.ConnectionString))
            {
                conn.Open();
                string query = "SELECT id, program_name FROM study_programs";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        programs.Add(new KeyValuePair<int, string>(
                            reader.GetInt32("id"),
                            reader.GetString("program_name")
                        ));
                    }
                }
            }

            return programs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            SelectedProgramId = ((KeyValuePair<int, string>)cmbPrograms.SelectedItem).Key;
            SelectedProgramName = ((KeyValuePair<int, string>)cmbPrograms.SelectedItem).Value;
            EducationForm = cmbEducationForm.SelectedItem.ToString();
            FundingSource = cmbFundingSource.SelectedItem.ToString();
            OriginalProvided = chkOriginalProvided.Checked;

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
            if (cmbPrograms.SelectedItem == null)
            {
                MessageBox.Show("Выберите специальность", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPrograms.Focus();
                return false;
            }

            if (cmbEducationForm.SelectedItem == null)
            {
                MessageBox.Show("Выберите форму обучения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEducationForm.Focus();
                return false;
            }

            if (cmbFundingSource.SelectedItem == null)
            {
                MessageBox.Show("Выберите основу обучения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFundingSource.Focus();
                return false;
            }

            return true;
        }
    }
}
