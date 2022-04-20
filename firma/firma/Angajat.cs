using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firma
{
    public class Angajat
    {
        public string nume, functia;
        public DateTime datan, dataa;
        public int salariu, iddep;
        public Angajat()
        { }
        public Angajat(string nume, DateTime datan, DateTime dataa, int salariu, string functia, int iddep)
        {
            this.nume = nume;
            this.datan = datan;
            this.dataa = dataa;
            this.salariu = salariu;
            this.functia = functia;
            this.iddep = iddep;
        }

    }
}
