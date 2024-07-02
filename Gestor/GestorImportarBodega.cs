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
            

            return bodegaSeleccionada.actualizarVinos(vinosBodegaSeleccionada, bodegaActualizada);
        }
        public async Task<List<VinoInfo>> obtenerActualizacionVinoBodega(string nombreBodega)
        {
            return await Interfacez.InterfazApiBodega.ObtenerVinosDeBodegaSeleccionada(nombreBodega);
        }
        public void buscarSeguidorBodega(bodegaSeleccionada)
        {

        } 
        
    }

}

