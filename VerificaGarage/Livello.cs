using System;
using System.Collections.Generic;
using System.Text;

namespace VerificaGarage
{
    class Livello
    {
        public int Numero { get; private set; }
        public List<Parcheggio> Parcheggi { get; private set; }

        public Livello(int numero, Garage garage)
        {
            Numero = numero;
            garage.Livelli.Add(this);
        }
    }
}
