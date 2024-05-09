using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public abstract class Jugador
    {
        protected int Velocidad { get; set; }
        protected int Tiro { get; set; }
        protected int Regate { get; set; }
        protected int Defensa { get; set; }
        protected int Pase { get; set; }
        protected int Fisico { get; set; }

        public Jugador( int velocidad, int tiro, int regate, int defensa, int pase, int fisico)
        {
            this.Velocidad = velocidad;
            this.Tiro = tiro;
            this.Regate = regate;
            this.Defensa = defensa;
            this.Pase = pase;
            this.Fisico = fisico;

        }

    }
}
