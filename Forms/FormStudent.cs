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
using System.Linq;
using System.Text;
using static InternshipsManageApp.datacombobox;







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

                try
                {
                    // Gửi yêu cầu POST
                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sinh viên đã được thêm thành công!");
                        DisplayStudents(); // Hiển thị lại danh sách sinh viên
                    }
                    else
                    {
                        // In ra mã lỗi và nội dung lỗi nếu có
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Lỗi khi thêm sinh viên: {response.StatusCode}, Nội dung lỗi: {errorResponse}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy ");
            }
        }

        private async void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewsinhvien.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewsinhvien.SelectedRows[0];
                var studentCode = selectedRow.Cells["Mã sinh viên"].Value?.ToString();
                //MessageBox.Show($"Mã sinh viên được chọn: {studentCode}");

                if (!string.IsNullOrWhiteSpace(studentCode))
                {
                    var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên với mã {studentCode}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Gửi yêu cầu xóa tới API
                        string url = $"http://sso.nqbdev.software/api/student/{studentCode}";
                        //MessageBox.Show($"URL gửi đến API: {url}");

                        try
                        {
                            var response = await client.DeleteAsync(url);
                           

                            if (response.IsSuccessStatusCode)
                            {
                                // Xóa thành công, cập nhật danh sách
                                MessageBox.Show("Sinh viên đã được xóa thành công!");

                                // Loại bỏ sinh viên khỏi danh sách `studentList`
                                studentList = studentList.Where(s => s.student_code != studentCode).ToList();

                                // Cập nhật lại DataGridView
                                DisplayStudents();
                            }
                            else
                            {
                                string errorResponse = await response.Content.ReadAsStringAsync();
                                MessageBox.Show($"Lỗi khi xóa sinh viên: {response.StatusCode}, Nội dung lỗi: {errorResponse}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hành động xóa sinh viên đã bị hủy.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã sinh viên không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private async void btnsua_Click(object sender, EventArgs e)
        {
            if (dataGridViewsinhvien.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewsinhvien.SelectedRows[0];

                // Lấy dữ liệu từ TextBox và ComboBox
                var studentCodemsv = selectedRow.Cells["Mã sinh viên"].Value?.ToString().Trim();
                var studentCode = txtMSV.Text?.Trim(); // Lấy mã sinh viên từ ô nhập
                var fullName = txtTenSv.Text?.Trim(); // Lấy tên đầy đủ từ ô nhập

                // Kiểm tra nếu tên đầy đủ hợp lệ
                if (string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Họ tên không được để trống.");
                    return;
                }

                string firstName = string.Empty;
                string lastName = string.Empty;

                // Tách tên đầy đủ thành họ và tên
                var nameParts = fullName.Split(' ');
                if (nameParts.Length > 1)
                {
                    lastName = nameParts[0];
                    firstName = string.Join(" ", nameParts.Skip(1));
                }
                else
                {
                    lastName = fullName; // Nếu chỉ có một tên, mặc định là họ
                }

                // Kiểm tra nếu có đầy đủ thông tin
                if (string.IsNullOrEmpty(studentCode))
                {
                    MessageBox.Show("Mã sinh viên không được để trống.");
                    return;
                }

                if (cbbLop.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp.");
                    return;
                }

                // Lấy ID của lớp từ ComboBox (cbbLop.SelectedValue là Id lớp)
                var selectedClassId = (int)cbbLop.SelectedValue; // ID của lớp

                // Tạo đối tượng student để gửi lên server
                var updatedStudent = new
                {
                    student_code = studentCode,
                    full_name = $"{lastName} {firstName}", // Đảm bảo gửi họ tên đầy đủ
                    class_id = selectedClassId // Gửi ID của lớp (class_id)
                };

                // Gửi yêu cầu PUT tới server
                string url = $"http://sso.nqbdev.software/api/student/{studentCodemsv}";
                MessageBox.Show($"URL: {url}"); // Hiển thị URL cho việc debug

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

                        client.DefaultRequestHeaders.Authorization =
                            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                        // Tuần tự hóa đối tượng thành chuỗi JSON
                        var jsonContent = JsonConvert.SerializeObject(updatedStudent);

                        // Tạo StringContent từ chuỗi JSON
                        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                        // Gửi yêu cầu PUT với nội dung JSON
                        var response = await client.PutAsync(url, content);
                        //MessageBox.Show("Test Response: " + response.StatusCode); // Kiểm tra mã trạng thái

                        var responseContent = await response.Content.ReadAsStringAsync();
                        //MessageBox.Show($"Response Content: {responseContent}");  // Kiểm tra phản hồi trả về từ server

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Cập nhật sinh viên thành công!");

                            // Cập nhật trực tiếp dữ liệu trong DataGridView thay vì gọi lại DisplayStudents()
                            selectedRow.Cells["Mã sinh viên"].Value = studentCode;
                            selectedRow.Cells["Họ tên"].Value = $"{lastName} {firstName}";
                            selectedRow.Cells["Lớp"].Value = cbbLop.Text;
                            DisplayStudents();
                        }
                        else
                        {
                            string errorResponse = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Lỗi khi cập nhật sinh viên: {response.StatusCode}, {errorResponse}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
            }



        }

        private void data(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng không click vào header (chỉ click vào các dòng dữ liệu)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được click
                var selectedRow = dataGridViewsinhvien.Rows[e.RowIndex];

                // Hiển thị thông tin từ các cột vào các TextBox
                txtMSV.Text = selectedRow.Cells["Mã sinh viên"].Value?.ToString();
                txtTenSv.Text = selectedRow.Cells["Họ tên"].Value?.ToString();

                // Lấy thêm thông tin lớp và khoa từ các cột tương ứng
                var className = selectedRow.Cells["Khoa"].Value?.ToString();
                var classNameDetail = selectedRow.Cells["Lớp"].Value?.ToString();

                // Hiển thị thông tin lớp trong ComboBox (hoặc TextBox)
                cbbLop.Text = $"{className} - {classNameDetail}";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {     // Lấy mã sinh viên từ TextBox
            var msvtk = txttimkiem.Text.Trim();

            // Kiểm tra mã sinh viên có bị bỏ trống không
            if (string.IsNullOrEmpty(msvtk))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;

            // Duyệt qua các dòng trong DataGridView để tìm sinh viên
            foreach (DataGridViewRow row in dataGridViewsinhvien.Rows)
            {
                if (row.Cells["Mã sinh viên"].Value != null &&
                    row.Cells["Mã sinh viên"].Value.ToString().Equals(msvtk, StringComparison.OrdinalIgnoreCase))
                {
                    // Nếu tìm thấy, thay đổi màu nền dòng
                    row.DefaultCellStyle.BackColor = Color.Yellow; // Màu nền vàng
                    row.DefaultCellStyle.ForeColor = Color.Black;  // Màu chữ đen
                    found = true;

                    // Đảm bảo dòng này được hiển thị trên cùng
                    dataGridViewsinhvien.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
                else
                {
                    // Reset màu nền của các dòng không liên quan
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã này.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
