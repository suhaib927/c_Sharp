using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestranProjesi
{
    internal class MainClass
    {
        public static readonly string con_string = "server=localHost; port=5432; Database=RestoranProjesi; user ID=postgres; password=Lio3038$$; ";
        public static NpgsqlConnection con = new NpgsqlConnection(con_string);


        public static bool isValidUcer(string user, string pass)
        {
            bool isValid = false;

            string qry = @"SELECT * FROM Yoneticiler WHERE ad = '" + user + "' and sifre = '" + pass + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(qry, con);

            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            System.Object value = da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["personalTipi"].ToString();
            }

            return isValid;
        }



        // create property for user

        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
    }
}
