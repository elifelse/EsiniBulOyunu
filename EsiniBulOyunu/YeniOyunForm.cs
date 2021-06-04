using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBulOyunu
{
    public partial class YeniOyunForm : Form
    {
        public YeniOyunForm()
        {
            InitializeComponent();
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            ZorlukSeviye zs = rbKolay.Checked ? ZorlukSeviye.Kolay :
                (rbOrta.Checked ? ZorlukSeviye.Orta : ZorlukSeviye.Zor);
            Hide();
            Form1 frmOyun = new Form1(zs);
            // bu formu, frmOyun formunun Owner'ı yap
            frmOyun.Show(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
