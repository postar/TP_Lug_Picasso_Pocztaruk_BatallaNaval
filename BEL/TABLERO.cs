using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BEL
{
    public class TABLERO
    {
		private DataTable tablero;

		public DataTable Tablero
		{
			get { return tablero; }
			set { tablero = value; }
		}
        
        private List<BARCO> barcos;

        public List<BARCO> Barcos
        {
            get { return barcos; }
            set { barcos = value; }
        }
    }
}