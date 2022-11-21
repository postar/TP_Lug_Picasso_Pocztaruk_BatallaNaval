using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class PARTIDA
    {
        internal BEL.PARTIDA partida = new BEL.PARTIDA();

        internal void CrearPartida()
        {
            partida.tablero = new BEL.TABLERO();
            partida.turno = new BEL.TURNO();
            partida.usuario = new BEL.USUARIO();
        }
        public void comenzarPartida()
        {
            if (partida.Jugadores.Count == 2)
            {
                //Generar partida a la BD
                partida.Jugadores[0].Turno = true;
                partida.Jugadores[1].Turno = false;
            }
            else
            {
                throw new Exception("No hay suficientes jugadores");
            }
        }
    }
}
