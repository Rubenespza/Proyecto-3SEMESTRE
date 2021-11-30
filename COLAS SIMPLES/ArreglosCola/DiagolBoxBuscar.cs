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
    public partial class DiagolBoxBuscar : Form
    {
        public DiagolBoxBuscar()
        {
            InitializeComponent();
        }
        public string nombre
        {
            get { return (textBox1.Text); }
        }
        private void DiagolBoxBuscar_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
