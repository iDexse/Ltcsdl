using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoNewsPaper
{
    public partial class AddFeedForm : Form
    {
        public readonly NewsFeedManager _newsManager;

        public bool HasChanges { get; set; }
        public AddFeedForm NewsManager { get; set; }

        public AddFeedForm(NewsFeedManager newsManager)
        {
            _newsManager = newsManager;
            InitializeComponent();
        }

        public AddFeedForm(AddFeedForm newsManager)
        {
            NewsManager = newsManager;
        }

        private void AddFeedForm_Load(object sender, EventArgs e)
        {
            var publishers = _newsManager.GetNewsFeed();
            foreach (var publisher in publishers)
            {
                cbbToaSoan.Items.Add(publisher.Name);
            }
        }

        internal List<Models.Publisher> GetNewsFeed()
        {
            throw new NotImplementedException();
        }

        private void ClearForm()
        {
            cbbToaSoan.Text = "";
            txtTenChuyenMuc.Text = "";
            txtRSSLink.Text = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var publisherName = cbbToaSoan.Text;
            var categoryName = txtTenChuyenMuc.Text;
            var rssLink = txtRSSLink.Text;
            if (string.IsNullOrWhiteSpace(publisherName) ||
                string.IsNullOrWhiteSpace(categoryName) ||
                string.IsNullOrWhiteSpace(rssLink))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Lỗi");
                return;
            }
            HasChanges = true;
            var success = _newsManager.AddCategory(publisherName, categoryName, rssLink, false);
            if (success)
            {
                ClearForm();
                return;
            }
            if (MessageBox.Show("Chuyên mục này đã tồn tại, bạn có muốn cập nhật RSS Link không?",
                "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _newsManager.AddCategory(publisherName, categoryName, rssLink, true);
            }
            ClearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRSSLink_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
