using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2180608613_TaTongThanh_CT2
{
    public partial class SuaGiaForm : Form
    {
        public SuaGiaForm()
        {
            InitializeComponent();
        }
        private void SuaGiaForm_Load(object sender, EventArgs e)
        {
  }
        public String GiaCaoVoi { get; set; }
        public String GiaTayTrang { get; set; }
        public String GiaChupHinhRang { get; set; }
        public String GiaTramRang { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSuaGiaCaoVoi.Text != "")
            {
                string GiaMoiCaoVoi = txtSuaGiaCaoVoi.Text;
                GiaCaoVoi = GiaMoiCaoVoi;
            }
            else
            {
                GiaCaoVoi = "100.000".ToString();
            }
            if (txtSuaGiaTayTrang.Text != "")
            {
                string GiaMoiTayTrang = txtSuaGiaCaoVoi.Text;
                GiaTayTrang = GiaMoiTayTrang;
            }
            else
            {
                GiaTayTrang = "1.200.000".ToString();
            }
            if (txtSuaGiaCHRang.Text != "")
            {
                string GiaMoiCHRang = txtSuaGiaCHRang.Text;
                GiaChupHinhRang = GiaMoiCHRang;
            }
            else
            {
                GiaChupHinhRang = "200.000".ToString();
            }
            if (txtSuaGiaTramRang.Text != "")
            {
                string GiaMoiTramRang = txtSuaGiaTramRang.Text;
                GiaTramRang = GiaMoiTramRang + "/cái";
            }
            else
            {
                GiaTramRang = "80.000" + "/cái".ToString();
            }
            // Đánh dấu form EditPriceForm là đã hoàn thành thành công
            DialogResult = DialogResult.OK;
        }


        private int dotCount = 0;
        private void txtSuaGiaCaoVoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                // Kiểm tra số lượng dấu chấm đã nhập
                if (dotCount >= 2)
                {
                    e.Handled = true;
                }
                else
                {
                    dotCount++; // Tăng biến đếm số lượng dấu chấm
                }
            }
        }
        private void txtSuaGiaTayTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                // Kiểm tra số lượng dấu chấm đã nhập
                if (dotCount >= 2)
                {
                    e.Handled = true;
                }
                else
                {
                    dotCount++; // Tăng biến đếm số lượng dấu chấm
                }
            }
        }

        private void txtGiaCHRang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                // Kiểm tra số lượng dấu chấm đã nhập
                if (dotCount >= 2)
                {
                    e.Handled = true;
                }
                else
                {
                    dotCount++; // Tăng biến đếm số lượng dấu chấm
                }
            }

        }

        private void txtGiaTramRang_TextChanged(object sender, EventArgs e)
        {
            dotCount = ((TextBox)sender).Text.Count(c => c == '.');
        }

        private void txtSuaGiaCaoVoi_TextChanged(object sender, EventArgs e)
        {
            dotCount = ((TextBox)sender).Text.Count(c => c == '.');
        }

        private void txtSuaGiaTayTrang_TextChanged(object sender, EventArgs e)
        {
            dotCount = ((TextBox)sender).Text.Count(c => c == '.');
        }

        private void txtGiaCHRang_TextChanged(object sender, EventArgs e)
        {
            dotCount = ((TextBox)sender).Text.Count(c => c == '.');
        }

        private void txtGiaTramRang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                // Kiểm tra số lượng dấu chấm đã nhập
                if (dotCount >= 2)
                {
                    e.Handled = true;
                }
                else
                {
                    dotCount++; // Tăng biến đếm số lượng dấu chấm
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaGiaForm_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
