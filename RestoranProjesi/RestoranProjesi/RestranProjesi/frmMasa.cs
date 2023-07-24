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
    public partial class frmMasa : Form
    {
        public static readonly string con_string = "server=localHost; port=5432; Database=RestoranProjesi; user ID=postgres; password=Lio3038$$; ";
        public static NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex;
        public frmMasa()
        {
            InitializeComponent();
        }

        private void frmMasa_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(con_string);
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvData.DataSource = null;
                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("HATA, " + ex.Message);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtAdi.Text = dgvData.Rows[e.RowIndex].Cells["_urunadi"].Value.ToString();
                txtTuru.Text = dgvData.Rows[e.RowIndex].Cells["_urunturu"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            int result = 0;
            if (rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_insertSiparis(:_urunadi ,:_urunturu, :_fiyati)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_urunadi", txtAdi.Text);
                    cmd.Parameters.AddWithValue("_urunturu", txtTuru.Text);
                    cmd.Parameters.AddWithValue("_fiyati", txtFiyati.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Sipariş başariyla eklenmiş");

                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Insert fail");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Sipariş ekleme hatsi, " + ex.Message);
                }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
