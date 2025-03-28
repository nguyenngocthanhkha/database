using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace kha_bai1
{
    public partial class bai_so_2 : Form
    {
        public bai_so_2()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các input
            string mssv = textBox1.Text;
            string hoTen = textBox2.Text;
            string nienKhoa = cboNienKhoa.Text;
            string lop = comboBox2.Text;

            // Lấy học kỳ
            string hocKy = "";
            if (rdoI.Checked) hocKy = "I";
            if (rdoII.Checked) hocKy = "II";
            if (rdoIII.Checked) hocKy = "III";

            // Lấy danh sách môn học được chọn
            string monHoc = string.Join(", ", MonHoc.Controls.OfType<CheckBox>()
                                         .Where(cb => cb.Checked)
                                         .Select(cb => cb.Text));

            // Kiểm tra nếu chưa chọn môn học
            if (string.IsNullOrEmpty(monHoc))
                monHoc = "Chưa chọn môn học";

            // Hiển thị thông tin
            string thongTin = $"MSSV: {mssv}\n" +
                              $"Họ và Tên: {hoTen}\n" +
                              $"Niên Khóa: {nienKhoa}\n" +
                              $"Lớp: {lop}\n" +
                              $"Học Kỳ: {hocKy}\n" +
                              $"Môn Học:\n{monHoc}";

            MessageBox.Show(thongTin, "Thông Tin Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các input
            txtMSSV.Clear();
            txtHoTen.Clear();
            cboNienKhoa.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;

            rbHK1.Checked = false;
            rbHK2.Checked = false;
            rbHK3.Checked = false;

            foreach (CheckBox cb in grpMonHoc.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Thoát chương trình
            Application.Exit();
        }
    }
}