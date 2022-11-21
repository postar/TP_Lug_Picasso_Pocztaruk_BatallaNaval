﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class MAPPER<T>
    {
        public abstract int Insertar(T obj);

        public abstract int Editar(T obj);

        public abstract int Borrar(T obj);

    }
}
