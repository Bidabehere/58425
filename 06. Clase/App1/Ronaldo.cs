using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Ronaldo : Jugador , IJugador
    {
        public Ronaldo(int velocidad, int tiro, int regate, int defensa, int pase, int fisico) : base(velocidad, tiro, regate, defensa, pase, fisico)
        {
        }

        public void colocarPase()
        {
            Console.WriteLine("Cristiano Ronaldo coloco pase con {0} de propiedad", this.Pase);

        }

        public void correr()
        {
            Console.WriteLine("Cristiano Ronaldo corrio con {0} de propiedad", this.Velocidad);

        }

        public void defender()
        {
            Console.WriteLine("Cristiano Ronaldo defendio con {0} de propiedad", this.Defensa);

        }

        public void regatear()
        {
            Console.WriteLine("Cristiano Ronaldo regateo con {0} de propiedad", this.Regate);

        }

        public void rematar()
        {
            Console.WriteLine("Cristiano Ronaldo remato con {0} de propiedad", this.Tiro);

        }

        public void soportarEmbate()
        {
            Console.WriteLine("Cristiano Ronaldo soporto el emnate con {0} de propiedad", this.Fisico);

        }
    }
}
