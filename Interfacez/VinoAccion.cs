using PPAI_CU_5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Interfacez
{
    public class VinoAccion
    {
        public string VinoSeleccionado { get; set; }
        public string Accion { get; set; }

        // Constructor que inicializa todas las propiedades
        public VinoAccion(string vinoSeleccionado, string accion)
        {
            VinoSeleccionado = vinoSeleccionado;
            Accion = accion;
        }
        public string getVinoSeleccionado()
        {
            return VinoSeleccionado;
        }
        public string getAccion()
        {
            return Accion;
        }
    }

}
