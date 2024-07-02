using PPAI_CU_5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_5.BaseDeDatos
{
        public class DATOS
        {
        
        Gestor.GestorImortarBodega gestor;
        List<Entidades.Enofilo> enofilos;
        public DATOS(Gestor.GestorImortarBodega gestor)
        {
            this.gestor = gestor;
            enofilos = new List<Enofilo>();
        }


        public void inicializarDatos()
        {
            //inicializacion de tipo de UVA
            TipoUva tipoUva = new TipoUva("Malbec", "Uva tinta emblemática de Argentina, conocida por sus vinos de color profundo y sabor intenso.");
            TipoUva tipoUva2 = new TipoUva("Cabernet Sauvignon", "Variedad tinta internacionalmente reconocida por sus vinos con cuerpo y notas de grosella negra.");
            TipoUva tipoUva3 = new TipoUva("Chardonnay", "Uva blanca popular que produce vinos desde secos hasta espumosos, con notas de manzana y mantequilla.");
            TipoUva tipoUva4 = new TipoUva("Merlot", "Variedad tinta que produce vinos suaves y afrutados, con taninos menos pronunciados que el Cabernet Sauvignon.");
            TipoUva tipoUva5 = new TipoUva("Sauvignon Blanc", "Uva blanca que da vinos frescos y aromáticos, con notas de hierba y frutas cítricas.");
            TipoUva tipoUva9 = new TipoUva("Torrontés", "Uva blanca argentina conocida por sus aromas florales y notas cítricas.");
            TipoUva tipoUva10 = new TipoUva("Petit Verdot", "Uva tinta que agrega color y estructura a los vinos con notas de moras y violetas.");

            // Inicializando varietales
            Varietal varietal1 = new Varietal("Varietal Malbec", 50.0f, tipoUva);
            Varietal varietal2 = new Varietal("Varietal Cabernet Sauvignon", 30.0f, tipoUva2);
            Varietal varietal3 = new Varietal("Varietal Chardonnay", 20.0f, tipoUva3);
            
            // Inicializando maridajes
            Maridaje maridaje1 = new Maridaje("Marida bien con carnes rojas", "Carne Roja");
            Maridaje maridaje2 = new Maridaje("Perfecto para acompañar pescados y mariscos", "Pescado y Mariscos");
            Maridaje maridaje4 = new Maridaje("Ideal con pastas con salsa roja", "Pasta con Salsa Roja");
            Maridaje maridaje5 = new Maridaje("Perfecto con aves de corral", "Aves de Corral");

            //bodegas inicializanda
            Bodega bodega1 = new Bodega("34.6037° S, 58.3816° W", "Bodega en Buenos Aires", DateTime.Now, "Bodega histórica en Buenos Aires", "Bodega Buenos Aires", DateTime.Now.AddMonths(-6));
            Bodega bodega2 = new Bodega("32.8908° S, 68.8272° W", "Bodega en Mendoza", DateTime.Now, "Bodega reconocida por sus Malbecs", "Bodega Mendoza", DateTime.Now.AddMonths(-12));
            // Inicializando vino
            Vino vino1 = new Vino(new DateTime(2020, 5, 1), DateTime.Now, "Etiqueta Malbec", "Malbec 2020", "Notas de frutos rojos y especias.", 1500.0m, bodega1);
            vino1.AñadirVarietal(varietal1);
            vino1.AñadirVarietal(varietal3);
            vino1.AñadirMaridaje(maridaje1);
            Vino vino2 = new Vino(new DateTime(2019, 7, 15), DateTime.Now, "Etiqueta Chardonnay", "Chardonnay 2019", "Notas de manzana y mantequilla.", 1300.0m, bodega2);
            vino2.AñadirVarietal(varietal2);
            vino2.AñadirMaridaje(maridaje2);
            //lista de uvas
            List<TipoUva> tiposUvas = new List<TipoUva> { tipoUva2 , tipoUva3, tipoUva4, tipoUva5, tipoUva9, tipoUva10 };
            gestor.añadirTipoUva(tiposUvas);

            List<Maridaje> maridajes = new List<Maridaje> { maridaje1, maridaje2,maridaje4,maridaje5 };
            gestor.añadirMaridajes(maridajes);


            //lista de vinos
            List<Vino> listaVinos = new List<Vino> { vino1, vino2 };
            //añadir al gestor los vinos
            gestor.añadirVinos(listaVinos);
            // Crear lista de bodegas a partir de los vinos
            List<Bodega> listaBodegas = listaVinos.Select(v => v.bodega).Distinct().ToList();

            // Actualizar bodegas en el gestor
            gestor.bodegasActualizadas(listaBodegas);
            Enofilo enofilo1 = new Enofilo("Perez", "Juan Perez");
            Enofilo enofilo2 = new Enofilo("Garcia", "Maria Garcia");
            Siguiendo siguiendo1 = new Siguiendo(new DateTime(2021, 1, 1), new DateTime(2022, 1, 1), bodega1);
            Siguiendo siguiendo2 = new Siguiendo(new DateTime(2020, 6, 15), new DateTime(2021, 6, 15), bodega2);
            Siguiendo siguiendo3 = new Siguiendo(new DateTime(2022, 3, 20), new DateTime(2023, 3, 20), bodega1);
            enofilo1.AgregarSiguiendo(siguiendo1);
            enofilo1.AgregarSiguiendo(siguiendo2);
            enofilo2.AgregarSiguiendo(siguiendo3);
            this.enofilos.Add(enofilo1);
            this.enofilos.Add(enofilo2);
        }
    }
}
