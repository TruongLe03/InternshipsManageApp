using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Media3D;

namespace InternshipsManageApp
{
    public partial class FormDashboard : Form
    {
        private Button activeButton; // Lưu trữ nút hiện tại đang được chọn
        private Form activeForm; // Lưu trữ form con đang mở

        public FormDashboard()
        {
            InitializeComponent();

            // Gắn sự kiện Click cho các nút điều hướng
            btnFormHome.Click += Button_Click;
            btnFormStudent.Click += Button_Click;
            btnFormCompany.Click += Button_Click;
            btnFormInternship.Click += Button_Click;
            btnFormTeacher.Click += Button_Click;
           
            btnFormDg_Kq.Click += Button_Click;

            // Thiết lập trạng thái mặc định
            InitializeDefaultState();
        }

        // Phương thức khởi tạo mặc định (mặc định ở Home)
        private void InitializeDefaultState()
        {
            // Thiết lập Home là nút active mặc định
            activeButton = btnFormHome;
            SetActiveButtonStyle(activeButton);

            // Hiển thị nội dung của Home
            lbSelected.Text = "Home"; // Cập nhật tiêu đề
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        // Phương thức xử lý khi nút điều hướng được nhấn
        private void Button_Click(object sender, EventArgs e)
        {
            // Đặt lại giao diện nút trước đó (nếu có)
            if (activeButton != null)
            {
                ResetButtonStyle(activeButton); // Đặt lại giao diện của nút trước đó
            }

            // Cập nhật giao diện cho nút hiện tại
            activeButton = sender as Button;
            SetActiveButtonStyle(activeButton);

            // Kiểm tra nếu là Home, không mở form mới
            if (activeButton == btnFormHome)
            {
                if (activeForm != null)
                {
                    activeForm.Close(); // Đóng form con đang hiển thị
                    activeForm = null;
                }
                lbSelected.Text = "Home"; // Cập nhật tiêu đề
            }
            else
            {
                // Mở form con tương ứng
                OpenChildForm(GetChildFormByButton(activeButton), activeButton);
            }
        }

        // Phương thức mở form con
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Đóng form con trước đó
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm form con vào giao diện Dashboard
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;

            // Đưa form con ra phía trước và hiển thị
            childForm.BringToFront();
            childForm.Show();

            // Cập nhật nhãn tiêu đề
            lbSelected.Text = childForm.Text;
        }

        // Phương thức trả về form con tương ứng với từng nút
        private Form GetChildFormByButton(Button button)
        {
            if (button == btnFormStudent) return new Forms.FormStudent();
            if (button == btnFormCompany) return new Forms.FormCompany();
            if (button == btnFormInternship) return new Forms.FormInternship();
            if (button == btnFormTeacher) return new Forms.FormTeacher();
            
            if (button == btnFormDg_Kq) return new Forms.FormResult_evaluation();

            return null;
        }

        // Đặt giao diện cho nút active
        private void SetActiveButtonStyle(Button button)
        {
            button.FlatAppearance.BorderSize = 2; // Viền nổi bật
            button.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219); // Viền màu xanh
            button.ForeColor = Color.FromArgb(52, 152, 219); // Màu chữ nổi bật
        }

        // Đặt lại giao diện nút không còn active
        private void ResetButtonStyle(Button button)
        {
            button.FlatAppearance.BorderSize = 0; // Loại bỏ viền
            button.ForeColor = Color.White; // Đặt lại màu chữ mặc định
        }

        // Sự kiện đóng ứng dụng
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            
        }

    }
}
