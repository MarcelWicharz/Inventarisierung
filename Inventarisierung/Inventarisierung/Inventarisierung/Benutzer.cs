﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarisierung
{
    //Überlegung, Klasse benötigt für neue Benutzer in datenbank anlegen??!
    class Benutzer
    {
        private string benutzername;
        private string benutzerkennwort;

        public string Benutzername
        {
            get { return benutzername; }
            set { benutzername = value; }
        }

        public string Benutzerkennwort
        {
            get { return benutzerkennwort; }
            set { benutzerkennwort = value; }
        }

        public Benutzer(string Benutzername, string Benutzerkennwort)
        {
            this.benutzername = Benutzername;
            this.benutzerkennwort = Benutzerkennwort;
        }

    }
}
