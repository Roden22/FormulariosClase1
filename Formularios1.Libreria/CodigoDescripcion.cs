using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios1.Libreria
{
    public class CodigoDescripcion
    {
        private string _descripcion;
        private int _codigo;

        public CodigoDescripcion(int cod, string desc)
        {
            _descripcion = desc;
            _codigo = cod;
        }

        public string Descripcion { get => _descripcion;  }
        public int Codigo { get => _codigo;  }
    }
}
