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
            ct.Columns.Add("STT", typeof(int));              // Cột số thứ tự
            ct.Columns.Add("Tên đợt", typeof(string));   // Cột tên công ty
            ct.Columns.Add("Địa chỉ", typeof(string));       // Cột địa chỉ
            ct.Columns.Add("Ngành nghề", typeof(string));    // Cột ngành nghề
            ct.Columns.Add("Liên hệ", typeof(string));       // Cột liên hệ (email)

            // Biến STT để đánh số thứ tự cho các công ty
            int stt = 1;

            foreach (var company in Companylist)
            {
                // Thêm từng công ty vào DataTable
                ct.Rows.Add(stt++, company.name, company.address, company.industry, company.email);
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
    }
}
