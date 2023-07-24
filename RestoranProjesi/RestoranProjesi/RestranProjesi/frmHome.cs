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
    public partial class frmHome : Form
    {
        public static readonly string con_string = "server=localHost; port=5432; Database=RestoranProjesi; user ID=postgres; password=Lio3038$$; ";
        public static NpgsqlConnection conn;
        private string sql;
        private string sql2;
        private string sql3;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex;
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(con_string);
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_selectAnatabak()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataAnatabak.DataSource = null;
                dgvDataAnatabak.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERORR, " + ex.Message);
            }

            try
            {
                conn.Open();
                sql2 = @"SELECT * FROM st_selectSalata()";
                cmd = new NpgsqlCommand(sql2, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataSalata.DataSource = null;
                dgvDataSalata.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERORR, " + ex.Message);
            }

            try
            {
                conn.Open();
                sql3 = @"SELECT * FROM st_selectIcecek()";
                cmd = new NpgsqlCommand(sql3, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataIcecek.DataSource = null;
                dgvDataIcecek.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERORR, " + ex.Message);
            }
        }

        private void dgvDataSalata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDataIcecek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDataAnatabak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
