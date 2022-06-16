using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1Ejercicio1
{
    public partial class Form1 : Form
    {
        int Contador = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            string ScrollValue = Convert.ToString(hScrollBar1.Value);
            LabelValor.Text = ScrollValue;
        }
        
        private void inicioTimer_Click(object sender, EventArgs e)
        {
            Contador = 1;
            if (hScrollBar1.Value == 0)
            {
                MessageBox.Show("Ingresar un valor en el rango de 1 a 5 segundos");
            }
            else
            {
                timer.Start();
            }

        }

        private void finTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int ScrollValue = hScrollBar1.Value;
            if (Contador <= ScrollValue)
            {
                Random random_number = new Random();
                LabelContar.Text = Convert.ToString(Contador);
                LabelRandom.Text = Convert.ToString(random_number.Next(100));
                Contador++;
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
