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

namespace InternshipsManageApp.Forms
{
    public partial class FormHome : BaseForm
    {
        private static readonly HttpClient clientDashboard = new HttpClient();
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            GetDataDashboard();
        }
        private async Task GetDataDashboard()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://192.168.0.196:8001/api/dashboard";
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "your-access-token");

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(responseData, "Data Retrieved");
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
