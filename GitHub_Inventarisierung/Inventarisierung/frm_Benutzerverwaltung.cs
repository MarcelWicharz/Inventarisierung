using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarisierung
{
    public partial class frm_Benutzerverwaltung : Form
    {
        //initialisierung eines datenbankverbindungs objektes
        Datenbankverbindungen dbver;
        public frm_Benutzerverwaltung(Datenbankverbindungen dbver)
        {
            this.dbver = dbver;
            InitializeComponent();
            //Beim tippen wird nur ein * zusehen sein und nicht die eigentlichen Buchstaben
            tb_NeuesKennwort.PasswordChar = '*';
        }

        private void btn_Anlegen_Click(object sender, EventArgs e)
        {
            dbver.createNewUser(tb_NeuerBenutzername.Text, tb_NeuesKennwort.Text);
            //daten in db schreiben
            MessageBox.Show("Benutzer: " + tb_NeuerBenutzername.Text + " wurde erfolgreich angelegt.");
            tb_NeuerBenutzername.Clear();
            tb_NeuesKennwort.Clear();

            //prüfen ob benutzer name schon vorhanden
        }
        private void btn_Zurück_Click(object sender, EventArgs e)
        {
            frm_Menü newMainForm = new frm_Menü();
            newMainForm.Show();
            this.Close();
        }
    }
}
