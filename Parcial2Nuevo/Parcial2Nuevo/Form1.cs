using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Nuevo
{
    public partial class Form1 : Form 
    {
        public int BuscarMaximo(int ContadorVenta)
        {
            int i=0;
            bool salir = false;
                
            while (salir!=true&&i<98) //busqueda de maximo
            {
                if(matrixImporte[ContadorVenta,i]==1000000) //valor buscado
                {
                    salir = true;
                }
                i++;
            }
            if (i>96)
            {
                i = 0;
                return i;
            }
            else
            {
                return i;
            }            
        }
        public int Contador = 0;
        public int ContadorVenta = 0;
        bool VentaFinalizada = false;
        public string[,] matrixNombreCliente = new string[100, 100];
        public float[,] matrixImporte = new float[100,100];
        public string[,] matrixConcepto = new string[100, 100];
        private void initListView()
        {
            ListViewData.Columns.Add("Detalle", 150);
            ListViewData.Columns.Add("Importe", 100);
            ListViewData.View = View.Details;
        }
        private void initListView2()
        {
            ListViewDataOld.Columns.Add("Detalle", 150);
            ListViewDataOld.Columns.Add("Importe", 100);
            ListViewDataOld.View = View.Details;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initListView();
            initListView2();
         }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void ListViewData_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }
        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            if (VentaFinalizada == true)
            {
                MessageBox.Show("Venta Finalizada! \nPresione Iniciar Venta para continuar");
            }
            else
            {
                float importe;      
                bool resultC = float.TryParse(TextBoxImporte.Text, out importe);
                if (TextBoxNombre.Text.Length > 0) //verificacion
                {
                    if (resultC == true)
                    {
                        matrixNombreCliente[ContadorVenta, 0] = TextBoxNombre.Text;
                        matrixConcepto[ContadorVenta, Contador] = TextBoxConcepto.Text;
                        matrixImporte[ContadorVenta, Contador] = float.Parse(TextBoxImporte.Text);
                        labelMostrarNombreCliente.Text = "Nombre del cliente:" + TextBoxNombre.Text;
                        labelNumeroDePedido.Text = "Numero de pedido: " + ContadorVenta;
                        var item1 = new ListViewItem(new[] { TextBoxConcepto.Text, TextBoxImporte.Text });
                        ListViewData.Items.Add(item1);
                        Contador++;
                    }
                    else
                    {
                        MessageBox.Show("ERROR! \nIngresar un valor numerico");
                    }

                }
                else
                {
                    MessageBox.Show("ERROR! \nIngresar Nombre del Cliente");
                }
            }
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrarPedido_Click(object sender, EventArgs e)
        {
            matrixConcepto[ContadorVenta, Contador] = "1000000"; //guarda registro
            matrixImporte[ContadorVenta, Contador] = 1000000;
            ContadorVenta++;
            VentaFinalizada = true;
            Contador = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VentaFinalizada == false)
            {
                MessageBox.Show("ERROR! \nVenta no terminada");
            }
            if (VentaFinalizada== true)
            {
                Contador = 0;
                VentaFinalizada = false;
                ListViewData.Clear();
                initListView();
            }
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonMostrarPedido_Click(object sender, EventArgs e)
        {
            ListViewDataOld.Clear();
            initListView2();
            int buscar = Convert.ToInt32(numericUpDownNumeroVenta.Value);
            float total = 0;
            int fin = BuscarMaximo(buscar);
            fin--; 
            for (int i=0;i<fin;i++)
            {            
                int MostrarContadorVenta = Convert.ToInt32(numericUpDownNumeroVenta.Value);
                string Concepto = matrixConcepto[MostrarContadorVenta, i];
                string Importe = Convert.ToString(matrixImporte[MostrarContadorVenta, i]);
                labelNombreClientePedidosAnteriores.Text = "Nombre del cliente:" + matrixNombreCliente[buscar, 0];
                var item1 = new ListViewItem(new[] { Concepto, Importe });
                ListViewDataOld.Items.Add(item1);
                total = total + matrixImporte[MostrarContadorVenta, i];
            }
            labelMostrarTotal.Text = "Total: $" + Convert.ToString(total);
            
        }
    }
}
