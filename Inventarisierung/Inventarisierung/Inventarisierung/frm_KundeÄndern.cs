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
    public partial class frm_KundeÄndern : Form
    {
        public frm_KundeÄndern()
        {
            InitializeComponent();
        }

        private void btn_Zurück_Click(object sender, EventArgs e)
        {
            frm_Kunde newMainForm = new frm_Kunde();
            newMainForm.Show();
            this.Close();
        }

        private void btn_KundenDatenÄndern_Click(object sender, EventArgs e)
        {
            //Update was im Kundennamen Feld steht in die Datenbank
        }
    }
}
