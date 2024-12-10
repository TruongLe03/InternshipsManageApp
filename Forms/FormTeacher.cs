using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternshipsManageApp.Classes;
using Newtonsoft.Json;
using static InternshipsManageApp.Classes.Giangvien;
using static InternshipsManageApp.datacombobox;
using static InternshipsManageApp.sinhvien;

namespace InternshipsManageApp.Forms
{
    public partial class FormTeacher : BaseForm
    {
        // Khởi tạo HttpClient
        private static readonly HttpClient client = new HttpClient();
        public FormTeacher()
        {
            InitializeComponent();
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
          // call api combobox
        private async Task<List<Giangvien.Faculty>> GetFacuties()
        {
            string token = Properties.Settings.Default.AuthToken;

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token không hợp lệ hoặc hết hạn. Vui lòng đăng nhập lại.");
                return new List<Giangvien.Faculty>();
            }

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.GetAsync("http://sso.nqbdev.software/api/faculties");
            var responseString = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var facuti = JsonConvert.DeserializeObject<List<Giangvien.Faculty>>(responseString);
                return facuti;
            }
            else
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu lớp học.");
                return new List<Giangvien.Faculty>();
            }
        }
        private async Task<List<lecturers>> GetLecturers()
        {

            // Lấy token từ Properties.Settings
            string token = Properties.Settings.Default.AuthToken;

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token không hợp lệ hoặc hết hạn. Vui lòng đăng nhập lại.");
                return new List<lecturers>(); // Trả về danh sách rỗng nếu không có token
            }

            // Thêm token vào header của yêu cầu HTTP
            client.DefaultRequestHeaders.Clear();  // Đảm bảo xóa các header cũ nếu có
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.GetAsync("http://sso.nqbdev.software/api/lecturers");
            var responseString = await response.Content.ReadAsStringAsync();



            if (response.IsSuccessStatusCode)
            {
                // Chuyển đổi JSON thành danh sách đối tượng Student
                var lecturerss = JsonConvert.DeserializeObject<List<lecturers>>(responseString);
                return lecturerss;
            }
            else
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu sinh viên.");
                return new List<lecturers>();
            }
        }

        private List<lecturers> lecturersList = new List<lecturers>();

        private async void DisplayStudents()
        {
            // Giả sử GetLecturers() trả về danh sách giảng viên
            var lecturers = await GetLecturers();
            lecturersList = lecturers;

            // Tạo DataTable để lưu trữ thông tin giảng viên với các cột STT, Mã giảng viên, Họ tên
            DataTable gv = new DataTable();

            // Thêm cột STT, Họ tên, Email, Số điện thoại và Tên khoa vào DataTable
           
            gv.Columns.Add("STT", typeof(int));
            gv.Columns.Add("Họ và tên", typeof(string));
            gv.Columns.Add("Email", typeof(string));
            gv.Columns.Add("Số điện thoại", typeof(string));
            gv.Columns.Add("Tên khoa", typeof(string));
           
            // Biến để tạo số thứ tự (STT)
            

            foreach (var lecturer in lecturersList)
            {
                string facultyName = lecturer.faculty?.name ?? "Không có lớp"; // Lấy tên khoa, kiểm tra null nếu không có khoa

                // Thêm dòng mới vào DataTable
                gv.Rows.Add(lecturer.id,$"{lecturer.first_name} {lecturer.last_name}", lecturer.email, lecturer.phone, facultyName);

              
            }

            dataGridViewgiangvien.DefaultCellStyle.ForeColor = Color.Black;

            // Gán DataTable vào DataGridView
            dataGridViewgiangvien.DataSource = gv;




        }
        private async void FormTeacher_Load(object sender, EventArgs e)
        {
            DisplayStudents();

            var facuti = await GetFacuties();

            // Lưu dữ liệu lớp vào ComboBox
            var comboBoxData = facuti.Select(c => new
            {
                Text =c.name,
                iid = c.id, // Chỉ lấy ID của lớp
                Class = c // Lưu đối tượng lớp vào
            }).ToList();

            // Gán giá trị cho ComboBox
            comboBoxgiangvien.DisplayMember = "Text";  // Hiển thị chuỗi kết hợp (Tên lớp - Tên khoa)
            comboBoxgiangvien.ValueMember = "iid";     // Giá trị lớp học (ID) khi người dùng chọn
            comboBoxgiangvien.DataSource = comboBoxData;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm sinh viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                string fullName = txtName.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string Phone = txtSDT.Text.Trim();
                if (string.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Vui lòng nhập họ và tên.");
                    return;
                }
               

                // Kiểm tra số điện thoại phải đúng 10 số
                if (!Regex.IsMatch(Phone, @"^\d{10}$"))
                {
                    MessageBox.Show("Số điện thoại phải bao gồm đúng 10 chữ số.");
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

                var selectedItem = (dynamic)comboBoxgiangvien.SelectedItem;
                var selectedClassId = selectedItem.iid;
                


                // Tạo đối tượng sinh viên, đúng với định dạng yêu cầu từ API
                var newLetcures = new
                {
                   
                    full_name = $"{lastName} {firstName}",
                    phone = Phone,
                    email = Email,
                    faculty_id = selectedClassId

                };

                string url = "http://sso.nqbdev.software/api/lecturers"; 
                var json = JsonConvert.SerializeObject(newLetcures);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                

                try
                {
                    // Gửi yêu cầu POST
                    var response = await client.PostAsync(url, content);
                    MessageBox.Show("test " + response);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("giảng viên đã được thêm thành công!");
                        DisplayStudents(); // Hiển thị lại danh sách sinh viên
                    }
                    else
                    {
                        // In ra mã lỗi và nội dung lỗi nếu có
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Lỗi khi thêm giảng viên: {response.StatusCode}, Nội dung lỗi: {errorResponse}");
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewgiangvien.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewgiangvien.SelectedRows[0];
                var lecturerId = selectedRow.Cells["STT"].Value.ToString();
                MessageBox.Show($"Mã sinh viên được chọn: {lecturerId}");

                if (!string.IsNullOrWhiteSpace(lecturerId))
                {
                    var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên với mã {lecturerId}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Gửi yêu cầu xóa tới API
                        string url = $"http://sso.nqbdev.software/api/lecturer/{lecturerId}";
                        MessageBox.Show($"URL gửi đến API: {url}");

                        try
                        {
                            var response = await client.DeleteAsync(url);


                            if (response.IsSuccessStatusCode)
                            {
                                // Xóa thành công, cập nhật danh sách
                                MessageBox.Show("Sinh viên đã được xóa thành công!");

                                // Loại bỏ sinh viên khỏi danh sách `studentList`
                                lecturersList = lecturersList.Where(l => l.id != lecturerId).ToList();

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

        private void dataGridViewgiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewgiangvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            dataGridViewgiangvien.MultiSelect = false;
        }


        private void txttimkiemgv_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm từ TextBox
            var tiemkiemgv = txttimkiem.Text.Trim();

            // Kiểm tra nếu từ khóa rỗng
            if (string.IsNullOrEmpty(tiemkiemgv))
            {
                MessageBox.Show("Vui lòng nhập họ tên giảng viên để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false; // Đánh dấu nếu tìm thấy kết quả

            // Lặp qua tất cả các dòng trong DataGridView
            foreach (DataGridViewRow row in dataGridViewgiangvien.Rows)
            {
                if (row.Cells["Họ và tên"].Value != null)
                {
                    var cellValue = row.Cells["Họ và tên"].Value.ToString();
                    if (cellValue.IndexOf(tiemkiemgv, StringComparison.OrdinalIgnoreCase) >= 0)
                    {

                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        found = true;
                    }
                    else
                    {

                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                else
                {

                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            // Hiển thị thông báo nếu không tìm thấy kết quả
            if (!found)
            {
                MessageBox.Show("Không tìm thấy giảng viên khớp với từ khóa.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewgiangvien.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewgiangvien.SelectedRows[0];

                // Lấy dữ liệu từ TextBox
                var lecturerId = selectedRow.Cells["STT"].Value?.ToString().Trim(); // Lấy ID giảng viên từ cột STT
                var fullName = txtName.Text?.Trim(); // Lấy tên đầy đủ từ ô nhập
                var phone = txtSDT.Text?.Trim(); // Lấy số điện thoại từ ô nhập

                // Kiểm tra nếu tên đầy đủ hợp lệ
                if (string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Họ tên không được để trống.");
                    return;
                }

                if (string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Số điện thoại không được để trống.");
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

                // Tạo đối tượng lecturer để gửi lên server
                var updatedLecturer = new
                {
                    full_name = $"{lastName} {firstName}", // Họ tên đầy đủ
                    phone = phone // Số điện thoại
                };

                // Gửi yêu cầu PUT tới server
                string url = $"http://sso.nqbdev.software/api/lecturer/{lecturerId}";
                //MessageBox.Show($"URL: {url}"); // Hiển thị URL cho việc debug

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
                        var jsonContent = JsonConvert.SerializeObject(updatedLecturer);

                        // Tạo StringContent từ chuỗi JSON
                        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                        // Gửi yêu cầu PUT với nội dung JSON
                        var response = await client.PutAsync(url, content);

                        var responseContent = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Cập nhật giảng viên thành công!");

                            // Cập nhật trực tiếp dữ liệu trong DataGridView
                            selectedRow.Cells["Họ và tên"].Value = $"{lastName} {firstName}";
                            selectedRow.Cells["Số điện thoại"].Value = phone;
                        }
                        else
                        {
                            string errorResponse = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Lỗi khi cập nhật giảng viên: {response.StatusCode}, {errorResponse}");
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
                MessageBox.Show("Vui lòng chọn một giảng viên để sửa.");
            }

        }
        private void Data(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng không click vào header (chỉ click vào các dòng dữ liệu)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được click
                var selectedRow = dataGridViewgiangvien.Rows[e.RowIndex];

                // Hiển thị thông tin từ các cột vào các TextBox
                txtName.Text = selectedRow.Cells["Họ và tên"].Value?.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                txtSDT.Text = selectedRow.Cells["Số điện thoại"]?.Value.ToString();

                

                // Hiển thị thông tin lớp trong ComboBox (hoặc TextBox)
                comboBoxgiangvien.Text = selectedRow.Cells["Tên khoa"].Value?.ToString();
            }
        }
    }
}
