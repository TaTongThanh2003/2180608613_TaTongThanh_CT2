namespace _2180608613_TaTongThanh_CT2
{
    partial class DentalPaymentForm
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
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.ckbCaovoi = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.grbDV = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ckbCHrang = new System.Windows.Forms.CheckBox();
            this.ckbTaytrang = new System.Windows.Forms.CheckBox();
            this.nudTramRang = new System.Windows.Forms.NumericUpDown();
            this.lblTramrang = new System.Windows.Forms.Label();
            this.lblGiaTramRang = new System.Windows.Forms.Label();
            this.lblCHRang = new System.Windows.Forms.Label();
            this.lblGiaTayTRang = new System.Windows.Forms.Label();
            this.lblGiaCV = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblBaCham = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.clHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSuaGia = new System.Windows.Forms.Button();
            this.grbDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(1, 62);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(204, 25);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "TÊN KHÁCH HÀNG";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.Red;
            this.txtTenKH.Location = new System.Drawing.Point(266, 51);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(306, 36);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKH_KeyPress);
            // 
            // ckbCaovoi
            // 
            this.ckbCaovoi.AllowDrop = true;
            this.ckbCaovoi.AutoSize = true;
            this.ckbCaovoi.ForeColor = System.Drawing.Color.Blue;
            this.ckbCaovoi.Location = new System.Drawing.Point(19, 73);
            this.ckbCaovoi.Name = "ckbCaovoi";
            this.ckbCaovoi.Size = new System.Drawing.Size(108, 29);
            this.ckbCaovoi.TabIndex = 2;
            this.ckbCaovoi.Text = "Cạo vôi";
            this.ckbCaovoi.UseVisualStyleBackColor = true;
            this.ckbCaovoi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.Blue;
            this.btnTinhTien.Location = new System.Drawing.Point(44, 454);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(151, 51);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // grbDV
            // 
            this.grbDV.Controls.Add(this.button3);
            this.grbDV.Controls.Add(this.ckbCHrang);
            this.grbDV.Controls.Add(this.ckbTaytrang);
            this.grbDV.Controls.Add(this.nudTramRang);
            this.grbDV.Controls.Add(this.lblTramrang);
            this.grbDV.Controls.Add(this.lblGiaTramRang);
            this.grbDV.Controls.Add(this.ckbCaovoi);
            this.grbDV.Controls.Add(this.lblCHRang);
            this.grbDV.Controls.Add(this.lblGiaTayTRang);
            this.grbDV.Controls.Add(this.lblGiaCV);
            this.grbDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDV.Location = new System.Drawing.Point(12, 113);
            this.grbDV.Name = "grbDV";
            this.grbDV.Size = new System.Drawing.Size(593, 240);
            this.grbDV.TabIndex = 5;
            this.grbDV.TabStop = false;
            this.grbDV.Text = "DỊCH VỤ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ckbCHrang
            // 
            this.ckbCHrang.AutoSize = true;
            this.ckbCHrang.Location = new System.Drawing.Point(19, 133);
            this.ckbCHrang.Name = "ckbCHrang";
            this.ckbCHrang.Size = new System.Drawing.Size(182, 29);
            this.ckbCHrang.TabIndex = 2;
            this.ckbCHrang.Text = "Chụp hình răng";
            this.ckbCHrang.UseVisualStyleBackColor = true;
            // 
            // ckbTaytrang
            // 
            this.ckbTaytrang.AutoSize = true;
            this.ckbTaytrang.Location = new System.Drawing.Point(19, 103);
            this.ckbTaytrang.Name = "ckbTaytrang";
            this.ckbTaytrang.Size = new System.Drawing.Size(126, 29);
            this.ckbTaytrang.TabIndex = 2;
            this.ckbTaytrang.Text = "Tẩy trắng";
            this.ckbTaytrang.UseVisualStyleBackColor = true;
            // 
            // nudTramRang
            // 
            this.nudTramRang.Location = new System.Drawing.Point(177, 177);
            this.nudTramRang.Name = "nudTramRang";
            this.nudTramRang.Size = new System.Drawing.Size(135, 30);
            this.nudTramRang.TabIndex = 3;
            this.nudTramRang.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblTramrang
            // 
            this.lblTramrang.AutoSize = true;
            this.lblTramrang.Location = new System.Drawing.Point(7, 182);
            this.lblTramrang.Name = "lblTramrang";
            this.lblTramrang.Size = new System.Drawing.Size(111, 25);
            this.lblTramrang.TabIndex = 0;
            this.lblTramrang.Text = "Trám răng";
            // 
            // lblGiaTramRang
            // 
            this.lblGiaTramRang.AutoSize = true;
            this.lblGiaTramRang.Location = new System.Drawing.Point(428, 182);
            this.lblGiaTramRang.Name = "lblGiaTramRang";
            this.lblGiaTramRang.Size = new System.Drawing.Size(113, 25);
            this.lblGiaTramRang.TabIndex = 0;
            this.lblGiaTramRang.Text = "80.000/cái";
            // 
            // lblCHRang
            // 
            this.lblCHRang.AutoSize = true;
            this.lblCHRang.Location = new System.Drawing.Point(428, 133);
            this.lblCHRang.Name = "lblCHRang";
            this.lblCHRang.Size = new System.Drawing.Size(90, 25);
            this.lblCHRang.TabIndex = 0;
            this.lblCHRang.Text = "200.000";
            // 
            // lblGiaTayTRang
            // 
            this.lblGiaTayTRang.AutoSize = true;
            this.lblGiaTayTRang.Location = new System.Drawing.Point(428, 103);
            this.lblGiaTayTRang.Name = "lblGiaTayTRang";
            this.lblGiaTayTRang.Size = new System.Drawing.Size(108, 25);
            this.lblGiaTayTRang.TabIndex = 0;
            this.lblGiaTayTRang.Text = "1.200.000";
            // 
            // lblGiaCV
            // 
            this.lblGiaCV.AutoSize = true;
            this.lblGiaCV.Location = new System.Drawing.Point(428, 73);
            this.lblGiaCV.Name = "lblGiaCV";
            this.lblGiaCV.Size = new System.Drawing.Size(90, 25);
            this.lblGiaCV.TabIndex = 0;
            this.lblGiaCV.Text = "100.000";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(281, 454);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 51);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(99, 409);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(89, 16);
            this.lbltongtien.TabIndex = 0;
            this.lbltongtien.Text = "TỔNG TIỀN";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 823);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblBaCham
            // 
            this.lblBaCham.AutoSize = true;
            this.lblBaCham.Location = new System.Drawing.Point(315, 409);
            this.lblBaCham.Name = "lblBaCham";
            this.lblBaCham.Size = new System.Drawing.Size(75, 16);
            this.lblBaCham.TabIndex = 0;
            this.lblBaCham.Text = ".................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "DENTAL PAYMENT FORM";
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clHoTen,
            this.clTongTien});
            this.lsvDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(644, 113);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(776, 458);
            this.lsvDanhSach.TabIndex = 6;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // clHoTen
            // 
            this.clHoTen.Text = "Họ Tên";
            this.clHoTen.Width = 294;
            // 
            // clTongTien
            // 
            this.clTongTien.Text = "Tổng Tiền";
            this.clTongTien.Width = 315;
            // 
            // btnSuaGia
            // 
            this.btnSuaGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGia.Location = new System.Drawing.Point(44, 525);
            this.btnSuaGia.Name = "btnSuaGia";
            this.btnSuaGia.Size = new System.Drawing.Size(144, 50);
            this.btnSuaGia.TabIndex = 7;
            this.btnSuaGia.Text = "Sửa Giá";
            this.btnSuaGia.UseVisualStyleBackColor = true;
            this.btnSuaGia.Click += new System.EventHandler(this.button1_Click);
            // 
            // DentalPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 587);
            this.Controls.Add(this.btnSuaGia);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grbDV);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBaCham);
            this.Controls.Add(this.lblTenKH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "DentalPaymentForm";
            this.Text = "DentalPaymentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DentalPaymentForm_FormClosed);
            this.Load += new System.EventHandler(this.DentalPaymentForm_Load);
            this.grbDV.ResumeLayout(false);
            this.grbDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.CheckBox ckbCaovoi;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.GroupBox grbDV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ckbCHrang;
        private System.Windows.Forms.CheckBox ckbTaytrang;
        private System.Windows.Forms.NumericUpDown nudTramRang;
        private System.Windows.Forms.Label lblGiaTramRang;
        private System.Windows.Forms.Label lblCHRang;
        private System.Windows.Forms.Label lblGiaTayTRang;
        private System.Windows.Forms.Label lblGiaCV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblBaCham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTramrang;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader clHoTen;
        private System.Windows.Forms.ColumnHeader clTongTien;
        private System.Windows.Forms.Button btnSuaGia;
    }
}