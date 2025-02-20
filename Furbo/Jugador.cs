using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furbo
{
    internal class Jugador
    {
        public String nombre { get; set; }
        public String goles { get; set; }
        public String resultado { get; set; }


        public Jugador(String nombre, String golesResul) 
        {
            this.nombre = nombre;
            this.goles = golesResul.Split('-')[0];
            this.resultado = golesResul.Split('-')[1];
        }
    }
}
