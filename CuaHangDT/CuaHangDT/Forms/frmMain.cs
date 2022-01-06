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

<<<<<<< HEAD
        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadonban a = new frmHoadonban();
            a.Show();
=======
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            f.Show();
         
>>>>>>> 77cc465dafd1da7d91a5d8a2f0e4da47680b7218
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            functions.Connect();
        }
<<<<<<< HEAD
=======

        private void quêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQue f=new frmQue();
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhacungcap f=new frmNhacungcap();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            functions.Disconnect();
            Application.Exit();
        }
>>>>>>> 77cc465dafd1da7d91a5d8a2f0e4da47680b7218
    }
}
