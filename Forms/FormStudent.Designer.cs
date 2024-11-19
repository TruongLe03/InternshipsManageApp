namespace InternshipsManageApp.Forms
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemote = new System.Windows.Forms.Button();
            this.ClName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClKhoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.Controls.Add(this.btnRemote);
            this.panelNavbar.Controls.Add(this.btnUpdate);
            this.panelNavbar.Controls.Add(this.btnAdd);
            this.panelNavbar.Controls.Add(this.comboBox1);
            this.panelNavbar.Controls.Add(this.label1);
            this.panelNavbar.Controls.Add(this.button1);
            this.panelNavbar.Controls.Add(this.textBox1);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(800, 60);
            this.panelNavbar.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khoá học";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2018-2022",
            "2019-2023",
            "2020-2024",
            "2021-2025",
            "2022-2026",
            "2023-2027"});
            this.comboBox1.Location = new System.Drawing.Point(381, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClName,
            this.ClMSV,
            this.ClClass,
            this.ClNganh,
            this.ClPhone,
            this.ClEmail,
            this.ClKhoahoc,
            this.ClAddress});
            this.dataGridView1.Location = new System.Drawing.Point(23, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 338);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(566, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(618, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(46, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemote
            // 
            this.btnRemote.Location = new System.Drawing.Point(670, 16);
            this.btnRemote.Name = "btnRemote";
            this.btnRemote.Size = new System.Drawing.Size(46, 30);
            this.btnRemote.TabIndex = 6;
            this.btnRemote.Text = "Xoá";
            this.btnRemote.UseVisualStyleBackColor = true;
            // 
            // ClName
            // 
            this.ClName.HeaderText = "Họ và tên";
            this.ClName.MinimumWidth = 100;
            this.ClName.Name = "ClName";
            this.ClName.ReadOnly = true;
            this.ClName.Width = 200;
            // 
            // ClMSV
            // 
            this.ClMSV.HeaderText = "Mã sinh viên";
            this.ClMSV.MinimumWidth = 100;
            this.ClMSV.Name = "ClMSV";
            this.ClMSV.Width = 150;
            // 
            // ClClass
            // 
            this.ClClass.HeaderText = "Lớp";
            this.ClClass.MinimumWidth = 50;
            this.ClClass.Name = "ClClass";
            // 
            // ClNganh
            // 
            this.ClNganh.HeaderText = "Ngành học";
            this.ClNganh.Name = "ClNganh";
            // 
            // ClPhone
            // 
            this.ClPhone.HeaderText = "Số điện thoại";
            this.ClPhone.MinimumWidth = 100;
            this.ClPhone.Name = "ClPhone";
            this.ClPhone.Width = 150;
            // 
            // ClEmail
            // 
            this.ClEmail.HeaderText = "Email";
            this.ClEmail.MinimumWidth = 100;
            this.ClEmail.Name = "ClEmail";
            this.ClEmail.Width = 200;
            // 
            // ClKhoahoc
            // 
            this.ClKhoahoc.HeaderText = "Khoá học";
            this.ClKhoahoc.MinimumWidth = 100;
            this.ClKhoahoc.Name = "ClKhoahoc";
            this.ClKhoahoc.Width = 150;
            // 
            // ClAddress
            // 
            this.ClAddress.HeaderText = "Địa chỉ";
            this.ClAddress.MinimumWidth = 100;
            this.ClAddress.Name = "ClAddress";
            this.ClAddress.Width = 200;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelNavbar);
            this.Name = "FormStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemote;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClKhoahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAddress;
    }
}