using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furbo
{
    internal class Jornada
    {
        public String nombre;
        public List<Jugador> equipoGanador;
        public List<Jugador> equipoPerdedor;
        public List<Jugador> bajas;
        public List<Jugador> todos;
        public int resultadoGanador;
        public int resultadoPerdedor;
        public String max;
        public String total;
        public String pichichi;
        public String puskas;
        public String fecha;

        public Jornada(Dictionary<string, string> jornada, string nombre, Dictionary<String, Stats> stats)
        { 
            List<String> campos = new List<String>();
            campos.Add("Max");
            campos.Add("Total");
            campos.Add("Pichichi");
            campos.Add("Puskas");
            campos.Add("fecha");
            this.nombre = nombre;
            equipoGanador = new List<Jugador>();
            equipoPerdedor = new List<Jugador>();
            bajas = new List<Jugador>();
            todos = new List<Jugador>();
            this.max = jornada.ElementAt(16).Value;
            this.total = jornada.ElementAt(17).Value;
            this.pichichi = jornada.ElementAt(18).Value;
            this.puskas = jornada.ElementAt(19).Value;
            this.fecha = jornada.ElementAt(20).Value;
            foreach (KeyValuePair<string, string> entry in jornada)
            {
                if (!campos.Contains(entry.Key))
                {
                    Jugador jugador = new Jugador(entry.Key, entry.Value);
                    clasificarJugadores(jugador, stats);
                    todos.Add(jugador);
                }
            }
            this.nombre = nombre;
        }

        private void clasificarJugadores(Jugador jugador, Dictionary<String, Stats> stats)
        {
            if (jugador.resultado.Equals("0"))
            {
                this.equipoGanador.Add(jugador);
                this.resultadoGanador += Int32.Parse(jugador.goles);
                foreach(KeyValuePair<string, Stats> entry in stats)
                {
                    if (jugador.nombre.Equals(entry.Key))
                    {
                        entry.Value.jugados++;
                        entry.Value.totales += Int32.Parse(jugador.goles);
                        entry.Value.victorias++;
                        if (jugador.goles.Equals(this.max))
                        {
                            entry.Value.pichichis++;
                        }
                        if (jugador.nombre.Equals(this.puskas))
                        {
                            entry.Value.puskas++;
                        }
                    }
                }
            } 
            else if (jugador.resultado.Equals("1"))
            {
                this.equipoPerdedor.Add(jugador);
                this.resultadoPerdedor += Int32.Parse(jugador.goles);
                foreach (KeyValuePair<string, Stats> entry in stats)
                {
                    if (jugador.nombre.Equals(entry.Key))
                    {
                        entry.Value.jugados++;
                        entry.Value.totales += Int32.Parse(jugador.goles);
                        if (jugador.goles.Equals(this.max))
                        {
                            entry.Value.pichichis++;
                        }
                        if (jugador.nombre.Equals(this.puskas))
                        {
                            entry.Value.puskas++;
                        }
                    }
                }
            } 
            else
            {
                this.bajas.Add(jugador);
            }
        }
    }
}
