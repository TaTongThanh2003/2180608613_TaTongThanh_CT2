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
    
    public partial class ChillForm : Form
    {
        public ChillForm(string imageFile)
        {
            InitializeComponent();
            ptbHA.Image = Image.FromFile(imageFile);
            Text = imageFile.Substring(imageFile.LastIndexOf('/') + 1);


        }
        public ChillForm()
        {
            InitializeComponent();
        }
         
    }
}
