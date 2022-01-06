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
    public partial class frmSanpham : Form
    {
        public frmSanpham()
        {
            InitializeComponent();
        }
        DataTable tblSP;
        private void loadDataToGridView()
        {
            string sql = "select * from tblSanpham";
            DataTable tableTV = functions.GetDataToTable(sql);
            dgvDMSanpham.DataSource = tableTV;
            dgvDMSanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void frmSanpham_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblSanpham";
            functions.Connect();
            txtMasp.Enabled = false;
            btnDong.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            loadDataToGridView();
            functions.FIllcombo("SELECT Maloai FROM tblLoai", cboMaloai, "Maloai", "Maloai");
            cboMaloai.SelectedIndex = -1;
            functions.FIllcombo("SELECT MaMH FROM tblManhinh", cboMamanhinh, "MaMH", "MaMH");
            cboMamanhinh.SelectedIndex = -1;
            functions.FIllcombo("SELECT Manhanhieu FROM tblNhanhieu", cboManhanhieu, "Manhanhieu", "Manhanhieu");
            cboManhanhieu.SelectedIndex = -1;          
            ResetValues();
        }
        private void ResetValues()
        {
            txtMasp.Text = "";
            txtTensp.Text = "";
            cboMaloai.SelectedItem = null;
            cboMamanhinh.SelectedItem = null;
            cboManhanhieu.SelectedItem = null;
            txtSoluong.Text = "";
            txtDongianhap.Text = "";
            txtDongiaban.Text = "";
            txtThoigianBH.Text = "";
        }

        private void dgvDMSanpham_Click(object sender, EventArgs e)
        {
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasp.Focus();
                return;
            }
            txtMasp.Text = dgvDMSanpham.CurrentRow.Cells[0].Value.ToString();
            txtTensp.Text = dgvDMSanpham.CurrentRow.Cells[1].Value.ToString();
            cboMaloai.Text = dgvDMSanpham.CurrentRow.Cells[2].Value.ToString();
            cboMamanhinh.Text = dgvDMSanpham.CurrentRow.Cells[3].Value.ToString();
            cboManhanhieu.Text = dgvDMSanpham.CurrentRow.Cells[4].Value.ToString();        
            txtSoluong.Text = dgvDMSanpham.CurrentRow.Cells[5].Value.ToString();
            txtDongianhap.Text = dgvDMSanpham.CurrentRow.Cells[6].Value.ToString();
            txtDongiaban.Text = dgvDMSanpham.CurrentRow.Cells[8].Value.ToString();
            txtThoigianBH.Text = dgvDMSanpham.CurrentRow.Cells[9].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            txtTensp.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMasp.Enabled = false;
            txtMasp.Focus();
            ResetValues();
            loadDataToGridView();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMasp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasp.Focus();
                return;
            }
            if (txtTensp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTensp.Focus();
                return;
            }
            if (cboMaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaloai.Focus();
                return;
            }
            if (cboMamanhinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMamanhinh.Focus();
                return;
            }
            if (cboManhanhieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhãn hiệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboManhanhieu.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;
            }
            if (txtDongianhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongianhap.Focus();
                return;
            }
            if (txtDongiaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongiaban.Focus();
                return;
            }
            if (txtThoigianBH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thời gian bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThoigianBH.Focus();
                return;
            }
            sql = "UPDATE tblSanpham SET TenSP = N'" + txtTensp.Text.Trim().ToString() + 
            "',Maloai = N'" + cboMaloai.SelectedValue.ToString() +
            "',Manhanhieu=N'" + cboManhanhieu.SelectedValue.ToString() +
            "',Gianhap = N'" + txtDongianhap.Text.Trim().ToString() +
            "',Giaban = N'" + txtDongiaban.Text.Trim().ToString() +
            "',Soluong = N'" + txtSoluong.Text.Trim().ToString() +
            "',Thoigiannaohanh = N'" + txtThoigianBH.Text.Trim().ToString() +
            "',MaMH = N'" + cboMamanhinh.SelectedValue.ToString() + 
            "'WHERE Masp = N'" + txtMasp.Text + "'";
            functions.Runsql(sql);
            loadDataToGridView();
            ResetValues();
            btnHuy.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Câu 3: Giá bán trong bảng DM bình ga được tự động cập nhật = 110% giá nhập.
        private void txtDongianhap_TextChanged(object sender, EventArgs e)
        {
            double gianhap = 0, giaxuat;

            if (txtDongianhap.Text == "")
            {
                gianhap = 0;
            }
            else
            {
                gianhap = Convert.ToDouble(txtDongianhap.Text);
            }
            giaxuat = Math.Round(gianhap * 110 / 100, 2);
            txtDongiaban.Text = giaxuat.ToString();
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
