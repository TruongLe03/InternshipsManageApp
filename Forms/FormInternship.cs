using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static InternshipsManageApp.Classes.congtythuctap;
using static InternshipsManageApp.Thuctap;

namespace InternshipsManageApp.Forms
{
    public partial class FormInternship : BaseForm
    {
        // Khởi tạo HttpClient
        private static readonly HttpClient client = new HttpClient();
        public FormInternship()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }
        private async Task<List<internship>> GetIntern()
        {

            // Lấy token từ Properties.Settings
            string token = Properties.Settings.Default.AuthToken;

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token không hợp lệ hoặc hết hạn. Vui lòng đăng nhập lại.");
                return new List<internship>(); // Trả về danh sách rỗng nếu không có token
            }

            // Thêm token vào header của yêu cầu HTTP
            client.DefaultRequestHeaders.Clear();  // Đảm bảo xóa các header cũ nếu có
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.GetAsync("http://sso.nqbdev.software/api/interns");
            var responseString = await response.Content.ReadAsStringAsync();
            //MessageBox.Show(responseString);

            if (response.IsSuccessStatusCode)
            {
                // Chuyển đổi JSON thành danh sách đối tượng Student
                var internships = JsonConvert.DeserializeObject<List<internship>>(responseString);
                return internships;
            }
            else
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu internship.");
                return new List<internship>();
            }
        }
        private List<internship> Internlist = new List<internship>();
        private async void Displayintern()
        {
            var internship = await GetIntern();
            Internlist = internship;
            // Tạo DataTable để hiển thị dữ liệu
            DataTable it = new DataTable();
            it.Columns.Add("STT", typeof(int));              
            it.Columns.Add("Tên đợt", typeof(string));   
            it.Columns.Add("Thời gian bắt đầu", typeof(string));      
            it.Columns.Add("Thời gian kết thúc", typeof(string));
            int stt = 1;

            foreach (var item in Internlist)
            {
                // Thêm từng công ty vào DataTable
                it.Rows.Add(stt++, item.name, item.start_date, item.end_date);
            }
            dataGridViewthuctap.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewthuctap.DataSource = it;
        }
        private void FormInternship_Load(object sender, EventArgs e)
        {
            Displayintern();

        }

        private void dataGridViewthuctap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewthuctap.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            dataGridViewthuctap.MultiSelect = false; // Chỉ chọn 1 dòng tại một thời điểm
        }

        private async void btnAddthuctap_Click(object sender, EventArgs e)
        {
            string Name = txtTendot.Text;
            string start = txtStarttime.Text;
            string end = txtEndtime.Text;
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(start) || string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Hãy điền đầy đủ các trường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm đợt thực tập này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                // Tạo đối tượng sinh viên, đúng với định dạng yêu cầu từ API
               

                var newStudent = new
                {
                    id = 1,
                    name = Name,
                    start_date =start,
                    end_date =end,
                };

                string url = "http://sso.nqbdev.software/api/interns"; // URL của API
                var json = JsonConvert.SerializeObject(newStudent);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // Gửi yêu cầu POST
                    var response = await client.PostAsync(url, content);
                    MessageBox.Show("kiểm tra respon" + response);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("đợt thực tập này đã được thêm thành công!");
                        Displayintern();
                        
                       
                    }
                    else
                    {
                        // In ra mã lỗi và nội dung lỗi nếu có
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Lỗi khi thêm công ty: {response.StatusCode}, Nội dung lỗi: {errorResponse}");
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

        private void txtStarttime_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtStarttime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn ký tự không hợp lệ
            }
        }

        private void txtEndtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn ký tự không hợp lệ
            }
        }
    }
}
