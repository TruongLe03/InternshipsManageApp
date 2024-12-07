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
using System.Drawing.Drawing2D;



namespace InternshipsManageApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            closebtn.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatAppearance.BorderSize = 0;
        }

       
        private void FormLogin_Paint(object sender, EventArgs e)
        {
            txtPassword.Text = "123456";
            txtUsername.Text = "admin";
            SetEmailPlaceholder();
            SetPasswordPlaceholder();
        }
        private void FormLogin_Paint(object sender, PaintEventArgs e)
        {
            SetBackgroundGradient(sender, e);
        }

        //Tạo backgroundgradient cho formlogin
        private void SetBackgroundGradient(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(112, 40, 228), Color.FromArgb(229, 178, 202), 65f);

                     
            graphics.FillRectangle(b, gradient_rectangle);
        }

        //Tạo BoderRadius
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            int radius = 30;  
           
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);  
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);  
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);  
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);  
            path.CloseFigure();  
            this.Region = new Region(path);
        }

        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); 
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
        private void txtUsername_Click(object sender, EventArgs e)
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

        private void txtPassword_Click(object sender, EventArgs e)
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
                var res = await client.PostAsync("http://nqbdev-30704.portmap.host:30704/api/auth/login", content);
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


       

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closebtn_MouseHover(object sender, EventArgs e)
        {
            closebtn.ForeColor = Color.Red;
            closebtn.BackColor = Color.Transparent;
        }

        private void closebtn_MouseLeave(object sender, EventArgs e)
        {
            closebtn.ForeColor = Color.White;
        }

    }
}
