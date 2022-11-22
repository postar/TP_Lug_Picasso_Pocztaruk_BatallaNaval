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
        
        public bool[,] cuadricula = new bool[15, 15];

        public void Generar()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    cuadricula[i, j] = false;
                }
            }
        }
        
        public void Grabar(Array cuadricula)
        {
            foreach (bool item in cuadricula)
            {
                //DB.escribir.....
            }

        }
    }
}