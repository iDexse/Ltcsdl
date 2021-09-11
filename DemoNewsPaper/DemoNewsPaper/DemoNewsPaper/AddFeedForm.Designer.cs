
namespace DemoNewsPaper
{
    partial class AddFeedForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbToaSoan = new System.Windows.Forms.ComboBox();
            this.txtTenChuyenMuc = new System.Windows.Forms.TextBox();
            this.txtRSSLink = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tòa soạn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên chuyên Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "RSS Link";
            // 
            // cbbToaSoan
            // 
            this.cbbToaSoan.FormattingEnabled = true;
            this.cbbToaSoan.Location = new System.Drawing.Point(135, 26);
            this.cbbToaSoan.Name = "cbbToaSoan";
            this.cbbToaSoan.Size = new System.Drawing.Size(164, 21);
            this.cbbToaSoan.TabIndex = 1;
            // 
            // txtTenChuyenMuc
            // 
            this.txtTenChuyenMuc.Location = new System.Drawing.Point(135, 60);
            this.txtTenChuyenMuc.Name = "txtTenChuyenMuc";
            this.txtTenChuyenMuc.Size = new System.Drawing.Size(164, 20);
            this.txtTenChuyenMuc.TabIndex = 2;
            // 
            // txtRSSLink
            // 
            this.txtRSSLink.Location = new System.Drawing.Point(135, 92);
            this.txtRSSLink.Name = "txtRSSLink";
            this.txtRSSLink.Size = new System.Drawing.Size(280, 20);
            this.txtRSSLink.TabIndex = 2;
            this.txtRSSLink.TextChanged += new System.EventHandler(this.txtRSSLink_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(258, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 147);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRSSLink);
            this.Controls.Add(this.txtTenChuyenMuc);
            this.Controls.Add(this.cbbToaSoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFeedForm";
            this.Text = "AddFeedForm";
            this.Load += new System.EventHandler(this.AddFeedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbToaSoan;
        private System.Windows.Forms.TextBox txtTenChuyenMuc;
        private System.Windows.Forms.TextBox txtRSSLink;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}