using BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class PARTIDA
    {
        //internal BEL.PARTIDA partida = new BEL.PARTIDA();
        DAL.MP_PARTIDA mp_partida = new DAL.MP_PARTIDA();
        BEL.PARTIDA bll_partida = new BEL.PARTIDA();

        internal void CrearPartida(BEL.PARTIDA partida)
        {
            mp_partida.Insertar(partida);
            //Insertar una nueva partida en la BD con el jugador que la creo
            //

        }
        internal void UnirsePartida(BEL.PARTIDA partida)
        {
            mp_partida.Editar(partida);
            //Actualizar la partida actual con el jugador que se une

        }
        public void ComenzarPartida(BEL.PARTIDA partida)
        {
            mp_partida.Editar(partida);
            //Insertar los tableros en la partida
            //Setear el turno del primer jugador
        }
        public void TerminarPartida()
        {

        }
        public void CambiarJugador()
        {
            //Leer ID jug turno
            mp_partida.Listar();
            //Grabar ID jug siguiente
        }
    }
}
