﻿using System;
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

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadonban a = new frmHoadonban();
            a.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            functions.Connect();
        }
    }
}
