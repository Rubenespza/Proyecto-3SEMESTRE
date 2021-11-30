using System;
using System.Threading.Tasks;

namespace Colas_dobles_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDoble i = new ListaDoble();
            int opcionMenu = 0;
            do
            {
                System.Console.WriteLine("|-----------------------------|");
                System.Console.WriteLine("|     * Concepto de Cola *    |");
                System.Console.WriteLine("|---------------|-------------|");
                System.Console.WriteLine("| 1. Encolar    | 5. Lista PU |");
                System.Console.WriteLine("| 2. Buscar     | 6. Lista UP |");
                System.Console.WriteLine("| 3. Modificar  | 7. Finalizar|");
                System.Console.WriteLine("| 4. Desencolar |             |");
                System.Console.WriteLine("|---------------|-------      |");
                System.Console.WriteLine("|     Selecciona una Opcion   |");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n\n Encolar un nodo en la cola \n");
                        i.Encolar();
                        break;
                    case 2:
                        Console.WriteLine("\n\n Buscar un nodo en la cola \n");
                        i.Buscar();
                        break;
                    case 3:
                        Console.WriteLine("\n\n Modificar un nodo en la cola \n");
                        i.Modificar();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Desencolar un nodo en la cola \n");
                        i.Desencolar();
                        break;
                    case 5:
                        Console.WriteLine("\n\n Mostrar cola de nodos \n");
                        i.desplegarListaPU();
                        break;
                    case 6:
                        Console.WriteLine("\n\n Mostrarcola de nodos.... \n");
                        i.desplegarListaUP();
                        break;
                    case 7:
                        Console.WriteLine("\n\n Programa Finalizado.... \n");
                        break;
                    default:
                        Console.WriteLine("\n\n Opcion No Valida.... \n");
                        break;
                }
            } while (opcionMenu != 7);
            //c.Guardar("ListaCola.txt");
        }
    }
} 
