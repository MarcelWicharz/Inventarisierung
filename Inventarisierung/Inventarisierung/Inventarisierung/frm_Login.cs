using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //wird benötigt um auf die Datenbank zu gelangen

namespace Inventarisierung
{
    public partial class frm_Login : Form
    {
        //initialisierung eines datenbankverbindungs objektes für den benutzerkennwort check
        Datenbankverbindung dbver;

        //initialisierung eines datenbankverbindungs objektes für das anlegen eines neuen benutzers in der datenkbank
        Datenbankverbindung dbben;

        //Datenbankverbindung dbben;
        public frm_Login(Datenbankverbindung dbver, Datenbankverbindung dbben )
        {
            this.dbver = dbver;
            this.dbben = dbben;

            InitializeComponent();

            //Beim tippen wird nur ein * zusehen sein und nicht die eigentlichen Buchstaben
            tb_Kennwort.PasswordChar = '*';
        }

        private void hideMainForm()
        {
            //Main Form unsichtbar stellen
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            if(dbver.checkIfUsernameAndPasswordIsCorrect(tb_Benutzername.Text, tb_Kennwort.Text))
            {
                frm_Kunde newMainForm = new frm_Kunde();
                newMainForm.Show();
                hideMainForm();
            }
            else
            {
                MessageBox.Show("Anmeldename oder Kennwort sind fehlerhaft.");
                tb_Benutzername.Clear();
                tb_Kennwort.Clear();
            }
        }

        private void btn_Registrieren_Click(object sender, EventArgs e)
        {
            //if(dbben.createNewUser(tb_Benutzername.Text, tb_Kennwort.Text))
            //{
            //    //daten in db schreiben
            //    MessageBox.Show("Benutzer: " + tb_Benutzername.Text + " wurde erfolgreich angelegt.");
            //    tb_Benutzername.Clear();
            //    tb_Kennwort.Clear();
                    
            //}

        }
    }
}
