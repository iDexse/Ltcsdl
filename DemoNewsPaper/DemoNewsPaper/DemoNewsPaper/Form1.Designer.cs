
namespace DemoNewsPaper
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tvwPublisher = new System.Windows.Forms.TreeView();
            this.pnlNews = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tòa soạn hoặc chuyên mục:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tvwPublisher
            // 
            this.tvwPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwPublisher.Location = new System.Drawing.Point(13, 45);
            this.tvwPublisher.Name = "tvwPublisher";
            this.tvwPublisher.Size = new System.Drawing.Size(175, 303);
            this.tvwPublisher.TabIndex = 2;
            this.tvwPublisher.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPublisher_AfterSelect);
            // 
            // pnlNews
            // 
            this.pnlNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNews.AutoScroll = true;
            this.pnlNews.BackgroundImage = global::DemoNewsPaper.Properties.Resources.hinh_nen_dep_cho_may_tinh_full_hd_2;
            this.pnlNews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNews.Location = new System.Drawing.Point(194, 45);
            this.pnlNews.Name = "pnlNews";
            this.pnlNews.Size = new System.Drawing.Size(499, 303);
            this.pnlNews.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 360);
            this.Controls.Add(this.pnlNews);
            this.Controls.Add(this.tvwPublisher);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản lý tin tức";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView tvwPublisher;
        private System.Windows.Forms.Panel pnlNews;
    }
}

