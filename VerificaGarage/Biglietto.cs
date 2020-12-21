using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaGarage
{
    class Biglietto
    {
        public Biglietto(DateTime arrivo, Auto auto, Parcheggio parcheggio)
        {
            Arrivo = arrivo;
            parcheggio.Biglietto = this;
            auto.Biglietto = this;
        }

        public DateTime Arrivo { get; }

        public double Paga()
        {
            double tempo = double.Parse((DateTime.Now - Arrivo).ToString());
            return (tempo / 60 * 1.50);
        }
    }
}
