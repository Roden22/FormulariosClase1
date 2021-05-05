using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios1.Libreria
{
    public static class EstadoCivilHelper
    {

        public static List<CodigoDescripcion> GetLista()
        {
            List<CodigoDescripcion> lst = new List<CodigoDescripcion>();

            CodigoDescripcion seleccione = new CodigoDescripcion(0, "SELECCIONE");
            CodigoDescripcion soltero = new CodigoDescripcion(1, "SOLTERO");
            CodigoDescripcion casado = new CodigoDescripcion(2, "CASADO");

            lst.Add(seleccione);
            lst.Add(casado);
            lst.Add(soltero);

            return lst;
        }
    }
}
