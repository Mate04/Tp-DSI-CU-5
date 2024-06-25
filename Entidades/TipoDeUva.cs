 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Entidades
{
    public class TipoUva
    {
        public string Descripcion { get; }
        public string Nombre { get; }
        public TipoUva(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        public string getNombre()
        {
            return Nombre;
        }
    }
}
