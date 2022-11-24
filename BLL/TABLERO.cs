using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class TABLERO
    {
        private BEL.TABLERO tablero = new BEL.TABLERO();

        public void Generar()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    tablero.cuadricula[i, j] = false;
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
