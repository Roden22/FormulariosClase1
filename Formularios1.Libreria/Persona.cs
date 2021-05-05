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
        private string _estadoCivil;
        private bool _activo;

        public Persona(string nombre, string apellido, string estadoCivil, bool activo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._activo = activo;
            this._estadoCivil = estadoCivil;
        }

        public override string ToString()
        {
            string act = "ACTIVO";
            if (!_activo)
                act = "DESACTIVADO";

            return $"{_apellido}, {_nombre} - {_estadoCivil} ({act}) ";
        }
    }
}
