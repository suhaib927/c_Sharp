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

namespace RestranProjesi
{
    public partial class frmPersonal : Form
    {
        public static readonly string con_string = "server=localHost; port=5432; Database=RestoranProjesi; user ID=postgres; password=Lio3038$$; ";
        public static NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex;

        public frmPersonal()
        {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(con_string);
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM Personel.st_selectGarson()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataPersonal.DataSource = null;
                dgvDataPersonal.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("HATA, " + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            txtAdi.Enabled = txtAdres.Enabled = txtMaas.Enabled = comTuru.Enabled = txtSoyadi.Enabled = txtTelefon.Enabled = true;
            txtAdi.Text = txtAdres.Text = txtMaas.Text = comTuru.Text = txtSoyadi.Text = txtTelefon.Text = null;
            txtAdi.Select();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM Personel.st_insertPersonal(:_adi, :_soyadi, :_personalTipi, :_maas)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_adi", txtAdi.Text);
                    cmd.Parameters.AddWithValue("_soyadi", txtSoyadi.Text);
                    cmd.Parameters.AddWithValue("_personalTipi", comTuru.Text);
                    cmd.Parameters.AddWithValue("_maas", txtMaas.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Personal ekleme işlemi başariyla eklenmiş");

                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Ekleme hatasi");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Ekleme işlemi hatasi, " + ex.Message);
                }
            }
            result = 0;
            txtAdi.Text = txtAdres.Text = txtMaas.Text = comTuru.Text = txtSoyadi.Text = txtTelefon.Text = null;
            txtAdi.Enabled = txtAdres.Enabled = txtMaas.Enabled = comTuru.Enabled = txtSoyadi.Enabled = txtTelefon.Enabled = false;
        }
    }
}
