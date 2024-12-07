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

        // call api data combobox lớp
        private async Task<List<StudentClass>> GetClasses()
        {
            string token = Properties.Settings.Default.AuthToken;

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token không hợp lệ hoặc hết hạn. Vui lòng đăng nhập lại.");
                return new List<StudentClass>();
            }

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.GetAsync("http://sso.nqbdev.software/api/classes");
            var responseString = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var classes = JsonConvert.DeserializeObject<List<StudentClass>>(responseString);
                return classes;
            }
            else
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu lớp học.");
                return new List<StudentClass>();
            }
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

            var response = await client.GetAsync("http://sso.nqbdev.software/api/students");
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

        private List<Student> studentList = new List<Student>();

        // Hàm để hiển thị dữ liệu sinh viên trong DataGridView
        private async void DisplayStudents()
        {
            // Giả sử GetStudents() trả về danh sách sinh viên
            var students = await GetStudents();
            studentList = students;
            // Tạo DataTable để lưu trữ thông tin sinh viên với các cột STT, Mã sinh viên, Họ tên
            DataTable dt = new DataTable();

            // Thêm cột STT, Mã sinh viên, Họ tên vào DataTable
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã sinh viên", typeof(string));
            dt.Columns.Add("Họ tên", typeof(string));
            dt.Columns.Add("Khoa" ,typeof(string));
            dt.Columns.Add("Lớp", typeof(string));
            

            // Biến để tạo số thứ tự (STT)
            int stt = 1;

            foreach (var student in studentList)
            {
                // Lấy tên lớp từ đối tượng Class (ví dụ: CNTT1)
                string className = student.Class != null ? student.Class.Faculty.Name : "N/A"; // Kiểm tra null để tránh lỗi nếu dữ liệu không có lớp
                string classs = student.Class != null ? student.Class.Name : "N/A";
                // Thêm từng sinh viên vào DataTable
                dt.Rows.Add(stt++, student.student_code, $"{student.first_name} {student.last_name}", className , classs);
            }
            dataGridViewsinhvien.DefaultCellStyle.ForeColor = Color.Black;

            // Gán DataTable vào DataGridView
            dataGridViewsinhvien.DataSource = dt;

            

        }

        private async void FormStudent_Load(object sender, EventArgs e)
        {
            // Gọi hàm hiển thị sinh viên khi form load
            DisplayStudents();


            var classes = await GetClasses();

            // Lưu dữ liệu lớp vào ComboBox
            var comboBoxData = classes.Select(c => new
            {
                Text = $"{c.Name} - {c.Faculty.Name}",
                iid = c.Id, // Chỉ lấy ID của lớp
                Class = c // Lưu đối tượng lớp vào
            }).ToList();

            // Gán giá trị cho ComboBox
            cbbLop.DisplayMember = "Text";  // Hiển thị chuỗi kết hợp (Tên lớp - Tên khoa)
            cbbLop.ValueMember = "iid";     // Giá trị lớp học (ID) khi người dùng chọn
            cbbLop.DataSource = comboBoxData;
        }

        private void dataGridViewsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cấu hình DataGridView
            dataGridViewsinhvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            dataGridViewsinhvien.MultiSelect = false; // Chỉ chọn 1 dòng tại một thời điểm


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool IsValidStudentCode(string code)
        {
            return code.All(char.IsDigit);  // Kiểm tra mã sinh viên chỉ chứa chữ số
        }

        private  async void btnAddsv_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm sinh viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string studentCode = txtMSV.Text.Trim();
                string fullName = txtTenSv.Text.Trim();

                // Kiểm tra mã sinh viên
                if (string.IsNullOrWhiteSpace(studentCode) || !IsValidStudentCode(studentCode))
                {
                    MessageBox.Show("Mã sinh viên chỉ có thể là chữ số.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Vui lòng nhập họ và tên.");
                    return;
                }

                string firstName = string.Empty;
                string lastName = string.Empty;
                var nameParts = fullName.Split(' ');

                // Nếu có nhiều phần trong tên, chia tên thành Họ và Tên
                if (nameParts.Length > 1)
                {
                    lastName = nameParts[0];
                    firstName = string.Join(" ", nameParts.Skip(1));
                }
                else
                {
                    lastName = fullName;
                }

                // Lấy lớp học được chọn từ ComboBox và chỉ lấy ID của lớp
                var selectedItem = (dynamic)cbbLop.SelectedItem;
                var selectedClassId = selectedItem.iid; // Lấy ID của lớp học

                // Tạo đối tượng sinh viên, đúng với định dạng yêu cầu từ API
                var newStudent = new
                {
                    student_code = studentCode,  // Mã sinh viên là một chuỗi hoặc số
                    full_name = $"{lastName} {firstName}",  // Tên đầy đủ
                    class_id = selectedClassId  // Chỉ gửi ID của lớp học
                };

                string url = "http://sso.nqbdev.software/api/students"; // URL của API
                var json = JsonConvert.SerializeObject(newStudent);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

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

                try
                {
                    using (var client = new HttpClient())
                    {
                        // Gắn token từ Settings vào Header
                        var token = Properties.Settings.Default.AuthToken;
                        if (string.IsNullOrEmpty(token))
                        {
                            MessageBox.Show("Token không tồn tại. Vui lòng đăng nhập lại.");
                            return;
                        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
