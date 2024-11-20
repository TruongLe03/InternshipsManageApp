using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipsManageApp.Forms
{
    public partial class FormResult_evaluation : Form
    {
        public FormResult_evaluation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
                int thaido = int.Parse(txtThaido.Text);
                int baocao = int.Parse(txtBaocao.Text);
                int kinang = int.Parse(txtKinang.Text);
                int quanly = int.Parse(txtQuanly.Text);
                txtKetqua.Text = (thaido + baocao + kinang + quanly).ToString();
        }

        private void txtThaido_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }
    }
}
