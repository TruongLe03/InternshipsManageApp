using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InternshipsManageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khởi tạo placeholder khi form được tải
        private void Form1_Load(object sender, EventArgs e)
        {
            SetEmailPlaceholder();
            SetPasswordPlaceholder();
        }

        // Hàm để đặt placeholder cho TextBox email
        private void SetEmailPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Enter the email...";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        // Hàm để đặt placeholder cho TextBox mật khẩu
        private void SetPasswordPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Enter the password...";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false; // Tắt password char để hiển thị placeholder
            }
        }

        // Sự kiện khi người dùng click vào TextBox email
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter the email...")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        // Sự kiện khi người dùng rời khỏi TextBox email
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                SetEmailPlaceholder();
            }
        }

        // Sự kiện khi người dùng click vào TextBox mật khẩu
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter the password...")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true; // Bật password char để che ký tự khi nhập
            }
        }

        // Sự kiện khi người dùng rời khỏi TextBox mật khẩu
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                SetPasswordPlaceholder();
            }
        }



        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FormDashboard formdashboard = new FormDashboard();

            // Hiển thị FormDashboard
            formdashboard.Show();

            // Ẩn FormLogin nếu không cần nữa
            this.Hide();

            // Đăng ký sự kiện FormClosed để đóng ứng dụng khi FormDashboard đóng lại
            formdashboard.FormClosed += (s, args) => this.Close();

        }

        private void closebtn_MouseHover(object sender, EventArgs e)
        {
            closebtn.BackColor = Color.Red;
            closebtn.ForeColor = Color.White;
        }

        private void closebtn_MouseLeave(object sender, EventArgs e)
        {
            closebtn.BackColor = Color.WhiteSmoke;
            closebtn.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
