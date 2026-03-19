using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace JarasTech.Layers.Entities.DTO
{
    /// <summary>
    /// Clase responsable de consultar datos de un cliente en la API externa de Hacienda por medio de su cédula.
    /// </summary>
    internal class ClienteAPI
    {
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
        /// Busca la información de un cliente utilizando su número de cédula en la API de Hacienda.
        /// </summary>
        /// <param name="cedula">Número de cédula del cliente a buscar.</param>
        /// <returns>
        /// Una tupla que contiene el nombre y los apellidos del cliente.
        /// </returns>
        /// <exception cref="ArgumentException">Se lanza si la cédula es nula o vacía.</exception>
        /// <exception cref="Exception">Se lanza si no se puede obtener o procesar la respuesta de la API.</exception>
        public async Task<(string Nombre, string Apellidos)> BuscarClientePorCedulaAsync(string cedula)
        {
            if (string.IsNullOrEmpty(cedula))
                throw new ArgumentException("La cédula no puede estar vacía.");

            using (HttpClient client = new HttpClient())
            {
                string url = $"https://api.hacienda.go.cr/fe/ae?identificacion={cedula}";
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    throw new Exception("No se pudo obtener los datos. Verifique la cédula e intente de nuevo.");

                string json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<JObject>(json);

                if (data == null)
                    throw new Exception("La respuesta de la API no contiene los datos esperados.");

                string nombreCompleto = data["nombre"]?.ToString();
                if (string.IsNullOrEmpty(nombreCompleto))
                    throw new Exception("No se pudo obtener el nombre del cliente.");

                // Usamos el método utilitario aquí
                var nombreSeparado = SepararNombreApellidos(nombreCompleto);

                return (nombreSeparado.Item1, nombreSeparado.Item2);
            }
        }
    }
}
