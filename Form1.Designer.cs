﻿namespace PCS_WinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpboxMeta = new System.Windows.Forms.GroupBox();
            this.btnBrowseMeta = new System.Windows.Forms.Button();
            this.txtCustomMeta = new System.Windows.Forms.TextBox();
            this.rdCustomBtn = new System.Windows.Forms.RadioButton();
            this.rdDefaultBtn = new System.Windows.Forms.RadioButton();
            this.grpboxMount = new System.Windows.Forms.GroupBox();
            this.btnMount = new System.Windows.Forms.Button();
            this.txtMountPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpboxUpdate = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpboxFixDate = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnFixDate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDateBrowse = new System.Windows.Forms.Button();
            this.txtDateCustom = new System.Windows.Forms.TextBox();
            this.rdCustomDate = new System.Windows.Forms.RadioButton();
            this.rdDateDefault = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.chkBoxCreateDate = new System.Windows.Forms.CheckBox();
            this.grpboxMeta.SuspendLayout();
            this.grpboxMount.SuspendLayout();
            this.grpboxUpdate.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpboxFixDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxMeta
            // 
            this.grpboxMeta.Controls.Add(this.btnBrowseMeta);
            this.grpboxMeta.Controls.Add(this.txtCustomMeta);
            this.grpboxMeta.Controls.Add(this.rdCustomBtn);
            this.grpboxMeta.Controls.Add(this.rdDefaultBtn);
            this.grpboxMeta.Location = new System.Drawing.Point(7, 6);
            this.grpboxMeta.Name = "grpboxMeta";
            this.grpboxMeta.Size = new System.Drawing.Size(460, 103);
            this.grpboxMeta.TabIndex = 1;
            this.grpboxMeta.TabStop = false;
            this.grpboxMeta.Text = "1. Select the Metadata Location";
            // 
            // btnBrowseMeta
            // 
            this.btnBrowseMeta.Enabled = false;
            this.btnBrowseMeta.Location = new System.Drawing.Point(369, 61);
            this.btnBrowseMeta.Name = "btnBrowseMeta";
            this.btnBrowseMeta.Size = new System.Drawing.Size(85, 30);
            this.btnBrowseMeta.TabIndex = 3;
            this.btnBrowseMeta.Text = "Browse";
            this.btnBrowseMeta.UseVisualStyleBackColor = true;
            this.btnBrowseMeta.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtCustomMeta
            // 
            this.txtCustomMeta.Enabled = false;
            this.txtCustomMeta.Location = new System.Drawing.Point(6, 67);
            this.txtCustomMeta.Name = "txtCustomMeta";
            this.txtCustomMeta.ReadOnly = true;
            this.txtCustomMeta.Size = new System.Drawing.Size(357, 20);
            this.txtCustomMeta.TabIndex = 2;
            this.txtCustomMeta.Text = "Click the Browse button.";
            this.txtCustomMeta.TextChanged += new System.EventHandler(this.TxtCustomMeta_TextChanged);
            // 
            // rdCustomBtn
            // 
            this.rdCustomBtn.AutoSize = true;
            this.rdCustomBtn.Location = new System.Drawing.Point(7, 44);
            this.rdCustomBtn.Name = "rdCustomBtn";
            this.rdCustomBtn.Size = new System.Drawing.Size(85, 17);
            this.rdCustomBtn.TabIndex = 1;
            this.rdCustomBtn.Text = "Custom Path";
            this.rdCustomBtn.UseVisualStyleBackColor = true;
            this.rdCustomBtn.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // rdDefaultBtn
            // 
            this.rdDefaultBtn.AutoSize = true;
            this.rdDefaultBtn.Location = new System.Drawing.Point(7, 20);
            this.rdDefaultBtn.Name = "rdDefaultBtn";
            this.rdDefaultBtn.Size = new System.Drawing.Size(59, 17);
            this.rdDefaultBtn.TabIndex = 0;
            this.rdDefaultBtn.Text = "Default";
            this.rdDefaultBtn.UseVisualStyleBackColor = true;
            this.rdDefaultBtn.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // grpboxMount
            // 
            this.grpboxMount.Controls.Add(this.btnMount);
            this.grpboxMount.Controls.Add(this.txtMountPath);
            this.grpboxMount.Enabled = false;
            this.grpboxMount.Location = new System.Drawing.Point(6, 118);
            this.grpboxMount.Name = "grpboxMount";
            this.grpboxMount.Size = new System.Drawing.Size(461, 63);
            this.grpboxMount.TabIndex = 1;
            this.grpboxMount.TabStop = false;
            this.grpboxMount.Text = "2. Select the Mount Path";
            // 
            // btnMount
            // 
            this.btnMount.Location = new System.Drawing.Point(370, 19);
            this.btnMount.Name = "btnMount";
            this.btnMount.Size = new System.Drawing.Size(85, 30);
            this.btnMount.TabIndex = 4;
            this.btnMount.Text = "Browse";
            this.btnMount.UseVisualStyleBackColor = true;
            this.btnMount.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtMountPath
            // 
            this.txtMountPath.Location = new System.Drawing.Point(6, 25);
            this.txtMountPath.Name = "txtMountPath";
            this.txtMountPath.ReadOnly = true;
            this.txtMountPath.Size = new System.Drawing.Size(358, 20);
            this.txtMountPath.TabIndex = 0;
            this.txtMountPath.Text = "Click the Browse button.";
            this.txtMountPath.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(370, 19);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(85, 30);
            this.btnUpdateDB.TabIndex = 2;
            this.btnUpdateDB.Text = "Click Here";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.BtnUpdateDB_Click);
            // 
            // grpboxUpdate
            // 
            this.grpboxUpdate.Controls.Add(this.progressBar1);
            this.grpboxUpdate.Controls.Add(this.btnUpdateDB);
            this.grpboxUpdate.Enabled = false;
            this.grpboxUpdate.Location = new System.Drawing.Point(6, 187);
            this.grpboxUpdate.Name = "grpboxUpdate";
            this.grpboxUpdate.Size = new System.Drawing.Size(461, 61);
            this.grpboxUpdate.TabIndex = 3;
            this.grpboxUpdate.TabStop = false;
            this.grpboxUpdate.Text = "3. Update the Database";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(357, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 280);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpboxMeta);
            this.tabPage1.Controls.Add(this.grpboxUpdate);
            this.tabPage1.Controls.Add(this.grpboxMount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Metadata Update";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpboxFixDate);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Date Fix";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpboxFixDate
            // 
            this.grpboxFixDate.Controls.Add(this.chkBoxCreateDate);
            this.grpboxFixDate.Controls.Add(this.progressBar2);
            this.grpboxFixDate.Controls.Add(this.btnFixDate);
            this.grpboxFixDate.Location = new System.Drawing.Point(7, 116);
            this.grpboxFixDate.Name = "grpboxFixDate";
            this.grpboxFixDate.Size = new System.Drawing.Size(460, 132);
            this.grpboxFixDate.TabIndex = 5;
            this.grpboxFixDate.TabStop = false;
            this.grpboxFixDate.Text = "2. Fix the Date";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 72);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(357, 23);
            this.progressBar2.TabIndex = 5;
            // 
            // btnFixDate
            // 
            this.btnFixDate.Enabled = false;
            this.btnFixDate.Location = new System.Drawing.Point(369, 69);
            this.btnFixDate.Name = "btnFixDate";
            this.btnFixDate.Size = new System.Drawing.Size(85, 30);
            this.btnFixDate.TabIndex = 4;
            this.btnFixDate.Text = "Click Here";
            this.btnFixDate.UseVisualStyleBackColor = true;
            this.btnFixDate.Click += new System.EventHandler(this.btnFixDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDateBrowse);
            this.groupBox1.Controls.Add(this.txtDateCustom);
            this.groupBox1.Controls.Add(this.rdCustomDate);
            this.groupBox1.Controls.Add(this.rdDateDefault);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select the Metadata Location";
            // 
            // btnDateBrowse
            // 
            this.btnDateBrowse.Enabled = false;
            this.btnDateBrowse.Location = new System.Drawing.Point(369, 61);
            this.btnDateBrowse.Name = "btnDateBrowse";
            this.btnDateBrowse.Size = new System.Drawing.Size(85, 30);
            this.btnDateBrowse.TabIndex = 3;
            this.btnDateBrowse.Text = "Browse";
            this.btnDateBrowse.UseVisualStyleBackColor = true;
            this.btnDateBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDateCustom
            // 
            this.txtDateCustom.Enabled = false;
            this.txtDateCustom.Location = new System.Drawing.Point(6, 67);
            this.txtDateCustom.Name = "txtDateCustom";
            this.txtDateCustom.ReadOnly = true;
            this.txtDateCustom.Size = new System.Drawing.Size(357, 20);
            this.txtDateCustom.TabIndex = 2;
            this.txtDateCustom.Text = "Click the Browse button.";
            this.txtDateCustom.TextChanged += new System.EventHandler(this.txtDateCustom_TextChanged);
            // 
            // rdCustomDate
            // 
            this.rdCustomDate.AutoSize = true;
            this.rdCustomDate.Location = new System.Drawing.Point(7, 44);
            this.rdCustomDate.Name = "rdCustomDate";
            this.rdCustomDate.Size = new System.Drawing.Size(85, 17);
            this.rdCustomDate.TabIndex = 1;
            this.rdCustomDate.Text = "Custom Path";
            this.rdCustomDate.UseVisualStyleBackColor = true;
            this.rdCustomDate.CheckedChanged += new System.EventHandler(this.rdCustomDate_CheckedChanged);
            // 
            // rdDateDefault
            // 
            this.rdDateDefault.AutoSize = true;
            this.rdDateDefault.Location = new System.Drawing.Point(7, 20);
            this.rdDateDefault.Name = "rdDateDefault";
            this.rdDateDefault.Size = new System.Drawing.Size(59, 17);
            this.rdDateDefault.TabIndex = 0;
            this.rdDateDefault.Text = "Default";
            this.rdDateDefault.UseVisualStyleBackColor = true;
            this.rdDateDefault.CheckedChanged += new System.EventHandler(this.rdDateDefault_CheckedChanged);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // chkBoxCreateDate
            // 
            this.chkBoxCreateDate.AutoSize = true;
            this.chkBoxCreateDate.Location = new System.Drawing.Point(7, 35);
            this.chkBoxCreateDate.Name = "chkBoxCreateDate";
            this.chkBoxCreateDate.Size = new System.Drawing.Size(236, 17);
            this.chkBoxCreateDate.TabIndex = 6;
            this.chkBoxCreateDate.Text = "(Optional) Change the \'Created At\' timestamp";
            this.chkBoxCreateDate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 307);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCS DB Update Utility";
            this.grpboxMeta.ResumeLayout(false);
            this.grpboxMeta.PerformLayout();
            this.grpboxMount.ResumeLayout(false);
            this.grpboxMount.PerformLayout();
            this.grpboxUpdate.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpboxFixDate.ResumeLayout(false);
            this.grpboxFixDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxMeta;
        private System.Windows.Forms.RadioButton rdDefaultBtn;
        private System.Windows.Forms.TextBox txtCustomMeta;
        private System.Windows.Forms.RadioButton rdCustomBtn;
        private System.Windows.Forms.GroupBox grpboxMount;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtMountPath;
        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.Button btnBrowseMeta;
        private System.Windows.Forms.Button btnMount;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.GroupBox grpboxUpdate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDateBrowse;
        private System.Windows.Forms.TextBox txtDateCustom;
        private System.Windows.Forms.RadioButton rdCustomDate;
        private System.Windows.Forms.RadioButton rdDateDefault;
        private System.Windows.Forms.GroupBox grpboxFixDate;
        private System.Windows.Forms.Button btnFixDate;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckBox chkBoxCreateDate;
    }
}

