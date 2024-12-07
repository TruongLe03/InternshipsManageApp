using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static InternshipsManageApp.home;

namespace InternshipsManageApp.Forms
{
    public partial class FormHome : BaseForm
    {
        private static readonly HttpClient clientDashboard = new HttpClient();
        public FormHome()
        {
            InitializeComponent();
        }

        private async Task<HomeData> GetDataDashboardAsync()
        {
            // Lấy token từ Properties.Settings
            string token = Properties.Settings.Default.AuthToken;

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token không hợp lệ hoặc hết hạn. Vui lòng đăng nhập lại.");
                return null; // Trả về null nếu không có token
            }

            // Thêm token vào header của yêu cầu HTTP
            clientDashboard.DefaultRequestHeaders.Clear();  // Đảm bảo xóa các header cũ nếu có
            clientDashboard.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            try
            {
                // Gọi API Dashboard
                var response = await clientDashboard.GetAsync("http://nqbdev-30704.portmap.host:30704/api/dashboard");
                var responseData = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    // Chuyển đổi JSON thành đối tượng DashboardData
                    var dashboardData = JsonConvert.DeserializeObject<HomeData>(responseData);
                    return dashboardData;
                }
                else
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu dashboard.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                return null;
            }
        }


        private async void FormHome_Load(object sender, EventArgs e)
        {
            var dashboardData = await GetDataDashboardAsync();

            if (dashboardData != null)
            {
                // Cập nhật dữ liệu lên giao diện
                lbTotalStudents.Text = dashboardData.CountStudents.ToString();
                lbTotalGv.Text = dashboardData.CountLecturers.ToString();
                lbTotalDtt.Text = dashboardData.CountInternships.ToString();
                lbTotalCty.Text = dashboardData.CountCompanies.ToString();
            }
        }

    }
}
