using PPAI_CU_5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.Interfacez
{
    public class VinoInfo
    {
        public string Bodega;
        public decimal PrecioARS;
        public string NombreEtiqueta;
        public string NotaDeCataBodega;
        public string nombre ;
        public List<string> tipoUva;
        public List<string> maridajes;
        public DateOnly añada;
        public VinoInfo(string nombreEtiqueta, string notaDeCataBodega, decimal precioARS,  string bodega, string nombre, List<string> tipoUva, List<string> maridajes, DateOnly añada)
        {
            this.Bodega = bodega;
            this.PrecioARS = precioARS;
            this.NombreEtiqueta = nombreEtiqueta;
            this.NotaDeCataBodega = notaDeCataBodega;
            this.nombre = nombre;
            this.tipoUva = tipoUva;
            this.maridajes = maridajes;
            this.añada = añada;
        }
        public string getBodega()
        {
            return this.Bodega;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public List<string> getTipoUva()
        {
            return this.tipoUva;
        }
        public List<string> getMaridajes()
        {
            return this.maridajes;
        }
        public DateOnly getAñada()
        {
            return this.añada;
        }
        public decimal getPrecio()
        {
            return this.getPrecio();
        }
        public string getNotaCata()
        {
            return this.NotaDeCataBodega;
        }
        public string getNotaEtiqueta()
        {
            return this.NombreEtiqueta.ToString();
        }
    }
    
}
