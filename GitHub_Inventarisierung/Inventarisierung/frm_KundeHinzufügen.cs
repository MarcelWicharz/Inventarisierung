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
    public partial class frm_KundeHinzufügen : Form
    {
        Datenbankverbindungen dbver;
        public frm_KundeHinzufügen(Datenbankverbindungen dbver)
        {
            this.dbver = dbver;
            InitializeComponent();
        }
        private void btn_KundeHinzufügen_Click(object sender, EventArgs e)
        {
            dbver.createNewCustomer(tb_KundennameHinzufügen.Text, tb_Straße.Text, tb_PLZ.Text, tb_Ort.Text, tb_EMail.Text);                     
            MessageBox.Show("Der Kunde " + tb_KundennameHinzufügen.Text + " wurde erfolgreich Angelegt.");
            tb_KundennameHinzufügen.Clear();
        }
        private void btn_Zurück_Click(object sender, EventArgs e)
        {
            //Zurück zur Kunden Form und KundeHinzufügen Form schließen.
            frm_Kunde newMainForm = new frm_Kunde();
            newMainForm.Show();
            this.Close();
        }
    }
}
