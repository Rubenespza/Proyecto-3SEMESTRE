using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola_Circular
{
    public partial class Form1 : Form
    {
        double aux2;
        char aux3;
        string aux4;
        string extraer;
        int n, aux1;
        int i = 0;
        bool band = true;
        ColaCirc<int> ent;
        ColaCirc<double> dob;
        ColaCirc<char> cha;
        ColaCirc<string> str;
        public Form1()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            switch (s)
            {
                case "Int":
                    try
                    {
                        aux1 = Convert.ToInt32(textBox2.Text);
                        band = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingrese un entero");
                        band = false;
                    }
                    if (band == true)
                    {
                        if (ent.insertar(aux1))
                            ent.mostrar(dgv1);
                        else
                            MessageBox.Show("Cola llena,Desbordamiento");


                    }
                    break;
                case "Double":
                    try
                    {
                        aux2 = Convert.ToDouble(textBox2.Text);
                        band = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingrese un doble");
                        band = false;
                    }
                    if (band == true)
                    {

                        if (dob.insertar(aux2))
                            dob.mostrar(dgv1);

                        else
                            MessageBox.Show("Cola llena,Desbordamiento");
                    }
                    break;
                case "Char":
                    try
                    {
                        aux3 = Convert.ToChar(textBox2.Text);
                        band = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingrese un entero");
                        band = false;
                    }
                    if (band == true)
                    {

                        if (cha.insertar(aux3))
                            cha.mostrar(dgv1);

                        else

                            MessageBox.Show("Cola llena,Desbordamiento");


                    }
                    break;
                case "String":

                    if (ent.insertar(aux1))
                        str.mostrar(dgv1);

                    else
                        MessageBox.Show("Cola llena,Desbordamiento");
                    break;
            }
            textBox2.Clear();
            textBox2.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            switch (s)
            {
                case "Int":
                    aux1 = 0;
                    if (ent.eliminar(ref aux1, -1))
                    {
                        label5.Text = aux1.ToString();
                        ent.mostrar(dgv1);
                    }
                    else
                        MessageBox.Show("Cola vacia,Subdesbordamiento");
                    break;
                case "Double":
                    aux2 = 0.0;
                    if (dob.eliminar(ref aux2, 0.0))
                    {
                        label5.Text = aux2.ToString();
                        dob.mostrar(dgv1);
                    }
                    else
                        MessageBox.Show("Cola vacia,Subdesbordamiento");
                    break;
                case "Char":
                    aux3 = ' ';
                    if (cha.eliminar(ref aux3, ' '))
                    {
                        label5.Text = aux3.ToString();
                        cha.mostrar(dgv1);
                    }
                    else
                        MessageBox.Show("Cola vacia,Subdesbordamiento");
                    break;
                case "String":

                    aux4 = " ";
                    if (str.eliminar(ref aux4, " "))
                    {
                        label5.Text = aux4.ToString();
                        str.mostrar(dgv1);
                    }
                    else
                        MessageBox.Show("Cola vacia,Subdesbordamiento");
                    break;
            }
    }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                try
                {
                    n = Convert.ToInt32(textBox1.Text);
                    dgv1.ColumnCount = n;
                    textBox2.Enabled = true;
                    button2.Enabled = true;
                    button2.Enabled = true;
                    textBox1.Enabled = false;
                    comboBox1.Enabled = false;
                    textBox2.Focus();
                    for (int i = 0; i < n; i++)
                    {
                        dgv1[i, 0].Value = " ";
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Ingrese un numero");
                }
                string s = comboBox1.Text;
                switch (s)
                {
                    case "Int": ent = new ColaCirc<int>(n); break;
                    case "Double": dob = new ColaCirc<double>(n); break;
                    case "Char": cha = new ColaCirc<char>(n); break;
                    case "String": str = new ColaCirc<string>(n); break;

                    default: ent = new ColaCirc<int>(n); break;
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private static void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}





