using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosCola
{
    class Nodo 
    {
  
        public int Numero;
        public string Nombre;
        public string Matricula;
        public string Materia;

        public int numero
        {
            set { value = Numero; }
            get { return (Numero); }

        }

        public string nombre
        {
            set { value = Nombre; }
            get { return (Nombre); }
        }

        public string matricula
        {
            set { value = Matricula; }
            get { return (Matricula); }

        }

        public string materia
        {
            set { value = Materia; }
            get { return (Materia); }
        }
        public Nodo()
        {
            numero = 0;
            nombre = "";
            matricula = "";
            materia = "";
        }
    }
}
