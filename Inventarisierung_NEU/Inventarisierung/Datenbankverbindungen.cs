using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Inventarisierung
{
    public class Datenbankverbindungen
    {
        //public void connectionString(SqlConnection cn)
        //{
        //    cn.ConnectionString = @"Data Source=IF-PC42;
        //    Initial Catalog=Inventarisierung;
        //    User id=sa;
        //    Password=#ifaktor99;";
        //}

        //Methode wird beim LogIn benutzt
        public bool checkIfUsernameAndPasswordIsCorrect(string tb_Benutzername, string tb_Kennwort)
        {
            //Verbindungs String bauen
            SqlConnection cn = new SqlConnection("");
            cn.ConnectionString = @"Data Source=IF-PC42;
            Initial Catalog=Inventarisierung;
            User id=sa;
            Password=#ifaktor99;";
            cn.Open();

            SqlCommand cmd = new SqlCommand($@"select COUNT(Benutzer.B_ID) From Benutzer where Name ='{ tb_Benutzername }' and Kennwort ='{ tb_Kennwort }'", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            var dtResult = new DataTable();
            dtResult.Load(dr);
            var count = dtResult.Rows[0][0].ToString();
            if (count == "1"){
                return true;
            }
            else{
                return false;
            }
        }
        //Methode wird beim Neuen Benutzer Anlegen benutzt
        public void createNewUser(string tb_NeuerBenutzername, string tb_NeuesKennwort)
        {
            //Verbindungs String bauen
            SqlConnection cn = new SqlConnection("");
            cn.ConnectionString = @"Data Source=IF-PC42;
            Initial Catalog=Inventarisierung;
            User id=sa;
            Password=#ifaktor99;";
            cn.Open();

            SqlCommand cmd = new SqlCommand($@"Insert Into Benutzer (Name,Kennwort)values('{tb_NeuerBenutzername}','{tb_NeuesKennwort}')", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
        }
        //Methode wird beim neuen Kunden Anlegen benutzt
        public void createNewCustomer(string tb_KundennameHinzufügen, string tb_Straße, string tb_PLZ, string tb_Ort, string tb_EMail)
        {
            //Verbundungs String bauen
            SqlConnection cn = new SqlConnection("");
            cn.ConnectionString = @"Data Source=IF-PC42;
            Initial Catalog=Inventarisierung;
            User id=sa;
            Password=#ifaktor99;";
            cn.Open();

            SqlCommand cmd = new SqlCommand($@"Insert Into Kunde (Name,Straße,PLZ,Ort,EMail)values('{tb_KundennameHinzufügen}','{tb_Straße}','{tb_PLZ}','{tb_Ort}','{tb_EMail}')",cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
        }
    }
}
