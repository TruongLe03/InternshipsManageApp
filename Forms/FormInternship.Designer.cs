﻿namespace InternshipsManageApp.Forms
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colStt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTendot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStarttime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdđot = new System.Windows.Forms.Button();
            this.txtEndtime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStarttime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTendot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStt,
            this.colTendot,
            this.colStarttime,
            this.colEndtime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(175, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(451, 152);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colStt
            // 
            this.colStt.Text = "STT";
            this.colStt.Width = 74;
            // 
            // colTendot
            // 
            this.colTendot.Text = "Tên đợt";
            this.colTendot.Width = 100;
            // 
            // colStarttime
            // 
            this.colStarttime.Text = "Thời gian bắt đầu";
            this.colStarttime.Width = 167;
            // 
            // colEndtime
            // 
            this.colEndtime.Text = "Thời gian kêt thúc";
            this.colEndtime.Width = 182;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(576, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(407, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(307, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(209, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(295, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Danh sách các đợt thực tập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAdđot);
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
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(77, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAdđot
            // 
            this.btnAdđot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdđot.Location = new System.Drawing.Point(15, 212);
            this.btnAdđot.Name = "btnAdđot";
            this.btnAdđot.Size = new System.Drawing.Size(50, 23);
            this.btnAdđot.TabIndex = 33;
            this.btnAdđot.Text = "Thêm";
            this.btnAdđot.UseVisualStyleBackColor = true;
            // 
            // txtEndtime
            // 
            this.txtEndtime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndtime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEndtime.Location = new System.Drawing.Point(15, 176);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.Size = new System.Drawing.Size(135, 22);
            this.txtEndtime.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // txtStarttime
            // 
            this.txtStarttime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStarttime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStarttime.Location = new System.Drawing.Point(15, 134);
            this.txtStarttime.Name = "txtStarttime";
            this.txtStarttime.Size = new System.Drawing.Size(135, 22);
            this.txtStarttime.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // txtTendot
            // 
            this.txtTendot.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTendot.Location = new System.Drawing.Point(15, 93);
            this.txtTendot.Name = "txtTendot";
            this.txtTendot.Size = new System.Drawing.Size(135, 22);
            this.txtTendot.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên đợt";
            // 
            // FormInternship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInternship";
            this.Text = "Đợt thực tập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colStt;
        private System.Windows.Forms.ColumnHeader colTendot;
        private System.Windows.Forms.ColumnHeader colStarttime;
        private System.Windows.Forms.ColumnHeader colEndtime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdđot;
        private System.Windows.Forms.TextBox txtEndtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStarttime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTendot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}