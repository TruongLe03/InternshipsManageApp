﻿namespace InternshipsManageApp.Forms
{
    partial class FormCompany
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
            this.btnDeleteCty = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateCty = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.timkiemcongty = new System.Windows.Forms.Button();
            this.btnAddCongty = new System.Windows.Forms.Button();
            this.txtLienhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNganhnghe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTencty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewcongty = new System.Windows.Forms.DataGridView();
            this.txttimkiemct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcongty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCty
            // 
            this.btnDeleteCty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteCty.Location = new System.Drawing.Point(312, 436);
            this.btnDeleteCty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCty.Name = "btnDeleteCty";
            this.btnDeleteCty.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteCty.TabIndex = 23;
            this.btnDeleteCty.Text = "Xoá";
            this.btnDeleteCty.UseVisualStyleBackColor = true;
            this.btnDeleteCty.Click += new System.EventHandler(this.btnDeleteCty_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(614, 436);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCty
            // 
            this.btnUpdateCty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateCty.Location = new System.Drawing.Point(460, 436);
            this.btnUpdateCty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateCty.Name = "btnUpdateCty";
            this.btnUpdateCty.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateCty.TabIndex = 22;
            this.btnUpdateCty.Text = "Sửa";
            this.btnUpdateCty.UseVisualStyleBackColor = true;
            this.btnUpdateCty.Click += new System.EventHandler(this.btnUpdateCty_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(454, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Danh sách công ty";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtmota);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtphone);
            this.panel1.Controls.Add(this.btnAddCongty);
            this.panel1.Controls.Add(this.txtLienhe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNganhnghe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTencty);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 602);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmota.Location = new System.Drawing.Point(25, 416);
            this.txtmota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(186, 30);
            this.txtmota.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(25, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(25, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Số điện thoại";
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtphone.Location = new System.Drawing.Point(25, 351);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(186, 30);
            this.txtphone.TabIndex = 28;
            // 
            // timkiemcongty
            // 
            this.timkiemcongty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timkiemcongty.Location = new System.Drawing.Point(674, 89);
            this.timkiemcongty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timkiemcongty.Name = "timkiemcongty";
            this.timkiemcongty.Size = new System.Drawing.Size(89, 35);
            this.timkiemcongty.TabIndex = 27;
            this.timkiemcongty.Text = "Tìm kiếm";
            this.timkiemcongty.UseVisualStyleBackColor = true;
            this.timkiemcongty.Click += new System.EventHandler(this.timkiemcongty_Click);
            // 
            // btnAddCongty
            // 
            this.btnAddCongty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCongty.Location = new System.Drawing.Point(64, 474);
            this.btnAddCongty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCongty.Name = "btnAddCongty";
            this.btnAddCongty.Size = new System.Drawing.Size(75, 35);
            this.btnAddCongty.TabIndex = 26;
            this.btnAddCongty.Text = "Thêm";
            this.btnAddCongty.UseVisualStyleBackColor = true;
            this.btnAddCongty.Click += new System.EventHandler(this.btnAddCongty_Click);
            // 
            // txtLienhe
            // 
            this.txtLienhe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLienhe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLienhe.Location = new System.Drawing.Point(29, 280);
            this.txtLienhe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLienhe.Name = "txtLienhe";
            this.txtLienhe.Size = new System.Drawing.Size(186, 30);
            this.txtLienhe.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(25, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Liên hệ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiachi.Location = new System.Drawing.Point(29, 147);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(186, 30);
            this.txtDiachi.TabIndex = 23;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Địa chỉ";
            // 
            // txtNganhnghe
            // 
            this.txtNganhnghe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNganhnghe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNganhnghe.Location = new System.Drawing.Point(29, 218);
            this.txtNganhnghe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNganhnghe.Name = "txtNganhnghe";
            this.txtNganhnghe.Size = new System.Drawing.Size(186, 30);
            this.txtNganhnghe.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngành nghề";
            // 
            // txtTencty
            // 
            this.txtTencty.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTencty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTencty.Location = new System.Drawing.Point(29, 85);
            this.txtTencty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTencty.Name = "txtTencty";
            this.txtTencty.Size = new System.Drawing.Size(186, 30);
            this.txtTencty.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên công ty";
            // 
            // dataGridViewcongty
            // 
            this.dataGridViewcongty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewcongty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewcongty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcongty.Location = new System.Drawing.Point(237, 218);
            this.dataGridViewcongty.Name = "dataGridViewcongty";
            this.dataGridViewcongty.RowHeadersWidth = 62;
            this.dataGridViewcongty.RowTemplate.Height = 28;
            this.dataGridViewcongty.Size = new System.Drawing.Size(679, 193);
            this.dataGridViewcongty.TabIndex = 25;
            this.dataGridViewcongty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data);
            this.dataGridViewcongty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcongty_CellContentClick);
            // 
            // txttimkiemct
            // 
            this.txttimkiemct.Location = new System.Drawing.Point(295, 93);
            this.txttimkiemct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttimkiemct.Name = "txttimkiemct";
            this.txttimkiemct.Size = new System.Drawing.Size(321, 26);
            this.txttimkiemct.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(291, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tìm kiếm theo tên";
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 602);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttimkiemct);
            this.Controls.Add(this.dataGridViewcongty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteCty);
            this.Controls.Add(this.timkiemcongty);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateCty);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCompany";
            this.Text = "Công ty thực tập";
            this.Load += new System.EventHandler(this.FormCompany_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcongty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteCty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdateCty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCongty;
        private System.Windows.Forms.TextBox txtLienhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNganhnghe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTencty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button timkiemcongty;
        private System.Windows.Forms.DataGridView dataGridViewcongty;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txttimkiemct;
        private System.Windows.Forms.Label label8;
    }
}