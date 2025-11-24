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
    public partial class MainForm : Form
    {
        private IApplicantManager _applicantManager;
        public MainForm()
        {
            InitializeComponent();
            _applicantManager = new SQLApplicantManager();
            LoadData();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var (isValid, errorMessage) = AppSettings.AreSettingsValidWithDetails();
                if (!isValid)
                {
                    MessageBox.Show($"Ошибка настроек: {errorMessage}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получаем данные через менеджер
                var rankings = _applicantManager.GetApplicantRankings();

                // Преобразуем в DataTable для отображения в DataGridView
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ФИО", typeof(string));
                dataTable.Columns.Add("Специальность", typeof(string));
                dataTable.Columns.Add("Балл", typeof(decimal));
                dataTable.Columns.Add("Позиция", typeof(int));
                dataTable.Columns.Add("Тип списка", typeof(string));

                foreach (var ranking in rankings)
                {
                    dataTable.Rows.Add(
                        ranking.FullName,
                        ranking.ProgramName,
                        ranking.TotalScore,
                        ranking.Position,
                        ranking.ListType
                    );
                }

                dataGridViewApplicants.DataSource = dataTable;
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ConfigureDataGridView()
        {
            if (dataGridViewApplicants.Columns.Count > 0)
            {
                dataGridViewApplicants.Columns["ФИО"].Width = 200;
                dataGridViewApplicants.Columns["Специальность"].Width = 250;
                dataGridViewApplicants.Columns["Балл"].Width = 80;
                dataGridViewApplicants.Columns["Позиция"].Width = 80;
                dataGridViewApplicants.Columns["Тип списка"].Width = 120;

                dataGridViewApplicants.Columns["Балл"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
                dataGridViewApplicants.Columns["Позиция"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;

                dataGridViewApplicants.Columns["Балл"].DefaultCellStyle.Format = "0.00";
            }

            foreach (DataGridViewColumn column in dataGridViewApplicants.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void addApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddApplicantForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Обновляем данные после добавления
                    MessageBox.Show("Абитуриент успешно добавлен", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplicants.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите абитуриента для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewApplicants.SelectedRows[0];
            string fullName = selectedRow.Cells["ФИО"].Value.ToString();
            string programName = selectedRow.Cells["Специальность"].Value.ToString();

            var result = MessageBox.Show(
                $"Вы уверены, что хотите удалить абитуриента:\n{fullName} ({programName})?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {

                    // Здесь нужно добавить метод удаления в ApplicantManager
                    // Показываем сообщение, что функционал в разработке
                    MessageBox.Show("Функционал удаления находится в разработке", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
