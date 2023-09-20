using DevExpress.XtraTab.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2180608613_TaTongThanh_CT2
{
    public partial class DentalPaymentForm : Form
    {
        public DentalPaymentForm()
        {
            InitializeComponent();
        }
        private String giaCaoVoi;
        private String giaTayTrang;
        private String giaChupHinhRang;
        private String giaTramRang;
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        public bool checkNull()
        {
            if (string.IsNullOrEmpty(txtTenKH.Text) || (ckbCaovoi.Checked == false &&
                ckbCHrang.Checked == false && ckbTaytrang.Checked == false && nudTramRang.Value <= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public float TongTien()
        {
            float Tong = 0, tiencaovoi = 0, tientramrang = 0, tientaytrang = 0, tienchuphinh = 0;
            // Tính tiền cạo vôi
            if (ckbCaovoi.Checked)
            {
                tiencaovoi = float.Parse(lblGiaCV.Text.Replace(".", string.Empty));
            }
            if (ckbCHrang.Checked)
            {
                tienchuphinh = float.Parse(lblCHRang.Text.Replace(".", string.Empty));
            }
            if (ckbTaytrang.Checked)
            {
                tientaytrang = float.Parse(lblGiaTayTRang.Text.Replace(".", string.Empty));
            }

            if (nudTramRang.Value > 0)
            {
                tientramrang = float.Parse(lblGiaTramRang.Text.Replace(".", string.Empty).Replace("/cái", string.Empty));
                int sl = int.Parse(nudTramRang.Value.ToString());
                tientramrang = sl * tientramrang;
            }
            Tong = tiencaovoi + tienchuphinh + tientramrang + tientaytrang;
            return Tong;
        }
        public void ghiThongTin()
        {
            string tenKhachHang = txtTenKH.Text;
            float tienKhachHang = TongTien();
            // Tạo một cờ để kiểm tra xem khách hàng đã tồn tại trong ListView chưa
            bool khachHangDaTonTai = false;

            foreach (ListViewItem item in lsvDanhSach.Items)
            {
                if (item.Text == tenKhachHang)
                {
                    // Nếu tên khách hàng đã tồn tại, cập nhật tổng tiền
                    item.SubItems[1].Text = tienKhachHang.ToString();
                    khachHangDaTonTai = true;
                    break;
                }
            }
            if (!khachHangDaTonTai)
            {
                // Nếu khách hàng chưa tồn tại, thêm một mục mới vào ListView
                ListViewItem item = new ListViewItem(tenKhachHang);
                item.SubItems.Add(tienKhachHang.ToString());
                lsvDanhSach.Items.Add(item);
                ResetForm();
            }
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Chua Nhap Du Thong Tin", "Thong Bao");
            }
            else
            {
                lblBaCham.Text = string.Empty;
                lblBaCham.Text = TongTien().ToString();
                ghiThongTin();
            }
        }
        private List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        private class KhachHang
        {
            public string Ten { get; set; }
            public float TinhTien { get; set; }
        }
        
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvDanhSach.SelectedItems[0];
                txtTenKH.Text = selectedItem.SubItems[0].Text;
                lblBaCham.Text = selectedItem.SubItems[1].Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SuaGiaForm suaGiaForm = new SuaGiaForm();
            if (suaGiaForm.ShowDialog() == DialogResult.OK)
            {
                string updateGiaCaoVoi = suaGiaForm.GiaCaoVoi.ToString();
                lblGiaCV.Text = updateGiaCaoVoi;
                string updateGiaTayTrang = suaGiaForm.GiaTayTrang.ToString();
                lblGiaTayTRang.Text = updateGiaTayTrang;
                string updateGiaCHRang = suaGiaForm.GiaChupHinhRang.ToString();
                lblCHRang.Text = updateGiaCHRang;
                string updateGiaTramRang = suaGiaForm.GiaTramRang.ToString();
                lblGiaTramRang.Text = updateGiaTramRang;

            }
        }
        private void ResetForm()
        {
            txtTenKH.Text = "";
            ckbCaovoi.Checked = false;
            ckbTaytrang.Checked = false;
            ckbCHrang.Checked = false;
            nudTramRang.Value = 0;
            lblBaCham.Text = "";
        }
        private HashSet<string> danhSachTenKhachHang = new HashSet<string>();
        
        private void DentalPaymentForm_Load(object sender, EventArgs e)
        {
          
        }
        private void DentalPaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true; // Không cho phép nhập ký tự số hoặc ký tự đặc biệt
            }
        }
        private List<string> danhSachTenKhachHangTemp = new List<string>();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            danhSachTenKhachHangTemp = danhSachTenKhachHang.ToList();

            // Đóng form hoặc thực hiện các tác vụ khác khi thoát
            this.Close();
        }
    }
 }
