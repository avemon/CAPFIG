using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("PARALELOGRAMO");
            comboBox1.Items.Add("CUADRADO");
            comboBox1.Items.Add("RECTANGULO");
            comboBox1.Items.Add("ROMBO");
            comboBox1.Items.Add("ROMBOIDE");
            comboBox1.Items.Add("TRAPECIO");
            comboBox1.SelectedIndex = 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ServiciosTriangulos.CalculadoraTriangulosClient cliente = new ServiciosTriangulos.CalculadoraTriangulosClient();
            double result = cliente.Ejecutar(radioButton1.Checked, (double)numericUpDown1.Value, (double)numericUpDown2.Value, (double)numericUpDown3.Value);
            label5.Text = "" + result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            double result = cliente.Ejecutar(radioButton4.Checked, comboBox1.Text, (double)numericUpDown6.Value, (double)numericUpDown5.Value, (double)numericUpDown4.Value);
            label6.Text = "" + result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            double result = cliente.Ejecutar(radioButton6.Checked, (int)numericUpDown8.Value, (double)numericUpDown7.Value);
            label12.Text = "" + result;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
