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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbDot = new System.Windows.Forms.ComboBox();
            this.cbbChuyennganh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNganhhoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddsv = new System.Windows.Forms.Button();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewsinhvien = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(590, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(378, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(304, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(234, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(329, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Danh sách sinh viên";
            // 
            // cbbDot
            // 
            this.cbbDot.ForeColor = System.Drawing.Color.Black;
            this.cbbDot.FormattingEnabled = true;
            this.cbbDot.Location = new System.Drawing.Point(233, 72);
            this.cbbDot.Name = "cbbDot";
            this.cbbDot.Size = new System.Drawing.Size(121, 21);
            this.cbbDot.TabIndex = 26;
            // 
            // cbbChuyennganh
            // 
            this.cbbChuyennganh.ForeColor = System.Drawing.Color.Black;
            this.cbbChuyennganh.FormattingEnabled = true;
            this.cbbChuyennganh.Location = new System.Drawing.Point(406, 72);
            this.cbbChuyennganh.Name = "cbbChuyennganh";
            this.cbbChuyennganh.Size = new System.Drawing.Size(190, 21);
            this.cbbChuyennganh.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(231, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Đợt thực tập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(403, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Chuyên ngành";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtNganhhoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddsv);
            this.panel1.Controls.Add(this.txtLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMSV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenSv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 362);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtNganhhoc
            // 
            this.txtNganhhoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNganhhoc.Location = new System.Drawing.Point(15, 200);
            this.txtNganhhoc.Name = "txtNganhhoc";
            this.txtNganhhoc.Size = new System.Drawing.Size(141, 22);
            this.txtNganhhoc.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngành học";
            // 
            // btnAddsv
            // 
            this.btnAddsv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddsv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddsv.Location = new System.Drawing.Point(55, 241);
            this.btnAddsv.Name = "btnAddsv";
            this.btnAddsv.Size = new System.Drawing.Size(50, 23);
            this.btnAddsv.TabIndex = 24;
            this.btnAddsv.Text = "Thêm";
            this.btnAddsv.UseVisualStyleBackColor = true;
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(15, 160);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(141, 22);
            this.txtLop.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Lớp";
            // 
            // txtMSV
            // 
            this.txtMSV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSV.Location = new System.Drawing.Point(15, 120);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(141, 22);
            this.txtMSV.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã sinh viên";
            // 
            // txtTenSv
            // 
            this.txtTenSv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSv.Location = new System.Drawing.Point(15, 80);
            this.txtTenSv.Name = "txtTenSv";
            this.txtTenSv.Size = new System.Drawing.Size(141, 22);
            this.txtTenSv.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Họ và tên";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(536, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 22);
            this.button5.TabIndex = 30;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(231, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tìm kiếm sinh viên";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(233, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 25;
            // 
            // dataGridViewsinhvien
            // 
            this.dataGridViewsinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewsinhvien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewsinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsinhvien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewsinhvien.Location = new System.Drawing.Point(208, 138);
            this.dataGridViewsinhvien.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewsinhvien.Name = "dataGridViewsinhvien";
            this.dataGridViewsinhvien.RowHeadersWidth = 62;
            this.dataGridViewsinhvien.RowTemplate.Height = 28;
            this.dataGridViewsinhvien.Size = new System.Drawing.Size(404, 137);
            this.dataGridViewsinhvien.TabIndex = 33;
            this.dataGridViewsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsinhvien_CellContentClick);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 362);
            this.Controls.Add(this.dataGridViewsinhvien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbChuyennganh);
            this.Controls.Add(this.cbbDot);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Name = "FormStudent";
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbDot;
        private System.Windows.Forms.ComboBox cbbChuyennganh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNganhhoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddsv;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewsinhvien;
    }
}