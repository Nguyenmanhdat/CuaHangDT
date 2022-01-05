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


        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKhachhang kh=new frmKhachhang();
            kh.ShowDialog();
        }

        private void quêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQue q =new frmQue();
            q.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            functions.Connect();
        }

        private void nhãnHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanhieu NH = new frmNhanhieu();
            NH.ShowDialog();
        }

        private void tìmHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemHDB hoadonban = new frmTimkiemHDB();
            hoadonban.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
