using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace jara_s_Veterinary.Layers.JSON
{
    /// <summary>
    /// Contiene métodos y clases para la obtención de información geográfica (provincias, cantones, distritos)
    /// y procesamiento de nombres completos.
    /// </summary>
    internal class Direcciones
    {
        /// <summary>
        /// Obtiene una lista de provincias desde un recurso JSON remoto.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Provincia"/>.</returns>
        public static async Task<List<Provincia>> GetProvinciasAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/lateraluz/Datos/master/provincias.json");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<List<Provincia>>(json);
                }
                return new List<Provincia>();
            }
        }
        /// <summary>
        /// Obtiene una lista de cantones desde un recurso JSON remoto.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Canton"/>.</returns>
        public static async Task<List<Canton>> GetCantonesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/lateraluz/Datos/master/cantones.json");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Canton>>(json);
                }
                return new List<Canton>();
            }
        }
        /// <summary>
        /// Representa una provincia con identificador y descripción.
        /// </summary>
        public class Provincia
        {
            public int IdProvincia { get; set; }
            public string Descripcion { get; set; }

            public override string ToString()
            {
                return Descripcion.ToString();
            }
        }

        /// <summary>
        /// Representa un cantón con identificador, provincia asociada y descripción.
        /// </summary>
        public class Canton
        {
            public int IdCanton { get; set; }
            public int IdProvincia { get; set; }
            public string Descripcion { get; set; }
            public override string ToString()
            {
                return Descripcion.ToString();
            }
        }
        /// <summary>
        /// Separa un nombre completo en nombres y apellidos según una lógica común.
        /// </summary>
        /// <param name="nombreCompleto">Cadena con el nombre completo.</param>
        /// <returns>Tupla con los nombres y apellidos por separado.</returns>
        /// <exception cref="ArgumentException">Se lanza si el nombre no tiene el formato esperado.</exception>
        public static Tuple<string, string> SepararNombreApellidos(string nombreCompleto)
        {
            var partes = nombreCompleto.Split(' ');
            if (partes.Length >= 4)
            {
                var nombres = $"{partes[0]} {partes[1]}";
                var apellidos = $"{partes[2]} {partes[3]}";
                return Tuple.Create(nombres, apellidos);
            }
            else if (partes.Length == 3)
            {
                var nombres = $"{partes[0]} {partes[1]}";
                var apellidos = partes[2];
                return Tuple.Create(nombres, apellidos);
            }
            else if (partes.Length == 2)
            {
                var nombres = partes[0];
                var apellidos = partes[1];
                return Tuple.Create(nombres, apellidos);
            }
            else
            {
                throw new ArgumentException("El nombre completo no tiene el formato esperado.");
            }
        }
        /// <summary>
        /// Representa un distrito con identificador, cantón asociado y descripción.
        /// </summary>
        public class Distrito
        {
            public int IdDistrito { get; set; }
            public int IdCanton { get; set; }
            public string Descripcion { get; set; }
            public override string ToString()
            {
                return Descripcion.ToString();
            }
        }
        /// <summary>
        /// Obtiene una lista de distritos desde un recurso JSON remoto.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Distrito"/>.</returns>
        public static async Task<List<Distrito>> GetDistritosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/lateraluz/Datos/master/distritos.json");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Distrito>>(json);
                }
                return new List<Distrito>();
            }
        }
    }
}
