
namespace BT01_Mo_hinh_ngat_ket_noi_Sinh_vien
{
    partial class Form1
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
            this.lblSTT = new System.Windows.Forms.Label();
            this.cbokhoa = new System.Windows.Forms.ComboBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnkhong = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.txttongdiem = new System.Windows.Forms.TextBox();
            this.txthocbong = new System.Windows.Forms.TextBox();
            this.txtnoisinh = new System.Windows.Forms.TextBox();
            this.txthosv = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.chkphai = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(107, 216);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(36, 17);
            this.lblSTT.TabIndex = 31;
            this.lblSTT.Text = "STT";
            // 
            // cbokhoa
            // 
            this.cbokhoa.FormattingEnabled = true;
            this.cbokhoa.Location = new System.Drawing.Point(326, 145);
            this.cbokhoa.Name = "cbokhoa";
            this.cbokhoa.Size = new System.Drawing.Size(206, 25);
            this.cbokhoa.TabIndex = 30;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaysinh.Location = new System.Drawing.Point(326, 115);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(206, 24);
            this.dtpngaysinh.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "DANH SÁCH SINH VIÊN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnkhong
            // 
            this.btnkhong.Location = new System.Drawing.Point(462, 207);
            this.btnkhong.Name = "btnkhong";
            this.btnkhong.Size = new System.Drawing.Size(70, 34);
            this.btnkhong.TabIndex = 27;
            this.btnkhong.Text = "Không";
            this.btnkhong.UseVisualStyleBackColor = true;
            this.btnkhong.Click += new System.EventHandler(this.btnkhong_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(388, 207);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(67, 34);
            this.btnghi.TabIndex = 26;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnsau
            // 
            this.btnsau.Location = new System.Drawing.Point(172, 207);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(67, 34);
            this.btnsau.TabIndex = 25;
            this.btnsau.Text = "Sau";
            this.btnsau.UseVisualStyleBackColor = true;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(316, 207);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(67, 34);
            this.btnhuy.TabIndex = 24;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btntruoc
            // 
            this.btntruoc.Location = new System.Drawing.Point(9, 207);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(67, 34);
            this.btntruoc.TabIndex = 23;
            this.btntruoc.Text = "Trước";
            this.btntruoc.UseVisualStyleBackColor = true;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(244, 207);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(67, 34);
            this.btnthem.TabIndex = 22;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(447, 84);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(85, 24);
            this.txttensv.TabIndex = 21;
            // 
            // txttongdiem
            // 
            this.txttongdiem.Location = new System.Drawing.Point(326, 176);
            this.txttongdiem.Name = "txttongdiem";
            this.txttongdiem.Size = new System.Drawing.Size(206, 24);
            this.txttongdiem.TabIndex = 20;
            // 
            // txthocbong
            // 
            this.txthocbong.Location = new System.Drawing.Point(95, 176);
            this.txthocbong.Name = "txthocbong";
            this.txthocbong.Size = new System.Drawing.Size(137, 24);
            this.txthocbong.TabIndex = 19;
            // 
            // txtnoisinh
            // 
            this.txtnoisinh.Location = new System.Drawing.Point(95, 147);
            this.txtnoisinh.Name = "txtnoisinh";
            this.txtnoisinh.Size = new System.Drawing.Size(137, 24);
            this.txtnoisinh.TabIndex = 18;
            // 
            // txthosv
            // 
            this.txthosv.Location = new System.Drawing.Point(95, 84);
            this.txthosv.Name = "txthosv";
            this.txthosv.Size = new System.Drawing.Size(346, 24);
            this.txthosv.TabIndex = 17;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(95, 55);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.ReadOnly = true;
            this.txtmasv.Size = new System.Drawing.Size(437, 24);
            this.txtmasv.TabIndex = 16;
            // 
            // chkphai
            // 
            this.chkphai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkphai.Location = new System.Drawing.Point(9, 117);
            this.chkphai.Name = "chkphai";
            this.chkphai.Size = new System.Drawing.Size(100, 22);
            this.chkphai.TabIndex = 15;
            this.chkphai.Text = "Phái";
            this.chkphai.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng điểm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Học bổng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nơi sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Họ tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã SV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(597, 371);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.cbokhoa);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnkhong);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnsau);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btntruoc);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttensv);
            this.Controls.Add(this.txttongdiem);
            this.Controls.Add(this.txthocbong);
            this.Controls.Add(this.txtnoisinh);
            this.Controls.Add(this.txthosv);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.chkphai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô hình ngắt kết nối Sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.ComboBox cbokhoa;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnkhong;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.TextBox txttongdiem;
        private System.Windows.Forms.TextBox txthocbong;
        private System.Windows.Forms.TextBox txtnoisinh;
        private System.Windows.Forms.TextBox txthosv;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.CheckBox chkphai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

