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
        //initialisierung eines datenbankverbindungs objektes
        Datenbankverbindungen dbver;

        public frm_Login(Datenbankverbindungen dbver)
        {
            this.dbver = dbver;
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
            //Methode zum LogIn Check
            if(dbver.checkIfUsernameAndPasswordIsCorrect(tb_Benutzername.Text, tb_Kennwort.Text)){
                frm_Menü newMainForm = new frm_Menü();
                newMainForm.Show();
                hideMainForm();
            }
            else{
                MessageBox.Show("Anmeldename oder Kennwort sind fehlerhaft.");
                tb_Benutzername.Clear();
                tb_Kennwort.Clear();
            }
        }
    }
}
