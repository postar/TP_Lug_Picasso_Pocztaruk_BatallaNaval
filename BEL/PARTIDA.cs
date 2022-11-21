using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class PARTIDA
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private JUGADOR jugador1;

		public JUGADOR Jugador1
		{
			get { return jugador1; }
			set { jugador1 = value; }
		}

        private JUGADOR jugador2;

        public JUGADOR Jugador2
        {
            get { return jugador2; }
            set { jugador2 = value; }
        }
        
        private bool enCurso;

		public bool EnCurso
		{
			get { return enCurso; }
			set { enCurso = value; }
		}

		private DateTime fechaInicio;

		public DateTime FechaInicio
		{
			get { return fechaInicio; }
			set { fechaInicio = value; }
		}

		private DateTime fechaFin;

		public DateTime FechaFin
		{
			get { return fechaFin; }
			set { fechaFin = value; }
		}

		private JUGADOR ganador;

		public JUGADOR Ganador
		{
			get { return ganador; }
			set { ganador = value; }
		}

		private TABLERO tablero1;

		public TABLERO Tablero1
		{
			get { return tablero1; }
			set { tablero1 = value; }
		}

        private TABLERO tablero2;

        public TABLERO Tablero2
        {
            get { return tablero2; }
            set { tablero2 = value; }
        }
    }
}