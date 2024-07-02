using PPAI_CU_5.Interfacez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPAI_CU_5.Entidades
{
    public class Enofilo
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        private List<Siguiendo> Siguiendo { get; set; }

        public Enofilo(string apellido, string imagenPerfil, string nombre)
        {
            Apellido = apellido;
            Nombre = nombre;
            Siguiendo = new List<Siguiendo>();
        }
        public void AgregarSiguiendo(Siguiendo siguiendo)
        {
            Siguiendo.Add(siguiendo);
        }

        public List<Siguiendo> ObtenerSiguiendo()
        {
            return Siguiendo;
        }
        public void seguisAbodega(Bodega bodega)
        {
            foreach(var siguiendo in Siguiendo)
            {
                siguiendo.sosBodega(bodega);
            }
        }
    }
}