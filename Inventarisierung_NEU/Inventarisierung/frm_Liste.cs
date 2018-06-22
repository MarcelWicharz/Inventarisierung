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
    public partial class frm_Liste : Form
    {
        public frm_Liste()
        {
            InitializeComponent();
        }

        private void btn_Zurück_Click(object sender, EventArgs e)
        {
            //Zurück zur Inventarisierungs Form und Listen Form schließen.
            frm_Inventarisierung newMainForm = new frm_Inventarisierung();
            newMainForm.Show();
            this.Close();
        }
    }
}
