namespace InternshipsManageApp.Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCty = new System.Windows.Forms.Button();
            this.txtLienhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNganhnghe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTencty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateCty = new System.Windows.Forms.Button();
            this.btnDeleteCty = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataCty = new System.Windows.Forms.DataGridView();
            this.NameCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nganhnghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lienhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.btnAddCty);
            this.panel1.Controls.Add(this.txtLienhe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNganhnghe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTencty);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnAddCty
            // 
            this.btnAddCty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAddCty.Location = new System.Drawing.Point(16, 258);
            this.btnAddCty.Name = "btnAddCty";
            this.btnAddCty.Size = new System.Drawing.Size(75, 23);
            this.btnAddCty.TabIndex = 8;
            this.btnAddCty.Text = "Thêm";
            this.btnAddCty.UseVisualStyleBackColor = true;
            // 
            // txtLienhe
            // 
            this.txtLienhe.Location = new System.Drawing.Point(16, 205);
            this.txtLienhe.Name = "txtLienhe";
            this.txtLienhe.Size = new System.Drawing.Size(100, 20);
            this.txtLienhe.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Liên hệ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(16, 93);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(100, 20);
            this.txtDiachi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // txtNganhnghe
            // 
            this.txtNganhnghe.Location = new System.Drawing.Point(16, 151);
            this.txtNganhnghe.Name = "txtNganhnghe";
            this.txtNganhnghe.Size = new System.Drawing.Size(100, 20);
            this.txtNganhnghe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngành nghề";
            // 
            // txtTencty
            // 
            this.txtTencty.Location = new System.Drawing.Point(16, 43);
            this.txtTencty.Name = "txtTencty";
            this.txtTencty.Size = new System.Drawing.Size(100, 20);
            this.txtTencty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên công ty";
            // 
            // btnUpdateCty
            // 
            this.btnUpdateCty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateCty.Location = new System.Drawing.Point(196, 273);
            this.btnUpdateCty.Name = "btnUpdateCty";
            this.btnUpdateCty.Size = new System.Drawing.Size(75, 21);
            this.btnUpdateCty.TabIndex = 9;
            this.btnUpdateCty.Text = "Sửa";
            this.btnUpdateCty.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCty
            // 
            this.btnDeleteCty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteCty.Location = new System.Drawing.Point(32, 273);
            this.btnDeleteCty.Name = "btnDeleteCty";
            this.btnDeleteCty.Size = new System.Drawing.Size(75, 21);
            this.btnDeleteCty.TabIndex = 10;
            this.btnDeleteCty.Text = "Xoá";
            this.btnDeleteCty.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteCty);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnUpdateCty);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.dataCty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(513, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 21);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dataCty
            // 
            this.dataCty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCT,
            this.DiaChi,
            this.Nganhnghe,
            this.Lienhe});
            this.dataCty.Location = new System.Drawing.Point(16, 93);
            this.dataCty.Name = "dataCty";
            this.dataCty.Size = new System.Drawing.Size(439, 150);
            this.dataCty.TabIndex = 1;
            // 
            // NameCT
            // 
            this.NameCT.HeaderText = "Tên công ty";
            this.NameCT.Name = "NameCT";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Nganhnghe
            // 
            this.Nganhnghe.HeaderText = "Ngành nghề";
            this.Nganhnghe.Name = "Nganhnghe";
            // 
            // Lienhe
            // 
            this.Lienhe.HeaderText = "Liên hệ";
            this.Lienhe.Name = "Lienhe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(111, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách công ty";
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompany";
            this.Text = "Company";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNganhnghe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTencty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCty;
        private System.Windows.Forms.Button btnUpdateCty;
        private System.Windows.Forms.Button btnAddCty;
        private System.Windows.Forms.TextBox txtLienhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataCty;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nganhnghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lienhe;
    }
}