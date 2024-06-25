using PPAI_CU_5.Entidades;
using PPAI_CU_5.Interfacez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Gestor
{

    public class GestorImortarBodega
    {

        Ventana.VentanaImportarBodega ventana;
        List<Vino> vinos;
        List<TipoUva> tiposUvas;
        List<Bodega> bodegas;
        List<Bodega> bodegasActualizar;
        List<Maridaje> maridajes;
        Bodega bodegaSeleccionada;
        public GestorImortarBodega(Ventana.VentanaImportarBodega venta)
        {
            this.ventana = venta;
            this.bodegas = new List<Bodega>();
            this.bodegasActualizar = new List<Bodega>();
            this.vinos = new List<Vino>();
            this.tiposUvas = new List<TipoUva>();
            this.maridajes = new List<Maridaje>();
        }
        public void bodegasActualizadas(List <Bodega> listaActualizada)
        {
            this.bodegas.AddRange(listaActualizada);
        }
        public void añadirVinos(List <Vino> listaVinos)
        {
            this.vinos.AddRange(listaVinos);
        }
        public void añadirTipoUva(List<TipoUva> tiposUvas)
        {
            this.tiposUvas.AddRange(tiposUvas);
        }
        public void añadirMaridajes(List<Maridaje> maridajes)
        {
            this.maridajes.AddRange(maridajes);
        }
        //lista de bodegas a actualizar
        public List<Bodega> opcionImportarActualizacionVinos(int diasActualizar)
        {
            DateTime fechaActual = DateTime.Now;
            foreach (var bodega in bodegas)
            {
                if ((bodega.getPeriodoActualizacion() - fechaActual).TotalDays < diasActualizar)
                {
                    bodegasActualizar.Add(bodega);
                }
            }
            return this.bodegasActualizar;


        }

        public async Task<List<VinoAccion>> tomarSeleccionBodegas(string nombreBodega)
        {
            var bodegaSeleccionada = bodegas.FirstOrDefault(b => b.getNombre().Equals(nombreBodega, StringComparison.OrdinalIgnoreCase));
            if (bodegaSeleccionada == null)
            {
                throw new Exception("Bodega no encontrada");
            }

            List<Vino> vinosBodegaSeleccionada = this.vinos.Where(v => v.getBodega().Equals(bodegaSeleccionada.getNombre(), StringComparison.OrdinalIgnoreCase)).ToList();
            List<VinoInfo> bodegaActualizada = await this.obtenerActualizacionVinoBodega(nombreBodega);
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
        public async Task<List<VinoInfo>> obtenerActualizacionVinoBodega(string nombreBodega)
        {
            return await Interfacez.InterfazApiBodega.ObtenerVinosDeBodegaSeleccionada(nombreBodega);
        }
        
    }

}

