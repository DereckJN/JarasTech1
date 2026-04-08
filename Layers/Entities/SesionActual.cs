using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarasTech.Layers.Entities
{
    internal class SesionActual
    {
        public static Usuarios Usuario { get; set; }

        public static bool IsLoggedIn => Usuario != null;

        public static int PerfilID => Usuario?.PerfilID ?? 0;

        public static string NombrePerfil => Usuario?.NombrePerfil ?? "";
    }
}
