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
                if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ.");
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
                    MessageBox.Show("test lỗi" + response);
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
                var lecturerId = selectedRow.Cells["id"].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
