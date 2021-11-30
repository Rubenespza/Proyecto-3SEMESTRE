using System;
using System.Collections.Generic;
using System.Text;


namespace Colas_dobles_Consola
{
    class ListaDoble
    {
        private Nodos inicio = new Nodos();
        private Nodos final = new Nodos();

        public ListaDoble()
        {
            inicio = null;
            final = null;
        }
        public void Encolar()
        {
            // coladoble listas = null  <- 12 -> <- 45 -> <- 67 -> <- 16 -> null
            // Nuevo = 16
            // 12, 45, 67, 16   .... inicio   coladoble final
            // inicio = 12      final = 16
            Nodos nuevos = new Nodos();
            Console.Write("Igrese el dato que ingresa el dato del nuevo nodo");
            nuevos.Dato = int.Parse(Console.ReadLine());
            if(inicio == null)
            {
                inicio = nuevos;
                inicio.Siguiente = null;
                inicio.Atras = null;
                final = inicio;
            }
            else
            {
                final.Siguiente = nuevos;
                nuevos.Siguiente = null;
                nuevos.Atras = final;
                final = nuevos;
            }
            Console.Write("\n Nuevo nodo ingresado \n");
        }
        public void Buscar()
        {
            Nodos actual = new Nodos();
            actual = inicio;
            bool encontrado = false;
            Console.Write("\n Ingrese el nodo que quiere buscar \n");
            int buscado = int.Parse(Console.ReadLine());
            while ( actual != null && encontrado == false)
            {
                if(actual.Dato == buscado)
                {
                    Console.WriteLine("\n Nodo con el dato ({0}) encontrado \n",  actual.Dato);
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }
            if(!encontrado)
            {
                Console.WriteLine("\n Nodo no encontrado \n"); 
            }
        }
        public void Modificar()
        {
            Nodos actual = new Nodos();
            actual = inicio;
            bool encontrado = false;
            Console.Write("\n Ingrese el nodo que quiere modificar \n");
            int buscado = int.Parse(Console.ReadLine());
            while (actual != null && encontrado == false)
            {
                if (actual.Dato == buscado)
                {
                    Console.WriteLine("\n Nodo con el dato ({0}) encontrado \n", actual.Dato);
                    Console.Write("\n Ingresa el nuevo dato del nodo \n");
                    actual.Dato = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n Nodo modificado \n");
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }
            if (!encontrado)
            {
                Console.WriteLine("\n Nodo no encontrado \n");
            }
        }
        public void Desencolar()
        {
            Nodos actual = new Nodos();
            Nodos anterior = new Nodos();
            actual = inicio;
            bool encontrado = false;
            Console.Write("\n Ingrese el nodo que quiere eliminar \n");
            int buscado = int.Parse(Console.ReadLine());
            while (actual != null && encontrado == false)
            {
                if (actual.Dato == buscado)
                {
                    if(actual == inicio)
                    {
                        inicio = inicio.Siguiente;
                        inicio.Atras = null;
                    }
                    else if(actual == final)
                    {
                        anterior.Siguiente = null;
                        final = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Atras = anterior;
                    }
                    Console.WriteLine("\n Nodo con el dato ({0}) ha sido eliminado \n", actual.Dato);
                    encontrado = true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
            if (!encontrado)
            {
                Console.WriteLine("\n Nodo no encontrado \n");
            }
        }
        public void desplegarListaPU()
        {
            Nodos actuales = new Nodos();
            actuales = inicio;
            while (actuales != null)
            {
                Console.WriteLine("" + actuales.Dato);
                actuales = actuales.Siguiente;
            }
        }
        public void desplegarListaUP()
        {
            Nodos actuales = new Nodos();
            actuales = final;
            while(actuales != null)
            {
                Console.WriteLine("" + actuales.Dato);
                actuales = actuales.Atras;

            }
        }
    }
}
