using System;
using System.Configuration;
using System.Text;

/// <summary>
/// Clase encargada de construir cadenas de conexión a bases de datos a partir de la configuración en el archivo app.config.
/// </summary>
class FactoryConexion
{
    /// <summary>
    /// Crea una cadena de conexión utilizando la configuración predeterminada en el app.config.
    /// </summary>
    /// <exception cref="Exception">
    /// Se lanza si no existen entradas en ConnectionStrings o si no se encuentra la clave 
    /// "JarasTech.Properties.Settings.Cadena".
    /// </exception>
    /// <returns>
    /// Una cadena de conexión basada en la entrada de configuración especificada.
    /// </returns>
    public static string CreateConnection()
    {

        StringBuilder conexion = new StringBuilder();
        bool existe = false;

        // Validacion de la conexion
        if (ConfigurationManager.ConnectionStrings.Count == 0)
        {
            throw new Exception("No existen registradas ConnectionStrings en el archivo app.config, revise!");
        }

        for (int i = 0; i <= ConfigurationManager.ConnectionStrings.Count -1 ; i++)
        {
            if (ConfigurationManager.ConnectionStrings[i].Name.Equals("JarasTech.Properties.Settings.Cadena", StringComparison.InvariantCultureIgnoreCase))
                existe = true;
        }

        if (!existe)
        {
            throw new Exception("No existe registrada en ConnectionStrings del app.config el Key JarasTech.Properties.Settings.Cadena!");
        }


        // Lee la conexion JarasTech.Properties.Settings.Cadena
        conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["JarasTech.Properties.Settings.Cadena"].ConnectionString);
        
        return conexion.ToString();
    }
    /// <summary>
    /// Crea una cadena de conexión agregando un usuario y contraseña a la configuración base.
    /// </summary>
    /// <param name="pUsuario">Nombre de usuario para la autenticación.</param>
    /// <param name="pContrasena">Contraseña para la autenticación.</param>
    /// <exception cref="Exception">
    /// Se lanza si no existen entradas en ConnectionStrings o si no se encuentra la clave 
    /// "JarasTech.Properties.Settings.Cadena".
    /// </exception>
    /// <returns>
    /// Una cadena de conexión con autenticación personalizada (usuario y contraseña).
    /// </returns>
    public static string CreateConnection(string pUsuario, String pContrasena)
    {
        
        StringBuilder conexion = new StringBuilder();
        bool existe = false;

        // Validacion de la conexion
        if (ConfigurationManager.ConnectionStrings.Count == 0) {
            throw new Exception("No existen registradas ConnectionStrings en el archivo app.config, revise!");
        }

        for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count -1; i++)
        {
            if (ConfigurationManager.ConnectionStrings[i].Name.Equals("JarasTech.Properties.Settings.Cadena", StringComparison.InvariantCultureIgnoreCase))
                existe = true;
        }

        if (!existe) {
            throw new Exception("No existe registrada en ConnectionStrings del app.config el Key JarasTech.Properties.Settings.Cadena!");
        }


        // Lee la conexion JarasTech.Properties.Settings.Cadena
        conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["JarasTech.Properties.Settings.Cadena"].ConnectionString);
        // Agrega al usuario
        conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
        return conexion.ToString();
    }
    /// <summary>
    /// Crea una cadena de conexión utilizando un nombre específico de cadena en app.config, 
    /// incluyendo autenticación personalizada.
    /// </summary>
    /// <param name="pUsuario">Nombre de usuario para la autenticación.</param>
    /// <param name="pContrasena">Contraseña para la autenticación.</param>
    /// <param name="pConexion">Nombre de la cadena de conexión en app.config.</param>
    /// <exception cref="Exception">
    /// Se lanza si no existen entradas en ConnectionStrings o si no se encuentra la clave especificada.
    /// </exception>
    /// <returns>
    /// Una cadena de conexión personalizada con el nombre de configuración y credenciales proporcionados.
    /// </returns>
    public static string CreateConnection(string pUsuario, String pContrasena, string pConexion)
    {

        StringBuilder conexion = new StringBuilder();
        bool existe = false;
        // Validacion de la conexion
        if (ConfigurationManager.ConnectionStrings.Count == 0)
        {
            throw new Exception("No existen registradas ConnectionStrings en el archivo app.confi, revise!");
        }

        for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count - 1; i++)
        {
            if (ConfigurationManager.ConnectionStrings[i].Name.Equals(pConexion, StringComparison.InvariantCultureIgnoreCase))
                existe = true;
        }

        if (!existe)
        {
            throw new Exception("No existe registrada en ConnectionStrings del app.config el Key JarasTech.Properties.Settings.Cadena!");
        }


        // Lee la conexion JarasTech.Properties.Settings.Cadena
        conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings[pConexion].ConnectionString);
        // Agrega al usuario
        conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);
        return conexion.ToString();
    }

}

