using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Inventarisierung
{
    public class Datenbankverbindung
    {
        //Datenbank verbindungsstring erstellen
        public bool checkIfUsernameAndPasswordIsCorrect(String tb_Benutzername, String tb_Kennwort)
        {
            //Verbindungs String bauen
            SqlConnection cn = new SqlConnection("");
            cn.ConnectionString = @"Data Source=MARCELWICHARZ;
            Initial Catalog=Inventarisierung;
            User id=sa;
            Password=test;";
            cn.Open();


            SqlCommand cmd = new SqlCommand($@"select COUNT(Benutzer.B_ID) From Benutzer where Name ='{ tb_Benutzername }' and Kennwort ='{ tb_Kennwort }'", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            var dtResult = new DataTable();
            dtResult.Load(dr);
            var count = dtResult.Rows[0][0].ToString();

            if (count == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void  createNewBenutzer(string tb_Benutzername, string tb_Kennwort)
        {
            //Verbindungs String bauen
            SqlConnection cnn = new SqlConnection("");
            cnn.ConnectionString = @"Data Source=MARCELWICHARZ;
            Initial Catalog=Inventarisierung;
            User id=sa;
            Password=test;";
            cnn.Open();

            SqlCommand cmd = new SqlCommand($@"Insert Into Benutzer Set Benutzer.Name ='{ tb_Benutzername }', Benutzer.Kennwort='{ tb_Kennwort }'", cnn);
            SqlDataReader drr;
            drr = cmd.ExecuteReader();
        }
    }
}
