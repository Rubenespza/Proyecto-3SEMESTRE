using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cola_Circular
{
    internal class ColaCirc<T>
    {
        T[] datos;
        int tam, P, U;
        bool most;

        public ColaCirc(int n)
        {
            tam = n;
            datos = new T[tam];
            P = U = -1;
        }

        public bool insertar(T dato)
        {
            most = true;
            if ((U == tam - 1) && (P == 0) || (U + 1 == P))

                return false;

            else if (U == tam - 1)
                U = 0;
            else
                U++;
            datos[U] = dato;
            if (P == -1)
                P = 0;
            return true;

        }


        public bool eliminar(ref T dato, T x)
        {
            most = false;
            if (P == -1)
                return false;

            dato = datos[P];
            if (P == U)//Hay un solo elemento
                P = U = -1;
            else if (P == tam - 1)
            {
                datos[P] = x;
                P = 0;
            }
            else
            {
                datos[P] = x;
                P++;
            }
            return true;

        }

        public bool esta_vacia()
        {
            return (P == -1);
        }

        public bool esta_llena()
        {
            return (((U + 1) % tam) == P);
        }
        public int u
        {
            get { return U; }
        }
        public int p
        {
            get { return P; }
        }
        public T this[int indice]
        {
            get
            {

                return datos[indice];
            }
            set
            {

                datos[indice] = value;
            }
        }

        public void mostrar(DataGridView dgv)
        {
            try
            {
                if (most == true)
                {
                    if (U + 1 == tam)
                    {
                        dgv[U, 0].Value = "  ";
                    }
                    else
                    {
                        dgv[U, 0].Value = "  ";
                    }
                    dgv[U, 0].Value = datos[U].ToString();

                }
                else
                    dgv[p - 1, 0].Value = "   ";

                dgv[P, 0].Value = datos[P].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Fuera del rango");

            }
        }
    }
}
  