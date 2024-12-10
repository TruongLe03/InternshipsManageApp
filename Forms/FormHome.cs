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
using static InternshipsManageApp.Classes.dashboard;

namespace InternshipsManageApp.Forms
{
    public partial class FormHome : BaseForm
    {
        private static readonly HttpClient clientDashboard = new HttpClient();

        public FormHome(string token)
        {
            InitializeComponent();
           
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            GetDataDashboard();
        }

        private async Task GetDataDashboard()
        {
            string token = Properties.Settings.Default.AuthToken;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://sso.nqbdev.software/api/dashboard";
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token); // Sử dụng token

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        // Deserialize JSON thành đối tượng DashboardData
                        DashboardData data = JsonConvert.DeserializeObject<DashboardData>(responseData);

                        // Gán dữ liệu vào các Label
                        lbTotalStudents.Text = data.CountStudents.ToString();
                        lbTotalCty.Text = data.CountCompanies.ToString();
                        lbTotalDtt.Text = data.CountInternships.ToString();
                        lbTotalGv.Text = data.CountLecturers.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}\n{await response.Content.ReadAsStringAsync()}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}");
                }
            }
        }
    }

}
