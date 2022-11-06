using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine_Grupo10
{
    internal class Personas
    {
        //Atributos
        private string nombre;
        private string apellido;
        private int identificacion;


        //Constructor
        public Personas()
        {
            Nombre = "";
            Apellido = "";
            Identificacion = 0;
        }

        public Personas(string nombre, string apellido, int identificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
        }


        //Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Identificacion { get; set; }
    }
}
