using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BARCO
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private int largo;

		public int Largo
		{
			get { return largo; }
			set { largo = value; }
		}

		private string descCorta;

		public string DescCorta
		{
			get { return descCorta; }
			set { descCorta = value; }
		}
	}
}
