﻿namespace QLPhongTro.ChildForm
{
    partial class frmThuePhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThuePhong = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienVeSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienMang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSD_Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSN_Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý khách thuê phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvThuePhong
            // 
            this.dgvThuePhong.AllowUserToAddRows = false;
            this.dgvThuePhong.AllowUserToDeleteRows = false;
            this.dgvThuePhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuePhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnThanhToan,
            this.TenPhong,
            this.GiaPhong,
            this.DatCoc,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TienVeSinh,
            this.TienMang,
            this.DonGiaDien,
            this.CSD_Cu,
            this.DonGiaNuoc,
            this.CSN_Cu,
            this.no,
            this.ID});
            this.dgvThuePhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvThuePhong.Location = new System.Drawing.Point(4, 141);
            this.dgvThuePhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThuePhong.MultiSelect = false;
            this.dgvThuePhong.Name = "dgvThuePhong";
            this.dgvThuePhong.ReadOnly = true;
            this.dgvThuePhong.RowHeadersWidth = 62;
            this.dgvThuePhong.Size = new System.Drawing.Size(1573, 320);
            this.dgvThuePhong.TabIndex = 2;
            this.dgvThuePhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuePhong_CellClick);
            this.dgvThuePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuePhong_CellContentClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.HeaderText = "";
            this.btnThanhToan.MinimumWidth = 8;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ReadOnly = true;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseColumnTextForButtonValue = true;
            this.btnThanhToan.Width = 150;
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 8;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.GiaPhong.DefaultCellStyle = dataGridViewCellStyle10;
            this.GiaPhong.HeaderText = "Giá phòng";
            this.GiaPhong.MinimumWidth = 8;
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.ReadOnly = true;
            this.GiaPhong.Width = 150;
            // 
            // DatCoc
            // 
            this.DatCoc.DataPropertyName = "DatCoc";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DatCoc.DefaultCellStyle = dataGridViewCellStyle11;
            this.DatCoc.HeaderText = "Đặt cọc";
            this.DatCoc.MinimumWidth = 8;
            this.DatCoc.Name = "DatCoc";
            this.DatCoc.ReadOnly = true;
            this.DatCoc.Width = 150;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày thuê";
            this.NgayBatDau.MinimumWidth = 8;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            this.NgayBatDau.Width = 150;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày trả";
            this.NgayKetThuc.MinimumWidth = 8;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            this.NgayKetThuc.Width = 150;
            // 
            // TienVeSinh
            // 
            this.TienVeSinh.DataPropertyName = "TienVeSinh";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TienVeSinh.DefaultCellStyle = dataGridViewCellStyle12;
            this.TienVeSinh.HeaderText = "Tiền vệ sinh";
            this.TienVeSinh.MinimumWidth = 8;
            this.TienVeSinh.Name = "TienVeSinh";
            this.TienVeSinh.ReadOnly = true;
            this.TienVeSinh.Width = 150;
            // 
            // TienMang
            // 
            this.TienMang.DataPropertyName = "TienMang";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = "0";
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TienMang.DefaultCellStyle = dataGridViewCellStyle13;
            this.TienMang.HeaderText = "Tiền mạng";
            this.TienMang.MinimumWidth = 8;
            this.TienMang.Name = "TienMang";
            this.TienMang.ReadOnly = true;
            this.TienMang.Width = 150;
            // 
            // DonGiaDien
            // 
            this.DonGiaDien.DataPropertyName = "DonGiaDien";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = "0";
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DonGiaDien.DefaultCellStyle = dataGridViewCellStyle14;
            this.DonGiaDien.HeaderText = "Đơn giá điện";
            this.DonGiaDien.MinimumWidth = 8;
            this.DonGiaDien.Name = "DonGiaDien";
            this.DonGiaDien.ReadOnly = true;
            this.DonGiaDien.Width = 150;
            // 
            // CSD_Cu
            // 
            this.CSD_Cu.DataPropertyName = "CSD_Cu";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = "0";
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CSD_Cu.DefaultCellStyle = dataGridViewCellStyle15;
            this.CSD_Cu.HeaderText = "CSĐ cũ";
            this.CSD_Cu.MinimumWidth = 8;
            this.CSD_Cu.Name = "CSD_Cu";
            this.CSD_Cu.ReadOnly = true;
            this.CSD_Cu.Width = 150;
            // 
            // DonGiaNuoc
            // 
            this.DonGiaNuoc.DataPropertyName = "DonGiaNuoc";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = "0";
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DonGiaNuoc.DefaultCellStyle = dataGridViewCellStyle16;
            this.DonGiaNuoc.HeaderText = "Đơn giá nước";
            this.DonGiaNuoc.MinimumWidth = 8;
            this.DonGiaNuoc.Name = "DonGiaNuoc";
            this.DonGiaNuoc.ReadOnly = true;
            this.DonGiaNuoc.Width = 150;
            // 
            // CSN_Cu
            // 
            this.CSN_Cu.DataPropertyName = "CSN_Cu";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = "0";
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CSN_Cu.DefaultCellStyle = dataGridViewCellStyle17;
            this.CSN_Cu.HeaderText = "Số nước cũ";
            this.CSN_Cu.MinimumWidth = 8;
            this.CSN_Cu.Name = "CSN_Cu";
            this.CSN_Cu.ReadOnly = true;
            this.CSN_Cu.Width = 150;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = "0";
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.no.DefaultCellStyle = dataGridViewCellStyle18;
            this.no.HeaderText = "Dư nợ";
            this.no.MinimumWidth = 8;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(456, 94);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thuê mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(100, 98);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(239, 23);
            this.txtTuKhoa.TabIndex = 11;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(348, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1580, 462);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThuePhong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThuePhong";
            this.Text = "frmThuePhong";
            this.Load += new System.EventHandler(this.frmThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThuePhong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewButtonColumn btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienVeSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienMang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSD_Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSN_Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}