using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tÌmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadonnhap a = new frmHoadonnhap();
            a.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            functions.Connect();
        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManhinh a = new frmManhinh();
            a.Show();

        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoai a = new frmLoai();
            a.Show();
        }
    }
}
