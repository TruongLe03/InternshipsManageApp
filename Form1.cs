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
using System.Net.Http;
using Newtonsoft.Json;
using InternshipsManageApp.Forms;
using Newtonsoft.Json.Linq;


namespace InternshipsManageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
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

        private static readonly HttpClient client = new HttpClient();
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng payload để gửi đến API
            var email = txtUsername.Text;
            var password = txtPassword.Text;
            var login = new
            {
                email = email,
                password = password
            };
            var json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var res = await client.PostAsync("http://sso.nqbdev.software/api/auth/login", content);
              
                var responseString = await res.Content.ReadAsStringAsync();
                
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
                    string username = jsonResponse.data.username;
                    string userEmail = jsonResponse.data.email;
                    string role = jsonResponse.data.role;
                    string token = jsonResponse.token;
                   

                    // Lưu token vào Settings
                    Properties.Settings.Default.AuthToken = token;               
                    Properties.Settings.Default.Save();

                    // Cập nhật SessionManager
                    luutoken.Username = username;
                    luutoken.Role = role;

                    if (role == "admin")
                    {
                        FormDashboard formdashboard = new FormDashboard();
                        formdashboard.UserRole = role; // Gán giá trị UserRole
                        formdashboard.UpdateUserRole(); // Cập nhật Label lb2
                        formdashboard.Show();
                        this.Hide();
                    }
                    else if (role == "lecturer")
                    {
                        FormTeacher formteacher = new FormTeacher();
                        //formteacher.UserRole = role;
                        //formteacher.UpdateUserRole();
                        formteacher.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại: " + responseString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                Console.WriteLine("Chi tiết lỗi: " + ex.StackTrace);
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
