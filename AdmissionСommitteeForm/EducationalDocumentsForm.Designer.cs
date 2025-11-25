using System.Drawing;
using System;
using System.Windows.Forms;

namespace AdmissionСommitteeForm
{
    partial class EducationalDocumentsForm
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbDocumentType;
        private TextBox txtDocumentSeries;
        private TextBox txtDocumentNumber;
        private NumericUpDown nudYearOfGraduation;
        private NumericUpDown nudGPA;
        private Label lblDocumentType;
        private Label lblDocumentSeries;
        private Label lblDocumentNumber;
        private Label lblYearOfGraduation;
        private Label lblGPA;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDocumentType = new ComboBox();
            this.txtDocumentSeries = new TextBox();
            this.txtDocumentNumber = new TextBox();
            this.nudYearOfGraduation = new NumericUpDown();
            this.nudGPA = new NumericUpDown();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.lblDocumentType = new Label();
            this.lblDocumentSeries = new Label();
            this.lblDocumentNumber = new Label();
            this.lblYearOfGraduation = new Label();
            this.lblGPA = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudYearOfGraduation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGPA)).BeginInit();
            SuspendLayout();

            // lblDocumentType
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new Point(20, 20);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new Size(83, 13);
            this.lblDocumentType.Text = "Тип документа:";

            // cmbDocumentType
            this.cmbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Items.AddRange(new object[] { "аттестат", "диплом", "справка" });
            this.cmbDocumentType.Location = new Point(120, 17);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new Size(150, 21);
            this.cmbDocumentType.TabIndex = 0;

            // lblDocumentSeries
            this.lblDocumentSeries.AutoSize = true;
            this.lblDocumentSeries.Location = new Point(20, 50);
            this.lblDocumentSeries.Name = "lblDocumentSeries";
            this.lblDocumentSeries.Size = new Size(48, 13);
            this.lblDocumentSeries.Text = "Серия:";

            // txtDocumentSeries
            this.txtDocumentSeries.Location = new Point(120, 47);
            this.txtDocumentSeries.Name = "txtDocumentSeries";
            this.txtDocumentSeries.Size = new Size(80, 20);
            this.txtDocumentSeries.TabIndex = 1;
            this.txtDocumentSeries.MaxLength = 6;

            // lblDocumentNumber
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new Point(210, 50);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new Size(44, 13);
            this.lblDocumentNumber.Text = "Номер:";

            // txtDocumentNumber
            this.txtDocumentNumber.Location = new Point(260, 47);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new Size(100, 20);
            this.txtDocumentNumber.TabIndex = 2;
            this.txtDocumentNumber.MaxLength = 7;

            // lblYearOfGraduation
            this.lblYearOfGraduation.AutoSize = true;
            this.lblYearOfGraduation.Location = new Point(20, 80);
            this.lblYearOfGraduation.Name = "lblYearOfGraduation";
            this.lblYearOfGraduation.Size = new Size(73, 13);
            this.lblYearOfGraduation.Text = "Год окончания:";

            // nudYearOfGraduation
            this.nudYearOfGraduation.Location = new Point(120, 78);
            this.nudYearOfGraduation.Minimum = 1950;
            this.nudYearOfGraduation.Maximum = 2024;
            this.nudYearOfGraduation.Value = 2023;
            this.nudYearOfGraduation.Name = "nudYearOfGraduation";
            this.nudYearOfGraduation.Size = new Size(80, 20);
            this.nudYearOfGraduation.TabIndex = 3;

            // lblGPA
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new Point(20, 110);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new Size(68, 13);
            this.lblGPA.Text = "Средний балл:";

            // nudGPA
            this.nudGPA.Location = new Point(120, 108);
            this.nudGPA.Minimum = 2;
            this.nudGPA.Maximum = 5;
            this.nudGPA.DecimalPlaces = 2;
            this.nudGPA.Increment = 0.1m;
            this.nudGPA.Value = 4.0m;
            this.nudGPA.Name = "nudGPA";
            this.nudGPA.Size = new Size(80, 20);
            this.nudGPA.TabIndex = 4;

            // btnSave
            this.btnSave.Location = new Point(120, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(100, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new Point(230, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // EducationalDocumentsForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 200);
            this.Controls.AddRange(new Control[] {
            lblDocumentType, cmbDocumentType,
            lblDocumentSeries, txtDocumentSeries,
            lblDocumentNumber, txtDocumentNumber,
            lblYearOfGraduation, nudYearOfGraduation,
            lblGPA, nudGPA,
            btnSave, btnCancel
        });
            this.Name = "EducationalDocumentsForm";
            this.Text = "Документы об образовании";
            this.StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.nudYearOfGraduation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGPA)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}