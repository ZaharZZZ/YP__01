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
            this.txtFullName = new TextBox();
            this.dtpBirthDate = new DateTimePicker();
            this.txtPassportSeries = new TextBox();
            this.txtPassportNumber = new TextBox();
            this.txtPhone = new TextBox();
            this.txtEmail = new TextBox();
            this.txtSNILS = new TextBox();
            this.txtAddress = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.lblFullName = new Label();
            this.lblBirthDate = new Label();
            this.lblPassportSeries = new Label();
            this.lblPassportNumber = new Label();
            this.lblPhone = new Label();
            this.lblEmail = new Label();
            this.lblSNILS = new Label();
            this.lblAddress = new Label();

            SuspendLayout();

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new Point(12, 15);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new Size(37, 13);
            this.lblFullName.Text = "ФИО:";

            // txtFullName
            this.txtFullName.Location = new Point(120, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(250, 20);
            this.txtFullName.TabIndex = 0;

            // lblBirthDate
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new Point(12, 45);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new Size(89, 13);
            this.lblBirthDate.Text = "Дата рождения:";

            // dtpBirthDate
            this.dtpBirthDate.Location = new Point(120, 42);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new Size(150, 20);
            this.dtpBirthDate.TabIndex = 1;

            // lblPassportSeries
            this.lblPassportSeries.AutoSize = true;
            this.lblPassportSeries.Location = new Point(12, 75);
            this.lblPassportSeries.Name = "lblPassportSeries";
            this.lblPassportSeries.Size = new Size(92, 13);
            this.lblPassportSeries.Text = "Серия паспорта:";

            // txtPassportSeries
            this.txtPassportSeries.Location = new Point(120, 72);
            this.txtPassportSeries.Name = "txtPassportSeries";
            this.txtPassportSeries.Size = new Size(80, 20);
            this.txtPassportSeries.TabIndex = 2;

            // lblPassportNumber
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Location = new Point(12, 105);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new Size(89, 13);
            this.lblPassportNumber.Text = "Номер паспорта:";

            // txtPassportNumber
            this.txtPassportNumber.Location = new Point(120, 102);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new Size(100, 20);
            this.txtPassportNumber.TabIndex = 3;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new Point(12, 135);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(55, 13);
            this.lblPhone.Text = "Телефон:";

            // txtPhone
            this.txtPhone.Location = new Point(120, 132);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(150, 20);
            this.txtPhone.TabIndex = 4;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(12, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(35, 13);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new Point(120, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(200, 20);
            this.txtEmail.TabIndex = 5;

            // lblSNILS
            this.lblSNILS.AutoSize = true;
            this.lblSNILS.Location = new Point(12, 195);
            this.lblSNILS.Name = "lblSNILS";
            this.lblSNILS.Size = new Size(48, 13);
            this.lblSNILS.Text = "СНИЛС:";

            // txtSNILS
            this.txtSNILS.Location = new Point(120, 192);
            this.txtSNILS.Name = "txtSNILS";
            this.txtSNILS.Size = new Size(120, 20);
            this.txtSNILS.TabIndex = 6;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new Point(12, 225);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new Size(41, 13);
            this.lblAddress.Text = "Адрес:";

            // txtAddress
            this.txtAddress.Location = new Point(120, 222);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new Size(250, 60);
            this.txtAddress.TabIndex = 7;

            // btnSave
            this.btnSave.Location = new Point(120, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(100, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new Point(230, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // AddApplicantForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(384, 341);
            this.Controls.AddRange(new Control[] {
                lblFullName, txtFullName,
                lblBirthDate, dtpBirthDate,
                lblPassportSeries, txtPassportSeries,
                lblPassportNumber, txtPassportNumber,
                lblPhone, txtPhone,
                lblEmail, txtEmail,
                lblSNILS, txtSNILS,
                lblAddress, txtAddress,
                btnSave, btnCancel
            });
            this.Name = "AddApplicantForm";
            this.Text = "Добавить абитуриента";
            this.StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
    }
}