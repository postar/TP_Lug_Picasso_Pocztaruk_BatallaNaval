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

		private List<BARCO> barcos1;

		public List<BARCO> Barcos1
		{
			get { return barcos1; }
			set { barcos1 = value; }
		}

        private List<BARCO> barcos2;

        public List<BARCO> Barcos2
        {
            get { return barcos2; }
            set { barcos2 = value; }
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
    }
}