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
        List<Enofilo> enofilos;
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
            this.enofilos= new List<Enofilo>();
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
            //aca se envia la informacion a los enofilos
            this.buscarSeguidorBodega(bodegaSeleccionada);
            //aca se muestra en la interfaz
            return bodegaSeleccionada.actualizarVinos(vinosBodegaSeleccionada, bodegaActualizada);
        }
        public async Task<List<VinoInfo>> obtenerActualizacionVinoBodega(string nombreBodega)
        {
            return await Interfacez.InterfazApiBodega.ObtenerVinosDeBodegaSeleccionada(nombreBodega);
        }
        public void buscarSeguidorBodega(Bodega bodegaSeleccionada)
        {
            foreach(var enofilo in this.enofilos)
            {
                //pregunta a cada enofilo de base de datos si sigue a bodega
                enofilo.seguisAbodega(bodegaSeleccionada);
            }
        } 
        
    }

}

