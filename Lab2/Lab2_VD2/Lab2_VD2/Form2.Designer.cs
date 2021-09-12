
namespace Lab2_VD2
{
    partial class FrmSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.rdNumber = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNumber);
            this.groupBox1.Controls.Add(this.rdName);
            this.groupBox1.Controls.Add(this.rdMaGV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Checked = true;
            this.rdMaGV.Location = new System.Drawing.Point(35, 39);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(58, 17);
            this.rdMaGV.TabIndex = 0;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            this.rdMaGV.CheckedChanged += new System.EventHandler(this.rdMaGV_CheckedChanged);
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Location = new System.Drawing.Point(144, 39);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(57, 17);
            this.rdName.TabIndex = 0;
            this.rdName.Text = "Họ tên";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // rdNumber
            // 
            this.rdNumber.AutoSize = true;
            this.rdNumber.Location = new System.Drawing.Point(263, 39);
            this.rdNumber.Name = "rdNumber";
            this.rdNumber.Size = new System.Drawing.Size(88, 17);
            this.rdNumber.TabIndex = 0;
            this.rdNumber.Text = "Số điện thoại";
            this.rdNumber.UseVisualStyleBackColor = true;
            this.rdNumber.CheckedChanged += new System.EventHandler(this.rdNumber_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(44, 117);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(37, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "MãGV";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(156, 117);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(369, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(43, 20);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 158);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSearch";
            this.Text = "Tìm thông tin giáo viên";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNumber;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOk;
    }
}