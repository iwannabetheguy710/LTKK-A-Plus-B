using System;
using System.Windows.Forms;

namespace LTKK_APB
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string data_textbox_a = txtbA.Text; // lấy dữ liệu từ Textbox A
            string data_textbox_b = txtbB.Text; // lấy dữ liệu từ Textbox B
            if (data_textbox_a.Length == 0 || data_textbox_b.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đủ cả 2 ô số nguyên A và B để có thể thực hiện phép tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = Int32.Parse(data_textbox_a); // ép kiểu dữ liệu lấy được từ Textbox A thành kiểu số nguyên
                int b = Int32.Parse(data_textbox_b); // ép kiểu dữ liệu lấy được từ Textbox B thành kiểu số nguyên
                int result = a + b; // dùng biến result lưu trữ kết quả phép tính
                MessageBox.Show("Kết quả của phép toán " + result.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
