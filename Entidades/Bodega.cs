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

    }
}
