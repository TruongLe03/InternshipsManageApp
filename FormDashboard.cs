using InternshipsManageApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Media3D;

namespace InternshipsManageApp
{
    public partial class FormDashboard : Form
    {
        public string UserRole { get; set; }
        private Button activeButton;
        private Form activeForm;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;


        public FormDashboard()
        {
            InitializeComponent();
            InitializeDefaultState();
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            if (!string.IsNullOrEmpty(UserRole))
            {
                lb2.Text = UserRole;
            }
        }


        public void UpdateUserRole()
        {
            if (!string.IsNullOrEmpty(UserRole))
            {
                lb2.Text = UserRole;
            }
        }

        // Phương thức khởi tạo mặc định
        private void InitializeDefaultState()
        {
            // Đặt nút "Home" là active mặc định
            activeButton = btnFormHome;
            SetActiveButtonStyle(activeButton);

            // Mở FormHome mặc định khi khởi động
            OpenChildForm(new FormHome(), btnFormHome);
        }

        // Sự kiện khi một nút điều hướng được nhấn
        private void Button_Click(object sender, EventArgs e)
        {
            
            if (activeButton != null)
            {
                ResetButtonStyle(activeButton);
            }

            activeButton = sender as Button;
            SetActiveButtonStyle(activeButton);

            if (activeButton == btnFormHome)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm = null;
                }
                lbSelected.Text = "Trang chủ";
                return;
            }
        }

        // Phương thức mở form con
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lbSelected.Text = childForm.Text;
        }

        // Thiết lập giao diện cho nút đang active
        private void SetActiveButtonStyle(Button button)
        {
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            button.ForeColor = Color.FromArgb(52, 152, 219);
        }

        // Đặt lại giao diện cho nút không còn active
        private void ResetButtonStyle(Button button)
        {
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White;
        }

        // SK nhấn logo
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
        // Sự kiện khi nút "Home" được nhấn
        private void btnFormHome_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            OpenChildForm(new FormHome(), sender);
        }

        // Sự kiện khi nút "Student" được nhấn
        private void btnFormStudent_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e); 
            OpenChildForm(new FormStudent(), sender);
        }

        // Sự kiện khi nút "Company" được nhấn
        private void btnFormCompany_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e); 
            OpenChildForm(new FormCompany(), sender);
        }

        // Sự kiện khi nút "Internship" được nhấn
        private void btnFormInternship_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e); 
            OpenChildForm(new FormInternship(), sender);
        }

        // Sự kiện khi nút "Evaluation" được nhấn
        private void btnFormDg_Kq_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e); 
            OpenChildForm(new FormResult_evaluation(), sender);
        }

        // Sự kiện khi nút "Teacher" được nhấn
        private void btnFormTeacher_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e); 
            OpenChildForm(new FormTeacher(), sender);
        }

        // Sự kiện khi đóng ứng dụng
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sự kiện phóng to cửa sổ
        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Sự kiện ẩn cửa sổ
        private void btnHidden_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
          

        }
    }
}

