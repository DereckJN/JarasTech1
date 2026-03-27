
using JarasTech.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Persistencia
{
    /// <summary>
    /// Clase responsable de consumir el servicio web del BCCR para obtener datos del tipo de cambio del dólar.
    /// </summary>
    internal class ServiceBCCR
    {
        //Agregar los credenciales para el uso del consumo API del Dolar BCCR
        private readonly string TOKEN = "O4LCC4KA97";
        private readonly string NOMBRE = "Dereck";
        private readonly string CORREO = "jaradereck1@gmail.com";
        /// <summary>
        /// Obtiene los valores del tipo de cambio del dólar (compra o venta) entre dos fechas usando el servicio web del BCCR.
        /// </summary>
        /// <param name="pFechaInicial">Fecha inicial del rango de consulta.</param>
        /// <param name="pFechaFinal">Fecha final del rango de consulta.</param>
        /// <param name="pCompraoVenta">
        /// Indicador del tipo de cambio a consultar:
        /// <c>"c"</c> para compra (código 317), cualquier otro valor para venta (código 318).
        /// </param>
        /// <returns>
        /// Una colección de objetos <c>Dolar</c> que contienen la información de tipo de cambio obtenida del servicio.
        /// </returns>
        /// <exception cref="Exception">
        /// Se lanza si el servicio devuelve un error en el contenido de las filas del <c>DataTable</c>.
        /// </exception>
        public IEnumerable<Dolar> GetDolar(DateTime pFechaInicial, DateTime
       pFechaFinal, String pCompraoVenta)
        {
            //Se crean las variables a utilizar
            List<Dolar> lista = new List<Dolar>();
            DataSet dataset = null;
            string fecha_inicial, fecha_final;
            string tipoCompraoVenta;
            // Se convierten las fechas a string en el formato solicitado
            fecha_inicial = pFechaInicial.ToString("dd/MM/yyyy");
            fecha_final = pFechaFinal.ToString("dd/MM/yyyy");
            // se compara si es compra (317) o venta (318)
            tipoCompraoVenta = pCompraoVenta.Equals("c", StringComparison.InvariantCulture) ? "317" : "318";

            // Protocolo de comunicaciones
            System.Net.ServicePointManager.SecurityProtocol =
           System.Net.SecurityProtocolType.Tls12;
            // Se instancia al Servicio Web
            JarasTech.BCCR.wsindicadoreseconomicosSoapClient client =
            new
           JarasTech.BCCR.wsindicadoreseconomicosSoapClient("wsindicadoreseconomicosSoap12");
            // Se invoca.
            dataset = client.ObtenerIndicadoresEconomicos(tipoCompraoVenta,
           fecha_inicial, fecha_final, NOMBRE, "N", CORREO, TOKEN);
            //Se carga el taset
            DataTable table = dataset.Tables[0];
            //Se recorre el dataset
            foreach (DataRow row in table.Rows)
            {
                // Validar el error. No es la forma correcta pero bueno.
                if (row[0].ToString().Contains("error"))
                {
                    throw new Exception(row[0].ToString());
                }
                //Se asignan lso valores a la clase de tipo dolar
                Dolar dolar = new Dolar();
                dolar.Codigo = row[0].ToString();
                dolar.Fecha = DateTime.Parse(row[1].ToString());
                dolar.Monto = Convert.ToDouble(row[2].ToString());
                lista.Add(dolar);
            }
            //Se retorna la lista
            return lista;
        }

    }
}

