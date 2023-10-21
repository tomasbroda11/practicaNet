using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broda.Negocio
{
    public class Validaciones
    {
        public static bool EsCuilValido(string cuil)
        {
            if (cuil.Length != 8)
            {
                return false;   
            }
            string[] prefijosValidos = { "20", "27", "30" };
            string prefijo = cuil.Substring(0, 2);
            if (!prefijosValidos.Contains(prefijo))
            {
                return false;    
            }
            return true;
        }

        public static Entidades.Docente RecuperarUno(string cuil)
        {
            if(EsCuilValido(cuil))
            {
                throw new Exception("El cuil no es valido");
            }
            Datos.Docente datosDocente = new Datos.Docente();
            return datosDocente.RecuperarUno(cuil);
        }
    }
}
