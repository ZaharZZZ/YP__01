namespace AdmissionСommitteeForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewApplicants = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.applicantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();

            // dataGridViewApplicants
            this.dataGridViewApplicants.AllowUserToAddRows = false;
            this.dataGridViewApplicants.AllowUserToDeleteRows = false;
            this.dataGridViewApplicants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplicants.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewApplicants.Name = "dataGridViewApplicants";
            this.dataGridViewApplicants.ReadOnly = true;
            this.dataGridViewApplicants.RowHeadersVisible = false;
            this.dataGridViewApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApplicants.Size = new System.Drawing.Size(776, 368);
            this.dataGridViewApplicants.TabIndex = 0;

            // btnLoadData
            this.btnLoadData.Location = new System.Drawing.Point(12, 41);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(120, 23);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Загрузить данные";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(138, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // menuStrip1
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.applicantsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip1";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";

            // applicantsToolStripMenuItem
            this.applicantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.addApplicantToolStripMenuItem,
        this.deleteApplicantToolStripMenuItem});
            this.applicantsToolStripMenuItem.Name = "applicantsToolStripMenuItem";
            this.applicantsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.applicantsToolStripMenuItem.Text = "Абитуриенты";

            // addApplicantToolStripMenuItem
            this.addApplicantToolStripMenuItem.Name = "addApplicantToolStripMenuItem";
            this.addApplicantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addApplicantToolStripMenuItem.Text = "Добавить";
            this.addApplicantToolStripMenuItem.Click += new System.EventHandler(this.addApplicantToolStripMenuItem_Click);

            // deleteApplicantToolStripMenuItem
            this.deleteApplicantToolStripMenuItem.Name = "deleteApplicantToolStripMenuItem";
            this.deleteApplicantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteApplicantToolStripMenuItem.Text = "Удалить";
            this.deleteApplicantToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicantToolStripMenuItem_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dataGridViewApplicants);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Приёмная комиссия - Рейтинги абитуриентов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewApplicants;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem applicantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addApplicantContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicantContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem refreshContextToolStripMenuItem;
    }
}

