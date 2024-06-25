using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Entidades
{
    public class Maridaje
    {
        public string Descripcion { get; }
        public string Nombre { get; }

        public Maridaje(string descripcion, string nombre)
        {
            Descripcion = descripcion;
            Nombre = nombre;
        }
        public string getNombre()
        {
            return Nombre;
        }
    }
}
