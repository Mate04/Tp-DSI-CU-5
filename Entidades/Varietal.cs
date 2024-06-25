using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Entidades
{
    public class Varietal
    {
        public string descripcion { get; }
        public float porcentajeComposicion { get; }
        public TipoUva tipoUva { get; }

        public Varietal(string descripcion, float porcentajeComposicion, TipoUva tipoUva)
        {
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
            this.tipoUva = tipoUva;
        }

        public string conocerUva()
        {
            return "tipo de uva" + tipoUva?.Nombre;
        }
    }
}
