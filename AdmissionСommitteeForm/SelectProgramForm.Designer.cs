using System.Drawing;
using System;
using System.Windows.Forms;

namespace AdmissionСommitteeForm
{
    partial class SelectProgramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbPrograms;
        private ComboBox cmbEducationForm;
        private ComboBox cmbFundingSource;
        private CheckBox chkOriginalProvided;
        private Label lblProgram;
        private Label lblEducationForm;
        private Label lblFundingSource;

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
            this.cmbPrograms = new ComboBox();
            this.cmbEducationForm = new ComboBox();
            this.cmbFundingSource = new ComboBox();
            this.chkOriginalProvided = new CheckBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.lblProgram = new Label();
            this.lblEducationForm = new Label();
            this.lblFundingSource = new Label();

            SuspendLayout();

            // lblProgram
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new Point(20, 20);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new Size(88, 13);
            this.lblProgram.Text = "Специальность:";

            // cmbPrograms
            this.cmbPrograms.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPrograms.FormattingEnabled = true;
            this.cmbPrograms.Location = new Point(120, 17);
            this.cmbPrograms.Name = "cmbPrograms";
            this.cmbPrograms.Size = new Size(250, 21);
            this.cmbPrograms.TabIndex = 0;

            // lblEducationForm
            this.lblEducationForm.AutoSize = true;
            this.lblEducationForm.Location = new Point(20, 50);
            this.lblEducationForm.Name = "lblEducationForm";
            this.lblEducationForm.Size = new Size(94, 13);
            this.lblEducationForm.Text = "Форма обучения:";

            // cmbEducationForm
            this.cmbEducationForm.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEducationForm.FormattingEnabled = true;
            this.cmbEducationForm.Items.AddRange(new object[] { "очная", "заочная", "очно-заочная" });
            this.cmbEducationForm.Location = new Point(120, 47);
            this.cmbEducationForm.Name = "cmbEducationForm";
            this.cmbEducationForm.Size = new Size(150, 21);
            this.cmbEducationForm.TabIndex = 1;

            // lblFundingSource
            this.lblFundingSource.AutoSize = true;
            this.lblFundingSource.Location = new Point(20, 80);
            this.lblFundingSource.Name = "lblFundingSource";
            this.lblFundingSource.Size = new Size(97, 13);
            this.lblFundingSource.Text = "Основа обучения:";

            // cmbFundingSource
            this.cmbFundingSource.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFundingSource.FormattingEnabled = true;
            this.cmbFundingSource.Items.AddRange(new object[] { "бюджет", "договор" });
            this.cmbFundingSource.Location = new Point(120, 77);
            this.cmbFundingSource.Name = "cmbFundingSource";
            this.cmbFundingSource.Size = new Size(150, 21);
            this.cmbFundingSource.TabIndex = 2;

            // chkOriginalProvided
            this.chkOriginalProvided.AutoSize = true;
            this.chkOriginalProvided.Location = new Point(120, 107);
            this.chkOriginalProvided.Name = "chkOriginalProvided";
            this.chkOriginalProvided.Size = new Size(176, 17);
            this.chkOriginalProvided.TabIndex = 3;
            this.chkOriginalProvided.Text = "Оригинал документа предоставлен";
            this.chkOriginalProvided.UseVisualStyleBackColor = true;

            // btnSave
            this.btnSave.Location = new Point(120, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new Point(230, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // SelectProgramForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 190);
            this.Controls.AddRange(new Control[] {
            lblProgram, cmbPrograms,
            lblEducationForm, cmbEducationForm,
            lblFundingSource, cmbFundingSource,
            chkOriginalProvided,
            btnSave, btnCancel
        });
            this.Name = "SelectProgramForm";
            this.Text = "Выбор специальности";
            this.StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}