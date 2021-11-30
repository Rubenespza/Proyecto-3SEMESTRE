using System;
using System.Collections.Generic;
using System.Text;

namespace Colas_dobles_Consola
{
    class Nodos
    {
        private int dato;
        private Nodos siguiente;
        private Nodos atras;

        public int Dato
        {
            get{ return dato; }
            set { dato = value; }
        }
        public Nodos Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodos Atras
        {
            get { return atras; }
            set { atras = value; }
        }

    }
}
