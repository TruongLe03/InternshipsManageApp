namespace InternshipsManageApp.Forms
{
    partial class FormInternship
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
            this.dataGridViewthuctap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntiemkiemtt = new System.Windows.Forms.Button();
            this.btnAddthuctap = new System.Windows.Forms.Button();
            this.txtEndtime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStarttime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTendot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthuctap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewthuctap
            // 
            this.dataGridViewthuctap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewthuctap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewthuctap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewthuctap.Location = new System.Drawing.Point(212, 196);
            this.dataGridViewthuctap.Name = "dataGridViewthuctap";
            this.dataGridViewthuctap.RowHeadersWidth = 62;
            this.dataGridViewthuctap.RowTemplate.Height = 28;
            this.dataGridViewthuctap.Size = new System.Drawing.Size(514, 168);
            this.dataGridViewthuctap.TabIndex = 21;
            this.dataGridViewthuctap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewthuctap_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnAddthuctap);
            this.panel1.Controls.Add(this.txtEndtime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStarttime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTendot);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 420);
            this.panel1.TabIndex = 20;
            // 
            // btntiemkiemtt
            // 
            this.btntiemkiemtt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntiemkiemtt.Location = new System.Drawing.Point(631, 73);
            this.btntiemkiemtt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntiemkiemtt.Name = "btntiemkiemtt";
            this.btntiemkiemtt.Size = new System.Drawing.Size(80, 23);
            this.btntiemkiemtt.TabIndex = 34;
            this.btntiemkiemtt.Text = "Tìm kiếm";
            this.btntiemkiemtt.UseVisualStyleBackColor = true;
            // 
            // btnAddthuctap
            // 
            this.btnAddthuctap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddthuctap.Location = new System.Drawing.Point(38, 252);
            this.btnAddthuctap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddthuctap.Name = "btnAddthuctap";
            this.btnAddthuctap.Size = new System.Drawing.Size(55, 23);
            this.btnAddthuctap.TabIndex = 33;
            this.btnAddthuctap.Text = "Thêm";
            this.btnAddthuctap.UseVisualStyleBackColor = true;
            this.btnAddthuctap.Click += new System.EventHandler(this.btnAddthuctap_Click);
            // 
            // txtEndtime
            // 
            this.txtEndtime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndtime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEndtime.Location = new System.Drawing.Point(15, 199);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.Size = new System.Drawing.Size(135, 22);
            this.txtEndtime.TabIndex = 32;
            this.txtEndtime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndtime_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // txtStarttime
            // 
            this.txtStarttime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStarttime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStarttime.Location = new System.Drawing.Point(15, 157);
            this.txtStarttime.Name = "txtStarttime";
            this.txtStarttime.Size = new System.Drawing.Size(135, 22);
            this.txtStarttime.TabIndex = 30;
            this.txtStarttime.TextChanged += new System.EventHandler(this.txtStarttime_TextChanged);
            this.txtStarttime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStarttime_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // txtTendot
            // 
            this.txtTendot.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTendot.Location = new System.Drawing.Point(15, 116);
            this.txtTendot.Name = "txtTendot";
            this.txtTendot.Size = new System.Drawing.Size(135, 22);
            this.txtTendot.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên đợt";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(380, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(295, 372);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnxoa.Location = new System.Drawing.Point(213, 372);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(55, 23);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(376, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Danh sách các đợt thực tập";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 20);
            this.textBox1.TabIndex = 35;
            // 
            // FormInternship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 420);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btntiemkiemtt);
            this.Controls.Add(this.dataGridViewthuctap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInternship";
            this.Text = "Đợt thực tập";
            this.Load += new System.EventHandler(this.FormInternship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthuctap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddthuctap;
        private System.Windows.Forms.TextBox txtEndtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStarttime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTendot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntiemkiemtt;
        private System.Windows.Forms.DataGridView dataGridViewthuctap;
        private System.Windows.Forms.TextBox textBox1;
    }
}