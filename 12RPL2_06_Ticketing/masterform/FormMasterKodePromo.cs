using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12RPL2_06_Ticketing.masterform
{
    public partial class FormMasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FormMasterKodePromo()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO tbl_kode_promo" + "(kode,presentase_diskon,maksimum_diskon,berlaku_sampai,deskripsi)" + "VALUES" + "('" + txtKodePromo.Text + "','" + txtBerlakuSampai.Text + "'," + "'" + txtPresentaseDiskon.Text + "','" + txtMaksimumDiskon.Text + "','" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Kode Promo ");
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
