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
    public partial class DiagolBoxCaptura : Form
    {
        public DiagolBoxCaptura()
        {
            InitializeComponent();
        }

        public string numero
        {
            get { return (textBox1.Text); }
        }
        public string nombre
        {
            get { return (textBox2.Text); }
        }
        public string matricula
        {
            get { return (textBox3.Text); }
        }
        public string materia
        {
            get { return (textBox4.Text); }
        }

        private void DiagolBoxCaptura_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
