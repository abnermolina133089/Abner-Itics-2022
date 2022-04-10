using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCursoGit
{
    class Registros
    {
        string nombre;
        string apellido;
        double edad;

        public Registros(string nombre, string apellido, double edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Edad { get => edad; set => edad = value; }
    }
}
