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
    public partial class frmFatura : Form
    {
        public static readonly string con_string = "server=localHost; port=5432; Database=RestoranProjesi; user ID=postgres; password=Lio3038$$; ";
        public static NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex;

        public frmFatura()
        {
            InitializeComponent();
        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(con_string);
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_selectFaturalar()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvFatura.DataSource = null;
                dgvFatura.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERORR, " + ex.Message);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDataAnatabak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDataAnatabak_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
