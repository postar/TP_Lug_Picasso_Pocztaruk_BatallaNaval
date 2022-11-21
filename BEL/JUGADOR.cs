using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEL
{
    public class JUGADOR
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private bool activo;

		public bool Activo
		{
			get { return activo; }
			set { activo = value; }
		}
	}
}