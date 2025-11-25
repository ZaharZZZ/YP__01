using System.Drawing;
using System;
using System.Windows.Forms;

namespace AdmissionСommitteeForm
{
    partial class AddApplicantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtFullName;
        private DateTimePicker dtpBirthDate;
        private TextBox txtPassportSeries;
        private TextBox txtPassportNumber;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtSNILS;
        private TextBox txtAddress;
        private Label lblFullName;
        private Label lblBirthDate;
        private Label lblPassportSeries;
        private Label lblPassportNumber;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblSNILS;
        private Label lblAddress;

        private Label lblDocumentsStatus;
        private Label lblProgramStatus;

        private Label lblStep1;
        private Label lblStep2;
        private Label lblStep3;


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
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblPassportSeries = new System.Windows.Forms.Label();
            this.txtPassportSeries = new System.Windows.Forms.TextBox();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSNILS = new System.Windows.Forms.Label();
            this.txtSNILS = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddDocuments = new System.Windows.Forms.Button();
            this.lblDocumentsStatus = new System.Windows.Forms.Label();
            this.btnSelectProgram = new System.Windows.Forms.Button();
            this.lblProgramStatus = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 50);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(37, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "ФИО:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(120, 47);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(20, 80);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(89, 13);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Дата рождения:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(120, 77);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(150, 20);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // lblPassportSeries
            // 
            this.lblPassportSeries.AutoSize = true;
            this.lblPassportSeries.Location = new System.Drawing.Point(20, 110);
            this.lblPassportSeries.Name = "lblPassportSeries";
            this.lblPassportSeries.Size = new System.Drawing.Size(91, 13);
            this.lblPassportSeries.TabIndex = 4;
            this.lblPassportSeries.Text = "Серия паспорта:";
            // 
            // txtPassportSeries
            // 
            this.txtPassportSeries.Location = new System.Drawing.Point(120, 107);
            this.txtPassportSeries.Name = "txtPassportSeries";
            this.txtPassportSeries.Size = new System.Drawing.Size(80, 20);
            this.txtPassportSeries.TabIndex = 3;
            this.txtPassportSeries.MaxLength = 6;
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Location = new System.Drawing.Point(210, 110);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(88, 13);
            this.lblPassportNumber.TabIndex = 6;
            this.lblPassportNumber.Text = "Номер паспорта:";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(310, 107);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPassportNumber.TabIndex = 4;
            this.txtPassportNumber.MaxLength = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 140);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Телефон:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 137);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblSNILS
            // 
            this.lblSNILS.AutoSize = true;
            this.lblSNILS.Location = new System.Drawing.Point(20, 200);
            this.lblSNILS.Name = "lblSNILS";
            this.lblSNILS.Size = new System.Drawing.Size(47, 13);
            this.lblSNILS.TabIndex = 12;
            this.lblSNILS.Text = "СНИЛС:";
            // 
            // txtSNILS
            // 
            this.txtSNILS.Location = new System.Drawing.Point(120, 197);
            this.txtSNILS.Name = "txtSNILS";
            this.txtSNILS.Size = new System.Drawing.Size(120, 20);
            this.txtSNILS.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 230);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Адрес:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 227);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 40);
            this.txtAddress.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddDocuments
            // 
            this.btnAddDocuments.Location = new System.Drawing.Point(120, 280);
            this.btnAddDocuments.Name = "btnAddDocuments";
            this.btnAddDocuments.Size = new System.Drawing.Size(180, 25);
            this.btnAddDocuments.TabIndex = 9;
            this.btnAddDocuments.Text = "Заполнить документы";
            this.btnAddDocuments.UseVisualStyleBackColor = true;
            this.btnAddDocuments.Click += new System.EventHandler(this.btnAddDocuments_Click);
            // 
            // lblDocumentsStatus
            // 
            this.lblDocumentsStatus.AutoSize = true;
            this.lblDocumentsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocumentsStatus.ForeColor = System.Drawing.Color.Red;
            this.lblDocumentsStatus.Location = new System.Drawing.Point(310, 285);
            this.lblDocumentsStatus.Name = "lblDocumentsStatus";
            this.lblDocumentsStatus.Size = new System.Drawing.Size(93, 13);
            this.lblDocumentsStatus.TabIndex = 18;
            this.lblDocumentsStatus.Text = "Не заполнено";
            // 
            // btnSelectProgram
            // 
            this.btnSelectProgram.Enabled = false;
            this.btnSelectProgram.Location = new System.Drawing.Point(120, 320);
            this.btnSelectProgram.Name = "btnSelectProgram";
            this.btnSelectProgram.Size = new System.Drawing.Size(180, 25);
            this.btnSelectProgram.TabIndex = 10;
            this.btnSelectProgram.Text = "Выбрать специальность";
            this.btnSelectProgram.UseVisualStyleBackColor = true;
            this.btnSelectProgram.Click += new System.EventHandler(this.btnSelectProgram_Click);
            // 
            // lblProgramStatus
            // 
            this.lblProgramStatus.AutoSize = true;
            this.lblProgramStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgramStatus.ForeColor = System.Drawing.Color.Red;
            this.lblProgramStatus.Location = new System.Drawing.Point(310, 325);
            this.lblProgramStatus.Name = "lblProgramStatus";
            this.lblProgramStatus.Size = new System.Drawing.Size(81, 13);
            this.lblProgramStatus.TabIndex = 20;
            this.lblProgramStatus.Text = "Не выбрано";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep1.Location = new System.Drawing.Point(20, 20);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(143, 13);
            this.lblStep1.TabIndex = 21;
            this.lblStep1.Text = "Шаг 1: Личные данные";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep2.Location = new System.Drawing.Point(20, 285);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(94, 13);
            this.lblStep2.TabIndex = 22;
            this.lblStep2.Text = "Шаг 2: Документы";
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep3.Location = new System.Drawing.Point(20, 325);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(95, 13);
            this.lblStep3.TabIndex = 23;
            this.lblStep3.Text = "Шаг 3: Выбор специальности";
            // 
            // AddApplicantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblProgramStatus);
            this.Controls.Add(this.btnSelectProgram);
            this.Controls.Add(this.lblDocumentsStatus);
            this.Controls.Add(this.btnAddDocuments);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtSNILS);
            this.Controls.Add(this.lblSNILS);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.lblPassportNumber);
            this.Controls.Add(this.txtPassportSeries);
            this.Controls.Add(this.lblPassportSeries);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddApplicantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление абитуриента";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Button btnSelectProgram;
        private Button btnAddDocuments;
    }
}