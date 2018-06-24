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
    public partial class frm_Menü : Form
    {
        public frm_Menü()
        {
            InitializeComponent();
        }

        private void btn_NeueBenutzer_Click(object sender, EventArgs e)
        {
            Datenbankverbindungen dbver = new Datenbankverbindungen();
            frm_Benutzerverwaltung newMainForm = new frm_Benutzerverwaltung(dbver);
            newMainForm.Show();
        }

        private void btn_KundenAuswahl_Click(object sender, EventArgs e)
        {
            frm_Kunde newMainForm = new frm_Kunde();
            newMainForm.Show();
        }
    }
}
