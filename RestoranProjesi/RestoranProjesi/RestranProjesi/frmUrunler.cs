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
    public partial class frmUrunler : Form
    {
        public static readonly string con_string = "server=localHost; port=5432; Database=RestoranProjesi; user ID=postgres; password=Lio3038$$; ";
        public static NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex;

        public frmUrunler()
        {
            InitializeComponent();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
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
                comTuru.Text = dgvData.Rows[e.RowIndex].Cells["_urunturu"].Value.ToString();
                txtFiyati.Text = dgvData.Rows[e.RowIndex].Cells["_fiyati"].Value.ToString();
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            txtAdi.Enabled = txtFiyati.Enabled = comTuru.Enabled = true;
            txtAdi.Text = comTuru.Text = txtFiyati.Text = null;
            txtAdi.Select();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(rowIndex < 0)
            {
                MessageBox.Show("Lütfen istediğiniz ürünü güncellemek seçiniz!!");
                return;
            }
            txtAdi.Enabled = txtFiyati.Enabled = comTuru.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Lütfen istediğiniz ürünü silmek seçiniz!!");
                return;
            }

            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_delete(:_urunId)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_urunId", int.Parse(dgvData.Rows[rowIndex].Cells["_urunId"].Value.ToString()));
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Silme işlemi başarlı gerçekleşdi");
                    rowIndex = -1;
                    conn.Close();
                    Select();
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                conn.Close();
                MessageBox.Show("Silme işlemi hatalı, " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            if(rowIndex < 0) // insert
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_insert(:_urunadi ,:_urunturu, :_fiyati)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_urunadi", txtAdi.Text);
                    cmd.Parameters.AddWithValue("_urunturu", comTuru.Text);
                    cmd.Parameters.AddWithValue("_fiyati", txtFiyati.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if(result == 1)
                    {
                        MessageBox.Show("Yeni ürün başariyla eklendi. . .");

                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Ekleme hatali");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Ekleme işlemi Hatali, " + ex.Message);
                }
            }
            else // update
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM  st_update(:_urunId ,:_urunadi ,:_urunturu ,:_fiyati)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_urunId", int.Parse(dgvData.Rows[rowIndex].Cells["_urunId"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_urunadi", txtAdi.Text);
                    cmd.Parameters.AddWithValue("_urunturu", comTuru.Text);
                    cmd.Parameters.AddWithValue("_fiyati", txtFiyati.Text);
                    result = (int)cmd.ExecuteScalar();

                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Güncelleme başariyla bir şekilde gerçekleşdi . . ");

                        Select();
                    }
                    else
                    {
                        MessageBox.Show("Güncellme Hatali");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Güncelleme işlemi hatali, " + ex.Message);
                    
                }
                
            }
            result = 0;
            txtAdi.Text = comTuru.Text = txtFiyati.Text = null;
            txtAdi.Enabled = txtFiyati.Enabled = comTuru.Enabled = false;
        }

        private void dgvData_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void txtFiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("server = localHost; port = 5432; Database = RestoranProjesi; user ID = postgres; password = Lio3038$$;");
            conn.Open();
            DataTable tbl = new DataTable();
            string sorgu = @"SELECT * FROM Urunler WHERE urunAdi = '" + txtSearch.Text + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            da.Fill(tbl);
            conn.Close();
            dgvData.DataSource = tbl;
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = -1;
            txtAdi.Enabled = txtFiyati.Enabled = comTuru.Enabled = true;
            txtAdi.Text = comTuru.Text = txtFiyati.Text = null;
            
        }
    }
}
