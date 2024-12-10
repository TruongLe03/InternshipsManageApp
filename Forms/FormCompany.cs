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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static InternshipsManageApp.Classes.congtythuctap;
using static InternshipsManageApp.sinhvien;



namespace InternshipsManageApp.Forms
{
    public partial class FormCompany : BaseForm
    {
        // Khởi tạo HttpClient
        private static readonly HttpClient client = new HttpClient();
        public FormCompany()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task<List<company>> GetCompany()
        {

            // Lấy token từ Properties.Settings
            string token = Properties.Settings.Default.AuthToken;

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token không hợp lệ hoặc hết hạn. Vui lòng đăng nhập lại.");
                return new List<company>(); // Trả về danh sách rỗng nếu không có token
            }

            // Thêm token vào header của yêu cầu HTTP
            client.DefaultRequestHeaders.Clear();  // Đảm bảo xóa các header cũ nếu có
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await client.GetAsync("http://sso.nqbdev.software/api/companies");
            var responseString = await response.Content.ReadAsStringAsync();
            //MessageBox.Show(responseString);

            if (response.IsSuccessStatusCode)
            {
                // Chuyển đổi JSON thành danh sách đối tượng Student
                var companys = JsonConvert.DeserializeObject<List<company>>(responseString);
                return companys;
            }
            else
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu company.");
                return new List<company>();
            }
        }
        private List<company> Companylist = new List<company>();

        private async void DisplayCompany()
        {
            // Lấy danh sách công ty từ API
            var Companies = await GetCompany();
            Companylist = Companies;

            // Tạo DataTable để hiển thị dữ liệu
            DataTable ct = new DataTable();
                         // Cột số thứ tự
            ct.Columns.Add("STT",typeof(int));
            ct.Columns.Add("Tên đợt", typeof(string));   // Cột tên công ty
            ct.Columns.Add("Địa chỉ", typeof(string));       // Cột địa chỉ
            ct.Columns.Add("Ngành nghề", typeof(string));    // Cột ngành nghề
            ct.Columns.Add("Liên hệ", typeof(string));       // Cột liên hệ (email)
            ct.Columns.Add("số điện thoại", typeof (string));
            ct.Columns.Add("mô tả" , typeof(string));


          
            foreach (var company in Companylist)
            {
                // Thêm từng công ty vào DataTable
                ct.Rows.Add (company.id, company.name, company.address, company.industry, company.email , company.phone , company.description);
               
            }
            dataGridViewcongty.DefaultCellStyle.ForeColor = Color.Black;

            // Gán DataTable vào DataGridView để hiển thị
            dataGridViewcongty.DataSource = ct; // Thay `dataGridView1` bằng tên DataGridView của bạn



        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
            DisplayCompany();

        }

        private void dataGridViewcongty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewcongty.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            dataGridViewcongty.MultiSelect = false; // Chỉ chọn 1 dòng tại một thời điểm
        }

        private async void btnAddCongty_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm công ty này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string name = txtTencty.Text.Trim();
                string address  = txtDiachi.Text.Trim();
                string profes = txtNganhnghe.Text.Trim();
                string contact = txtLienhe.Text.Trim();
                string phone = txtphone.Text.Trim();
                string description =txtmota.Text.Trim();
                // Tạo đối tượng sinh viên, đúng với định dạng yêu cầu từ API
               
                var newStudent = new
                {
                    company_id = 1,
                    name = name,
                    address = address,
                    industry = profes,
                    email = contact,
                    phone = phone,
                    description = description
                };

                string url = "http://sso.nqbdev.software/api/companies"; // URL của API
                var json = JsonConvert.SerializeObject(newStudent);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // Gửi yêu cầu POST
                    var response = await client.PostAsync(url, content);
                    //MessageBox.Show("kiểm tra respon"+response);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("công ty đã được thêm thành công!");
                        DisplayCompany();
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

        private async void btnDeleteCty_Click(object sender, EventArgs e)
        {
            if (dataGridViewcongty.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewcongty.SelectedRows[0];
                var idcongty = selectedRow.Cells["STT"].Value?.ToString();
                MessageBox.Show("idcongty" + idcongty);
               

                if (!string.IsNullOrWhiteSpace(idcongty))
                {
                    var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa công ty với mã {idcongty}?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Gửi yêu cầu xóa tới API
                        string url = $"http://sso.nqbdev.software/api/company/{idcongty}";
                        MessageBox.Show($"URL gửi đến API: {url}");

                        try
                        {
                            var response = await client.DeleteAsync(url);


                            if (response.IsSuccessStatusCode)
                            {
                                // Xóa thành công, cập nhật danh sách
                                MessageBox.Show("Sinh viên đã được xóa thành công!");

                                // Loại bỏ sinh viên khỏi danh sách `studentList`
                                Companylist = Companylist.Where(s => s.id != idcongty).ToList();

                                // Cập nhật lại DataGridView
                                DisplayCompany();
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

        private void btnUpdateCty_Click(object sender, EventArgs e)
        {

        }
    }
}
