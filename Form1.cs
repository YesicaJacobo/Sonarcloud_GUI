using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonarCloud_GUI
{
    public partial class Form1 : Form
    {
        public int segundos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int año, edad;

            año = Convert.ToInt32(textBox1.Text);

            if (año <= 2021)
            {
                edad = 2021 - año;
                textBox1.BackColor = Color.Aquamarine;
                textBox1.Text = "";
                label2.Text = "Su edad es: " + edad;
                timer1.Enabled = true;
            }
            else 
            {
                label2.Text = "Año incorrecto";
                textBox1.BackColor = Color.Red;
                timer1.Enabled = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 10)
            {
                timer1.Enabled = false;
                textBox1.BackColor = Color.Aquamarine;
                textBox1.Text = "";
                label2.Text = "Introduce tu año de nacimiento";
                segundos = 0;
            }
        }
    }
}
