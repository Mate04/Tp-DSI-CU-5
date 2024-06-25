using PPAI_CU_5.Interfacez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Entidades
{
    public class Vino
    {
        public DateTime Añada { get; }
        public DateTime FechaActualizacion { get; set; }
        public string NombreEtiqueta { get; set; }
        public string Nombre { get; }
        public string NotaDeCataBodega { get; set; }
        public decimal PrecioARS { get; set; }
        public Bodega bodega { get; }
        public List<Varietal> varietales;
        public List<Maridaje> maridajes;

        public Vino(DateTime añada, DateTime fechaActualizacion, string nombreEtiqueta, string nombre, string notaDeCataBodega, decimal precioARS, Bodega bodega)
        {
            this.Añada = añada;
            this.FechaActualizacion = fechaActualizacion;
            this.NombreEtiqueta = nombreEtiqueta;
            this.Nombre = nombre;
            this.NotaDeCataBodega = notaDeCataBodega;
            this.PrecioARS = precioARS;
            this.varietales = new List<Varietal>();
            this.maridajes = new List<Maridaje>();
            this.bodega = bodega;
        }
        public Vino(VinoInfo vinoInfo,Bodega bodega, TipoUva tipoUva, Maridaje maridaje)
        {
            this.Nombre =vinoInfo.getNombre();

            this.bodega = bodega;
            this.varietales = new List<Varietal>();
            this.maridajes = new List<Maridaje> { maridaje };
            this.Añada = vinoInfo.añada.ToDateTime(new TimeOnly(0, 0));
            this.PrecioARS = vinoInfo.getPrecio();
            this.NotaDeCataBodega = vinoInfo.getNotaCata();
            this.NombreEtiqueta = vinoInfo.getNotaEtiqueta();

        }
        public void setFechaActualizacion() { 
            this.FechaActualizacion = DateTime.Now;
        }
        public void MostrarMaridajes()
        {
            Console.WriteLine($"Maridajes para el vino {Nombre}:");
            foreach (var maridaje in maridajes)
            {
                Console.WriteLine($"- {maridaje.Nombre}: {maridaje.Descripcion}");
            }
        }
        public void MostrarVarietales()
        {
            Console.WriteLine($"Maridajes para el vino {Nombre}:");
            foreach (var varietale in varietales)
            {
                Console.WriteLine($"- {varietale.descripcion}");
            }
        }
        public void AñadirMaridaje(Maridaje maridaje)
        {
            if (maridaje != null)
            {
                maridajes.Add(maridaje);
            }
        }
        public void AñadirVarietal(Varietal varietal)
        {
            if (varietal != null)
            {
                varietales.Add(varietal);
            }
        }
        public string getBodega()
        {
            return this.bodega.getNombre();
        }
        public string getNombre()
        {
            return this.Nombre;
        }
        public void setPrecio(decimal precio)
        {
            this.PrecioARS = precio;
        }
        public void setNotaCata(string notaCata)
        {
            this.NotaDeCataBodega = notaCata;
        }
        public void setImagen(string imagen)
        {
            this.NombreEtiqueta = imagen;
        }
    }
}
