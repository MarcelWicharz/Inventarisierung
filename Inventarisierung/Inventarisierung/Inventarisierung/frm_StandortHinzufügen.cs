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
    public partial class frm_StandortHinzufügen : Form
    {
        public frm_StandortHinzufügen()
        {
            InitializeComponent();
        }

        private void btn_Zurück_Click(object sender, EventArgs e)
        {
            frm_Kunde newMainForm = new frm_Kunde();
            newMainForm.Show();
            this.Close();
        }

        private void btn_StandortHinzufügen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Der Standort " + tb_NeuerStandort + " wurde dem Kunden " + cb_KundeAuswählen.Text + " hinzugefügt.");
        }
    }
}
