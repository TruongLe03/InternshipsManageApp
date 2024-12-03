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
    public partial class FormDashboard : BaseForm
    {
        public string UserRole { get; set; }
        private Button activeButton;
        private Form activeForm;

        
        private Size originalFormSize;

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
            originalFormSize = this.Size;
            SaveControlSizes(this);
            this.Resize += FormDashboard_Resize;
        }
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
            activeButton = btnFormHome;
            SetActiveButtonStyle(activeButton);
            OpenChildForm(new FormHome(), btnFormHome);
        }

       

        // Xử lý sự kiện thay đổi kích thước Form
        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            AdjustControlSizes(this);

            // Điều chỉnh form con nếu cần
            if (activeForm != null)
            {
                activeForm.Size = panelForm.Size;
            }
        }

        // Mở form con
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

        // Đặt kiểu dáng cho nút đang active
        private void SetActiveButtonStyle(Button button)
        {
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            button.ForeColor = Color.FromArgb(52, 152, 219);
        }

        // Đặt lại kiểu dáng cho nút không còn active
        private void ResetButtonStyle(Button button)
        {
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White;
        }

        // Xử lý sự kiện nhấn các nút điều hướng
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

        // Các sự kiện khi nhấn từng nút
        private void btnFormHome_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            OpenChildForm(new FormHome(), sender);
        }

        private void btnFormStudent_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            OpenChildForm(new FormStudent(), sender);
        }

        private void btnFormCompany_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            OpenChildForm(new FormCompany(), sender);
        }

        private void btnFormInternship_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            OpenChildForm(new FormInternship(), sender);
        }

        private void btnFormDg_Kq_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            OpenChildForm(new FormResult_evaluation(), sender);
        }

        private void btnFormTeacher_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            OpenChildForm(new FormTeacher(), sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

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