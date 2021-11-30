using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosCola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Alumnos[] A;
        Alumnos x = new Alumnos();
        int cont = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            A = new Alumnos[5];
            for (int i = 0; i < A.Length; i++)
            {
                DialogResult dialogResult2 = (MessageBox.Show("coLA LLENA,llena"));
                DialogResult dialogResult1 = DialogResult;
                
            }

            {
                //A[i] = new Alumnos();
            }
        }

        private void agregarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = x.AgregarAlumnos(A, cont);
            cont++;
        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            x.Mostrar(A, listView1);
        }

        private void eliminarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            A = x.Eliminar(A);
            x.Mostrar(A, listView1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            A = x.Modificar(A);
            x.Mostrar(A, listView1);
        }
    }
}
