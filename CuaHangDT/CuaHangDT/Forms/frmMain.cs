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

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            f.Show();
         
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            functions.Connect();
        }

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
    }
}
