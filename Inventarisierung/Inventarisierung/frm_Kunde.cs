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
    public partial class frm_Kunde : Form
    {
        public frm_Kunde()
        {
            InitializeComponent();
       
        }

        private void cb_KundeAuswählen_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Liste aller Kunden in der DB in der Combobox anzeigen lassen
            //private List<string> GetListFromDataTableColumn(DataTable Kunde,
            //int K_ID, string Name)
            //{
            //    List<string> result = new List<string>();
            //}
            //Dropdownfeld mit Kunden aus der Db füllen
            //cb_KundeAuswählen =  ; //hier müsste dann die liste übergeben werde denke ich

            //auch hier denke ich das mein ansatz kommpletter mist ist.

        }

        private void btn_KundeAuswählen_Click(object sender, EventArgs e)
        {

            //Die auswahl die i der combobox angeklickt wurde soll verwendet werden und den uer mit dem von ihm ausgewählten
            //kunden verbinden.
            //und so eine verbindung und so den kunden verwenden beim inventarisieren neuer artikel oder ändern
            //oder listen anzeigen.

            // noch kein plan wie ich das realisieren soll und ob meine gewählten form und abläufe so richtig sind.
            frm_Inventarisierung newMainForm = new frm_Inventarisierung();
            newMainForm.Show();
            this.Close();
        }

        private void btn_NeuerKunde_Click(object sender, EventArgs e)
        {
            frm_KundeHinzufügen newMainForm = new frm_KundeHinzufügen();
            newMainForm.Show();
            this.Close();
        }


    }
}
