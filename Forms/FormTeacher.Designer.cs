namespace InternshipsManageApp.Forms
{
    partial class FormTeacher
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
            this.panelGv = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMGV = new System.Windows.Forms.TextBox();
            this.panelSVPT = new System.Windows.Forms.Panel();
            this.btnUpdateSv = new System.Windows.Forms.Button();
            this.btnDeleteSv = new System.Windows.Forms.Button();
            this.btnAddSv = new System.Windows.Forms.Button();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Msv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trangthai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colStt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSdtGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmailGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonpt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelGv.SuspendLayout();
            this.panelSVPT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGv
            // 
            this.panelGv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelGv.Controls.Add(this.listView1);
            this.panelGv.Controls.Add(this.btnDelete);
            this.panelGv.Controls.Add(this.btnUpdate);
            this.panelGv.Controls.Add(this.btnAdd);
            this.panelGv.Controls.Add(this.label5);
            this.panelGv.Controls.Add(this.label4);
            this.panelGv.Controls.Add(this.label3);
            this.panelGv.Controls.Add(this.label2);
            this.panelGv.Controls.Add(this.label1);
            this.panelGv.Controls.Add(this.cbbMon);
            this.panelGv.Controls.Add(this.txtSDT);
            this.panelGv.Controls.Add(this.txtEmail);
            this.panelGv.Controls.Add(this.txtName);
            this.panelGv.Controls.Add(this.txtMGV);
            this.panelGv.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGv.Location = new System.Drawing.Point(0, 0);
            this.panelGv.Name = "panelGv";
            this.panelGv.Size = new System.Drawing.Size(300, 450);
            this.panelGv.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(81, 355);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 20);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(21, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 20);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 20);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Môn phụ trách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã giảng viên";
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(21, 201);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(121, 21);
            this.cbbMon.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(21, 156);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(121, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtMGV
            // 
            this.txtMGV.Location = new System.Drawing.Point(21, 25);
            this.txtMGV.Name = "txtMGV";
            this.txtMGV.Size = new System.Drawing.Size(121, 20);
            this.txtMGV.TabIndex = 0;
            // 
            // panelSVPT
            // 
            this.panelSVPT.Controls.Add(this.label10);
            this.panelSVPT.Controls.Add(this.btnSave);
            this.panelSVPT.Controls.Add(this.groupBox1);
            this.panelSVPT.Controls.Add(this.btnExit);
            this.panelSVPT.Controls.Add(this.btnUpdateSv);
            this.panelSVPT.Controls.Add(this.btnDeleteSv);
            this.panelSVPT.Controls.Add(this.btnAddSv);
            this.panelSVPT.Controls.Add(this.lvStudents);
            this.panelSVPT.Controls.Add(this.label6);
            this.panelSVPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSVPT.Location = new System.Drawing.Point(300, 0);
            this.panelSVPT.Name = "panelSVPT";
            this.panelSVPT.Size = new System.Drawing.Size(500, 450);
            this.panelSVPT.TabIndex = 1;
            this.panelSVPT.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUpdateSv
            // 
            this.btnUpdateSv.Location = new System.Drawing.Point(46, 338);
            this.btnUpdateSv.Name = "btnUpdateSv";
            this.btnUpdateSv.Size = new System.Drawing.Size(55, 23);
            this.btnUpdateSv.TabIndex = 4;
            this.btnUpdateSv.Text = "Sửa";
            this.btnUpdateSv.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSv
            // 
            this.btnDeleteSv.Location = new System.Drawing.Point(177, 338);
            this.btnDeleteSv.Name = "btnDeleteSv";
            this.btnDeleteSv.Size = new System.Drawing.Size(55, 23);
            this.btnDeleteSv.TabIndex = 3;
            this.btnDeleteSv.Text = "Xoá";
            this.btnDeleteSv.UseVisualStyleBackColor = true;
            // 
            // btnAddSv
            // 
            this.btnAddSv.Location = new System.Drawing.Point(284, 88);
            this.btnAddSv.Name = "btnAddSv";
            this.btnAddSv.Size = new System.Drawing.Size(55, 23);
            this.btnAddSv.TabIndex = 2;
            this.btnAddSv.Text = "Thêm";
            this.btnAddSv.UseVisualStyleBackColor = true;
            // 
            // lvStudents
            // 
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.NameSv,
            this.Msv,
            this.Class,
            this.Trangthai});
            this.lvStudents.HideSelection = false;
            this.lvStudents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvStudents.Location = new System.Drawing.Point(46, 191);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Scrollable = false;
            this.lvStudents.Size = new System.Drawing.Size(314, 131);
            this.lvStudents.TabIndex = 1;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 40;
            // 
            // NameSv
            // 
            this.NameSv.Text = "Họ và tên";
            this.NameSv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameSv.Width = 100;
            // 
            // Msv
            // 
            this.Msv.Text = "Mã sinh viên";
            this.Msv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Msv.Width = 100;
            // 
            // Class
            // 
            this.Class.Text = "Lớp";
            this.Class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Class.Width = 100;
            // 
            // Trangthai
            // 
            this.Trangthai.Text = "Trang thái";
            this.Trangthai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trangthai.Width = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh sách sinh viên phụ trách";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStt,
            this.colTenGv,
            this.colSdtGv,
            this.colEmailGv,
            this.colMonpt});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 241);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(259, 97);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colStt
            // 
            this.colStt.Text = "STT";
            this.colStt.Width = 40;
            // 
            // colTenGv
            // 
            this.colTenGv.Text = "Họ và tên";
            this.colTenGv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenGv.Width = 100;
            // 
            // colSdtGv
            // 
            this.colSdtGv.Text = "Số điện thoại";
            this.colSdtGv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSdtGv.Width = 100;
            // 
            // colEmailGv
            // 
            this.colEmailGv.Text = "Email";
            this.colEmailGv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEmailGv.Width = 120;
            // 
            // colMonpt
            // 
            this.colMonpt.Text = "Môn phụ trách";
            this.colMonpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMonpt.Width = 100;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(424, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(46, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Họ và tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã sinh viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Lớp:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Thêm sinh viên phụ trách";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSVPT);
            this.Controls.Add(this.panelGv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.panelGv.ResumeLayout(false);
            this.panelGv.PerformLayout();
            this.panelSVPT.ResumeLayout(false);
            this.panelSVPT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMGV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelSVPT;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader NameSv;
        private System.Windows.Forms.ColumnHeader Msv;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader Trangthai;
        private System.Windows.Forms.Button btnUpdateSv;
        private System.Windows.Forms.Button btnDeleteSv;
        private System.Windows.Forms.Button btnAddSv;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colStt;
        private System.Windows.Forms.ColumnHeader colTenGv;
        private System.Windows.Forms.ColumnHeader colSdtGv;
        private System.Windows.Forms.ColumnHeader colEmailGv;
        private System.Windows.Forms.ColumnHeader colMonpt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
    }
}