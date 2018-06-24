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
        private SqlConnection cn;
        private bool connectionOpened = false;

        private void openConnection()
        {
            if (connectionOpened)
            {
                throw new InvalidOperationException("Can't open another SQL-ConString");
            }
            this.cn = new SqlConnection("");
            cn.ConnectionString = @"Data Source=MARCELWICHARZ;
            Initial Catalog=Inventarisierung;
            User id=sa;
            Password=test;";
            cn.Open();
            connectionOpened = true;
        }
        private void closeConnection()
        {
            this.cn.Close();
            this.connectionOpened = false;
        }

        //Methode wird beim LogIn benutzt
        public bool checkIfUsernameAndPasswordIsCorrect(string tb_Benutzername, string tb_Kennwort)
        {
            //Verbindungs String bauen
            openConnection();
            SqlCommand cmd = new SqlCommand($@"select COUNT(Benutzer.B_ID) From Benutzer where Name ='{ tb_Benutzername }' and Kennwort ='{ tb_Kennwort }'", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            var dtResult = new DataTable();
            dtResult.Load(dr);
            var count = dtResult.Rows[0][0].ToString();
            closeConnection();
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
            openConnection();
            SqlCommand cmd = new SqlCommand($@"Insert Into Benutzer (Name,Kennwort)values('{tb_NeuerBenutzername}','{tb_NeuesKennwort}')", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            closeConnection();
        }
        //Methode wird beim neuen Kunden Anlegen benutzt
        public void createNewCustomer(string tb_KundennameHinzufügen, string tb_Straße, string tb_PLZ, string tb_Ort, string tb_EMail)
        {
            //Verbundungs String bauen
            openConnection();
            SqlCommand cmd = new SqlCommand($@"Insert Into Kunde (Name,Straße,PLZ,Ort,EMail)values('{tb_KundennameHinzufügen}','{tb_Straße}','{tb_PLZ}','{tb_Ort}','{tb_EMail}')",cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            closeConnection();
        }
        public List<Kunde> getAllCustomers()
        {
            List<Kunde> kundenListe = new List<Kunde>();
            openConnection();
            SqlCommand cmd = new SqlCommand($@"SELECT K_ID,Name,Straße,PLZ,Ort,EMail FROM dbo.Kunde", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            var dtResult = new DataTable();
            dtResult.Load(dr);
            for (int i = 0; i<dtResult.Rows.Count; i++)
            {
                Kunde kn = new Kunde();
                kn.K_ID1 = int.Parse(dtResult.Rows[i][0].ToString());
                kn.Name = dtResult.Rows[i][1].ToString();
                kn.Straße = dtResult.Rows[i][2].ToString();
                kn.Plz = dtResult.Rows[i][3].ToString();
                kn.Ort = dtResult.Rows[i][4].ToString();
                kn.EMail1 = dtResult.Rows[i][5].ToString();
                kundenListe.Add(kn);
            }
            closeConnection();
            return kundenListe;
        }
    }
}
