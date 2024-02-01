using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personas
{
    internal class Personas
    {
        String dpi;
        String nombre;
        String apellido;
        DateTime fecNac;

        //Encapsulado
        public string Dpi { get => Dpi; set => Dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fecNac; set => fecNac = value; }


        public int Edad()
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - fecNac.Year;

            if (ahora.Month < fecNac.Month || (ahora.Month == fecNac.Month && ahora.Day < fecNac.Day))
            {
                edad--;
            }

            return edad;
        }

        // Normalizar el nombre según las especificaciones dadas
        public string NormalizarNombre()
        {
            string nombreNormalizado = "";

            // Eliminar espacios en blanco extra y caracteres no alfabéticos
            string nombreSinEspacios = nombre.Trim();
            foreach (char caracter in nombreSinEspacios)
            {
                if (char.IsLetter(caracter) || char.IsWhiteSpace(caracter))
                {
                    nombreNormalizado += caracter;
                }
            }

            // Dividir el nombre en palabras y formatear cada palabra
            string[] palabras = nombreNormalizado.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(palabras[i]))
                {
                    palabras[i] = palabras[i].ToLower(); // Convertir a minúsculas
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1); // Primer letra mayúscula
                }
            }

            // Unir las palabras formateadas
            nombreNormalizado = string.Join(" ", palabras);

            return nombreNormalizado;
        }

    }
}
