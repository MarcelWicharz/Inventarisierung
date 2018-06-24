using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarisierung
{
    public class Kunde
    {
        private int K_ID;
        private String name;
        private String straße;
        private String plz;
        private String EMail;
        private String ort;

        public int K_ID1
        {
            get
            {
                return K_ID;
            }

            set
            {
                K_ID = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Straße
        {
            get
            {
                return straße;
            }

            set
            {
                straße = value;
            }
        }

        public string Plz
        {
            get
            {
                return plz;
            }

            set
            {
                plz = value;
            }
        }

        public string EMail1
        {
            get
            {
                return EMail;
            }

            set
            {
                EMail = value;
            }
        }

        public string Ort
        {
            get
            {
                return ort;
            }

            set
            {
                ort = value;
            }
        }
    }
}
