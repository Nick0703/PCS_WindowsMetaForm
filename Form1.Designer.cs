namespace PCS_WinForm
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
            this.grpboxMeta.SuspendLayout();
            this.grpboxMount.SuspendLayout();
            this.grpboxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxMeta
            // 
            this.grpboxMeta.Controls.Add(this.btnBrowseMeta);
            this.grpboxMeta.Controls.Add(this.txtCustomMeta);
            this.grpboxMeta.Controls.Add(this.rdCustomBtn);
            this.grpboxMeta.Controls.Add(this.rdDefaultBtn);
            this.grpboxMeta.Location = new System.Drawing.Point(13, 13);
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
            this.grpboxMount.Location = new System.Drawing.Point(12, 125);
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
            this.btnUpdateDB.Location = new System.Drawing.Point(191, 19);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(85, 30);
            this.btnUpdateDB.TabIndex = 2;
            this.btnUpdateDB.Text = "Click Here";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.BtnUpdateDB_Click);
            // 
            // grpboxUpdate
            // 
            this.grpboxUpdate.Controls.Add(this.btnUpdateDB);
            this.grpboxUpdate.Enabled = false;
            this.grpboxUpdate.Location = new System.Drawing.Point(12, 194);
            this.grpboxUpdate.Name = "grpboxUpdate";
            this.grpboxUpdate.Size = new System.Drawing.Size(461, 61);
            this.grpboxUpdate.TabIndex = 3;
            this.grpboxUpdate.TabStop = false;
            this.grpboxUpdate.Text = "3. Update the Database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 267);
            this.Controls.Add(this.grpboxUpdate);
            this.Controls.Add(this.grpboxMount);
            this.Controls.Add(this.grpboxMeta);
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
    }
}

