using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArreglosCola
{
    class Alumnos : Nodo
    {

        public Alumnos[] AgregarAlumnos(Alumnos[] A, int i)
        {
            DiagolBoxCaptura captura = new DiagolBoxCaptura();
            if (captura.ShowDialog() == DialogResult.OK)
            {
                A[i].Numero = int.Parse(captura.numero);
                A[i].Nombre = captura.nombre;
                A[i].Matricula =captura.matricula;
                A[i].materia =captura.matricula;

                MessageBox.Show("Los datos se almacenaron en el arreglo", "Arreglo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                



            }
            return (A);
        }
        public void Mostrar(Alumnos[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Numero != 0)
                {
                    ListViewItem lista = new ListViewItem(A[i].Numero.ToString());
                    lista.SubItems.Add(A[i].nombre);
                    lista.SubItems.Add(A[i].matricula);
                    lista.SubItems.Add(A[i].materia);
                    caja.Items.Add(lista);
                }
            }

        }   
        public Alumnos[] Eliminar(Alumnos [] A)
        {
            bool sw = false;
            DiagolBoxBuscar busca = new DiagolBoxBuscar();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].Nombre == busca.nombre)
                    {
                        sw = true;
                        A[i].Numero = 0;
                        A[i].nombre = "";
                        A[i].Matricula ="";
                        A[i].Materia = "";
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("El dato que se quiere borrar no existe", "Areglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("El producto se elimino de los datos del arreglo", "Arreglo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            return (A);
        }
        public Alumnos[] Modificar (Alumnos[]A)
        {
            bool bl = true;
            DiagolBoxBuscar buscar = new DiagolBoxBuscar();
            DiagolBoxCaptura captura = new DiagolBoxCaptura();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].nombre == buscar.nombre)
                    {
                        bl = false;
                        if (captura.ShowDialog() == DialogResult.OK)
                        {
                            StreamReader sr = new StreamReader("ArchivoAlumnos.txt");
                            A[i].Numero = int.Parse(captura.numero);
                            A[i].Nombre = captura.nombre;
                            A[i].Matricula = captura.matricula;
                            A[i].Materia = captura.materia;
                        }
                    }
                }
                if (bl == true)
                {
                    MessageBox.Show("El alumno que deseas modificar no existe", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Los datos del alumno se modificaron", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            return (A);
        }
    }
}
