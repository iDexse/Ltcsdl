using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_VD2
{
    public partial class FrmSearch : Form
    {
        private QuanLyGiaoVien quanlyGiaoVien;
        public FrmSearch()
        {
            InitializeComponent();
        }
        public FrmSearch(QuanLyGiaoVien qlgv) : this()
        {
            quanlyGiaoVien = qlgv;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var kieuTim = KieuTim.TheoHoTen;
            if (rdMaGV.Checked)
            {
                kieuTim = KieuTim.TheoMa;
            }
            else if (rdName.Checked)
            {
                kieuTim = KieuTim.TheoHoTen;
            }
            else if (rdNumber.Checked)
            {
                kieuTim = KieuTim.TheoSDT;
            }

            var ketQua = quanlyGiaoVien.Tim(txtSearch.Text, kieuTim);

            if (ketQua is null)
            {
                MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var frmTBGiaoVien = new frmTBGiaoVien();
                frmTBGiaoVien.SetText(ketQua.ToString());
                frmTBGiaoVien.ShowDialog();
            }
        }

        private void rdMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
            {
                lblSearch.Text = rdMaGV.Text;
                txtSearch.Text = "";
            }
        }

        private void rdName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdName.Checked)
            {
                lblSearch.Text = rdName.Text;
                txtSearch.Text = "";
            }
        }

        private void rdNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNumber.Checked)
            {
                lblSearch.Text = rdNumber.Text;
                txtSearch.Text = "";
            }
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
