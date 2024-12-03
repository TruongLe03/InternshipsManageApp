using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static InternshipsManageApp.sinhvien;
using System.Drawing;



namespace InternshipsManageApp.Forms
{
    public partial class FormStudent : BaseForm
    {
        // Khởi tạo HttpClient
        private static readonly HttpClient client = new HttpClient();

        public FormStudent()
        {
            InitializeComponent();
        }

        // Lấy dữ liệu sinh viên từ API
        private async Task<List<Student>> GetStudents()
        {

            // Lấy token từ Properties.Settings
            string token = Properties.Settings.Default.AuthToken;

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token không hợp lệ hoặc hết hạn. Vui lòng đăng nhập lại.");
                return new List<Student>(); // Trả về danh sách rỗng nếu không có token
            }

            // Thêm token vào header của yêu cầu HTTP
            client.DefaultRequestHeaders.Clear();  // Đảm bảo xóa các header cũ nếu có
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.GetAsync("http://nqbdev-30704.portmap.host:30704/api/students");
            var responseString = await response.Content.ReadAsStringAsync();
           

            if (response.IsSuccessStatusCode)
            {
                // Chuyển đổi JSON thành danh sách đối tượng Student
                var students = JsonConvert.DeserializeObject<List<Student>>(responseString);
                return students;
            }
            else
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu sinh viên.");
                return new List<Student>();
            }
        }

        // Hàm để hiển thị dữ liệu sinh viên trong DataGridView
        private async void DisplayStudents()
        {
            // Giả sử GetStudents() trả về danh sách sinh viên
            var students = await GetStudents();

            // Tạo DataTable để lưu trữ thông tin sinh viên với các cột STT, Mã sinh viên, Họ tên
            DataTable dt = new DataTable();

            // Thêm cột STT, Mã sinh viên, Họ tên vào DataTable
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã sinh viên", typeof(string));
            dt.Columns.Add("Họ tên", typeof(string));

            // Biến để tạo số thứ tự (STT)
            int stt = 1;

            foreach (var student in students)
            {
                // Thêm từng sinh viên vào DataTable
                dt.Rows.Add(stt++, student.student_code, $"{student.first_name} {student.last_name}");
            }
            dataGridViewsinhvien.DefaultCellStyle.ForeColor = Color.Black;

            // Gán DataTable vào DataGridView
            dataGridViewsinhvien.DataSource = dt;

            

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            // Gọi hàm hiển thị sinh viên khi form load
            DisplayStudents();
        }

        private void dataGridViewsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
