﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Entidades
{
    public class Siguiendo
    {
        public DateTime FechaFin { get; }
        public DateTime FechaInicio { get; }
        public Bodega bodega;
        public Siguiendo(DateTime FechaInicio, DateTime FechaFin, Bodega bodega)
        {
            this.FechaFin = FechaFin;
            this.FechaInicio = FechaInicio;
            this.bodega = bodega;
        }
    }
    public Bodega getBodega()
    {
        return this.bodega
    }
    public void sosDeBodega(Bodega bodega)
    {
        if (this.bodega == bodega)
        {
            Console.WriteLine("notificar a usuario");
        }
    }
}
