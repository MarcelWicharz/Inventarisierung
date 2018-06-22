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
        public frm_KundeHinzufügen()
        {
            InitializeComponent();
        }

        public string KundeHinzufügen;

        private void btn_KundeHinzufügen_Click(object sender, EventArgs e)
        {
            //Kunde in DB schreiben
            KundeHinzufügen = "Inserted Into dbo.Inventarisierung.Kunde.Name where Name ='"+ tb_KundennameHinzufügen.Text;

            //Zurück zur Kunden Form und KundeHinzufügen Form schließen.
            frm_Kunde newMainForm = new frm_Kunde();
            newMainForm.Show();
            this.Close();
        }
    }
}
