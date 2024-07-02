using PPAI_CU_5.Interfacez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Entidades
{
    public class Bodega
    {
        private string coordenadasUbicacion;
        private string descripcion;
        private DateTime fechaUltimaActualizacion;
        private string historia;
        private string nombre;
        private DateTime periodoActualizacion;

        public Bodega(string coordenadasUbicacion, string descripcion, DateTime fechaUltimaActualizacion, string historia, string nombre, DateTime periodoActualizacion)
        {
            this.coordenadasUbicacion = coordenadasUbicacion;
            this.descripcion = descripcion;
            this.fechaUltimaActualizacion = fechaUltimaActualizacion;
            this.historia = historia;
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion;
        }
        public Bodega(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public DateTime getPeriodoActualizacion()
        {
            return this.periodoActualizacion;
        }

        public void actualizarVino( Vino vino, VinoInfo vinoActualizar )
        {
            vino.setPrecio(vinoActualizar.PrecioARS);
            vino.setImagen(vinoActualizar.NombreEtiqueta);
            vino.setNotaCata(vinoActualizar.NotaDeCataBodega);
            vino.setFechaActualizacion();
        } 
        public List<VinoAccion> actualizarVinos(List<Vino> vinosBodegaSeleccionada, List<VinoInfo> bodegaActualizada)
        {
            List<VinoAccion> Acciones = new List<VinoAccion>();
            foreach (var vinoActualizado in bodegaActualizada)
            {
                bool banderaActualizado = false;

                foreach (var vinoSeleccionado in vinosBodegaSeleccionada)
                {
                    if (vinoSeleccionado.getNombre().Equals(vinoActualizado.getNombre(), StringComparison.OrdinalIgnoreCase))
                    {
                        // Si los vinos son iguales según la bodega y el nombre de la etiqueta, realiza alguna acción
                        bodegaSeleccionada.actualizarVino(vinoSeleccionado, vinoActualizado);
                        var accion = new VinoAccion(vinoSeleccionado.getNombre(), "actualizado");
                        Acciones.Add(accion);
                        banderaActualizado = true;
                        break;
                    }
                }

                // Si no se encontró un vino actualizado, se crea uno nuevo
                if (!banderaActualizado)
                {
                    string tipoUvaFound = vinoActualizado.getTipoUva()[0];
                    // buscame el tipo de uva en esta lista de tipos de uva
                    var tipoUva = this.tiposUvas.FirstOrDefault(t => t.getNombre().Equals(tipoUvaFound, StringComparison.OrdinalIgnoreCase));
                    // lo mismo pero con maridajes
                    string nombreMaridaje = vinoActualizado.getMaridajes()[0];
                    var maridaje = this.maridajes.FirstOrDefault(m => m.getNombre().Equals(nombreMaridaje, StringComparison.OrdinalIgnoreCase));

                    //new Vino(DateTime.Now, vinoActualizado.getNombre(), bodegaSeleccionada);
                    var accion = new VinoAccion(vinoActualizado.getNombre(), "Creado");
                    Acciones.Add(accion);
                }
            }
            return Acciones;
        }

    }
}
