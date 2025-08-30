using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThietKeForm;

namespace BaiTapThietKeForm
{
    public partial class Formchinh : Form
    {
        public Formchinh()
        {
            InitializeComponent();
        }

       

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form= new FrmBai1();
            form.ShowDialog();
        }
        private void tmsiBai2_Click(object sender, EventArgs e)
        {
            var form = new FormBai2();
            form.ShowDialog();

        }

        private void tmsiBai3_Click(object sender, EventArgs e)
        {
            var form = new FormBai3();
            form.ShowDialog();
        }
    }
}
