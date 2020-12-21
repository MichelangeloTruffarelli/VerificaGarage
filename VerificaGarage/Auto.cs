using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaGarage
{
    class Auto
    {
        public string Targa { get; private set; }
        public int Cilindrata { get; private set; }
        public Biglietto Biglietto { get; set; }
        public Parcheggio Parcheggio { get; set; }

        public Auto(string targa, int cilindrata)
        {
            Targa = targa;
            Cilindrata = cilindrata;
        }
    }
}
