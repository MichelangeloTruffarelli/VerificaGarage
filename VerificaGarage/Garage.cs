using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaGarage
{
    class Garage
    {
        public string Località { get; private set; }
        public List<Livello> Livelli { get; private set; }

        public Garage(string località)
        {
            Località = località;
        }
        public bool Parcheggiata(Auto auto)
        {
            bool parcheggiata = false;
            foreach (Livello livello in Livelli)
            {
                if (livello.Parcheggi.Contains(auto.Parcheggio))
                {
                    parcheggiata = true;
                }
            }
            return parcheggiata;
        }
        public Biglietto Parcheggia(Auto auto)
        {
            auto.Parcheggio = new Parcheggio();
            auto.Biglietto = new Biglietto(DateTime.Now, auto, auto.Parcheggio);
            return auto.Biglietto;
        }
    }
}
