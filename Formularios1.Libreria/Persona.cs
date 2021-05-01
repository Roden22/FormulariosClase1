using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios1.Libreria
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public override string ToString()
        {
            return $"{_apellido}, {_nombre}";
        }
    }
}
