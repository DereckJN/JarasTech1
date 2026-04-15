using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace JarasTech.Layers.Util
{
    /// <summary>
    /// Utilidades compartidas para la generación de PDFs:
    ///   - Obtener el logo de la empresa como byte[]
    ///   - Convertir un monto decimal a letras en español
    /// </summary>
    public static class PDFHelper
    {
        // ════════════════════════════════════════════════════════════════
        // LOGO — devuelve el logo de Resources como PNG bytes para QuestPDF
        // ════════════════════════════════════════════════════════════════
        /// <summary>
        /// Lee el logo JarasTech desde Resources y lo devuelve como byte[] PNG.
        /// Devuelve null si no se puede cargar.
        /// </summary>
        public static byte[] ObtenerLogoBytes()
        {
            try
            {
                Image logo = Properties.Resources.Logo_JarasTech;
                if (logo == null) return null;
                using (var ms = new MemoryStream())
                {
                    logo.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch
            {
                return null;
            }
        }

        // ════════════════════════════════════════════════════════════════
        // NÚMERO A LETRAS — español, colones costarricenses
        // ════════════════════════════════════════════════════════════════
        /// <summary>
        /// Convierte un monto decimal a su representación en letras.
        /// Ejemplo: 15250.75 → "Quince mil doscientos cincuenta colones con 75/100"
        /// </summary>
        public static string MontoALetras(decimal monto)
        {
            try
            {
                long entero = (long)Math.Truncate(monto);
                int centavos = (int)Math.Round((monto - entero) * 100);

                string letrasEntero = NumeroALetras(entero);
                string moneda = entero == 1 ? "colón" : "colones";

                if (centavos > 0)
                    return letrasEntero + " " + moneda + " con " + centavos.ToString("00") + "/100";
                else
                    return letrasEntero + " " + moneda + " exactos";
            }
            catch
            {
                return monto.ToString("N2") + " colones";
            }
        }

        // ── Núcleo de conversión ────────────────────────────────────────
        private static readonly string[] Unidades =
        {
            "", "un", "dos", "tres", "cuatro", "cinco",
            "seis", "siete", "ocho", "nueve", "diez",
            "once", "doce", "trece", "catorce", "quince",
            "dieciséis", "diecisiete", "dieciocho", "diecinueve"
        };

        private static readonly string[] Decenas =
        {
            "", "diez", "veinte", "treinta", "cuarenta",
            "cincuenta", "sesenta", "setenta", "ochenta", "noventa"
        };

        private static readonly string[] Centenas =
        {
            "", "ciento", "doscientos", "trescientos", "cuatrocientos",
            "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"
        };

        private static string NumeroALetras(long numero)
        {
            if (numero == 0) return "cero";
            if (numero < 0) return "menos " + NumeroALetras(-numero);

            if (numero < 20) return Unidades[numero];
            if (numero < 100) return Decenas[numero / 10] +
                (numero % 10 > 0 ? " y " + Unidades[numero % 10] : "");
            if (numero == 100) return "cien";
            if (numero < 1000)
            {
                string resto = numero % 100 > 0 ? " " + NumeroALetras(numero % 100) : "";
                return Centenas[numero / 100] + resto;
            }
            if (numero < 2000)
                return "mil" + (numero % 1000 > 0 ? " " + NumeroALetras(numero % 1000) : "");
            if (numero < 1000000)
            {
                long miles = numero / 1000;
                long resto = numero % 1000;
                return NumeroALetras(miles) + " mil" +
                    (resto > 0 ? " " + NumeroALetras(resto) : "");
            }
            if (numero < 2000000)
                return "un millón" + (numero % 1000000 > 0
                    ? " " + NumeroALetras(numero % 1000000) : "");
            if (numero < 1000000000L)
            {
                long millones = numero / 1000000;
                long resto = numero % 1000000;
                return NumeroALetras(millones) + " millones" +
                    (resto > 0 ? " " + NumeroALetras(resto) : "");
            }
            if (numero < 2000000000L)
                return "un mil millones" + (numero % 1000000000L > 0
                    ? " " + NumeroALetras(numero % 1000000000L) : "");

            long miles2 = numero / 1000000000L;
            long rest2 = numero % 1000000000L;
            return NumeroALetras(miles2) + " mil millones" +
                (rest2 > 0 ? " " + NumeroALetras(rest2) : "");
        }

        /// <summary>
        /// Devuelve la primera letra en mayúscula.
        /// </summary>
        public static string Capitalizar(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return texto;
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }
    }
}