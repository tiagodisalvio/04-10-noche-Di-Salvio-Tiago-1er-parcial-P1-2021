
namespace Parcial2Nuevo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListViewData = new System.Windows.Forms.ListView();
            this.ButtonIngresar = new System.Windows.Forms.Button();
            this.Importe = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.TextBoxImporte = new System.Windows.Forms.TextBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.TextBoxConcepto = new System.Windows.Forms.TextBox();
            this.Concepto = new System.Windows.Forms.Label();
            this.buttonCerrarPedido = new System.Windows.Forms.Button();
            this.labelMostrarNombreCliente = new System.Windows.Forms.Label();
            this.buttonIniciarVenta = new System.Windows.Forms.Button();
            this.ListViewDataOld = new System.Windows.Forms.ListView();
            this.labelNombreClientePedidosAnteriores = new System.Windows.Forms.Label();
            this.numericUpDownNumeroVenta = new System.Windows.Forms.NumericUpDown();
            this.buttonMostrarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumeroDePedido = new System.Windows.Forms.Label();
            this.labelMostrarTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewData
            // 
            this.ListViewData.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ListViewData.HideSelection = false;
            this.ListViewData.Location = new System.Drawing.Point(45, 196);
            this.ListViewData.Name = "ListViewData";
            this.ListViewData.Size = new System.Drawing.Size(300, 300);
            this.ListViewData.TabIndex = 17;
            this.ListViewData.UseCompatibleStateImageBehavior = false;
            this.ListViewData.SelectedIndexChanged += new System.EventHandler(this.ListViewData_SelectedIndexChanged);
            // 
            // ButtonIngresar
            // 
            this.ButtonIngresar.Location = new System.Drawing.Point(23, 93);
            this.ButtonIngresar.Name = "ButtonIngresar";
            this.ButtonIngresar.Size = new System.Drawing.Size(87, 32);
            this.ButtonIngresar.TabIndex = 22;
            this.ButtonIngresar.Text = "Ingresar";
            this.ButtonIngresar.UseVisualStyleBackColor = true;
            this.ButtonIngresar.Click += new System.EventHandler(this.ButtonIngresar_Click);
            // 
            // Importe
            // 
            this.Importe.AutoSize = true;
            this.Importe.Location = new System.Drawing.Point(146, 26);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(42, 13);
            this.Importe.TabIndex = 15;
            this.Importe.Text = "Importe";
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(20, 26);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(39, 13);
            this.labelNombreCliente.TabIndex = 13;
            this.labelNombreCliente.Text = "Cliente";
            this.labelNombreCliente.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // TextBoxImporte
            // 
            this.TextBoxImporte.Location = new System.Drawing.Point(149, 42);
            this.TextBoxImporte.Name = "TextBoxImporte";
            this.TextBoxImporte.Size = new System.Drawing.Size(100, 20);
            this.TextBoxImporte.TabIndex = 12;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(22, 42);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNombre.TabIndex = 10;
            this.TextBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombre_TextChanged);
            // 
            // TextBoxConcepto
            // 
            this.TextBoxConcepto.Location = new System.Drawing.Point(269, 42);
            this.TextBoxConcepto.Name = "TextBoxConcepto";
            this.TextBoxConcepto.Size = new System.Drawing.Size(100, 20);
            this.TextBoxConcepto.TabIndex = 18;
            // 
            // Concepto
            // 
            this.Concepto.AutoSize = true;
            this.Concepto.Location = new System.Drawing.Point(266, 26);
            this.Concepto.Name = "Concepto";
            this.Concepto.Size = new System.Drawing.Size(53, 13);
            this.Concepto.TabIndex = 19;
            this.Concepto.Text = "Concepto";
            // 
            // buttonCerrarPedido
            // 
            this.buttonCerrarPedido.Location = new System.Drawing.Point(267, 93);
            this.buttonCerrarPedido.Name = "buttonCerrarPedido";
            this.buttonCerrarPedido.Size = new System.Drawing.Size(87, 32);
            this.buttonCerrarPedido.TabIndex = 22;
            this.buttonCerrarPedido.Text = "Cerrar Pedido";
            this.buttonCerrarPedido.UseVisualStyleBackColor = true;
            this.buttonCerrarPedido.Click += new System.EventHandler(this.buttonCerrarPedido_Click);
            // 
            // labelMostrarNombreCliente
            // 
            this.labelMostrarNombreCliente.AutoSize = true;
            this.labelMostrarNombreCliente.Location = new System.Drawing.Point(20, 158);
            this.labelMostrarNombreCliente.Name = "labelMostrarNombreCliente";
            this.labelMostrarNombreCliente.Size = new System.Drawing.Size(85, 13);
            this.labelMostrarNombreCliente.TabIndex = 21;
            this.labelMostrarNombreCliente.Text = "Nombre Cliente: ";
            // 
            // buttonIniciarVenta
            // 
            this.buttonIniciarVenta.Location = new System.Drawing.Point(147, 93);
            this.buttonIniciarVenta.Name = "buttonIniciarVenta";
            this.buttonIniciarVenta.Size = new System.Drawing.Size(87, 32);
            this.buttonIniciarVenta.TabIndex = 22;
            this.buttonIniciarVenta.Text = "Nuevo Pedido";
            this.buttonIniciarVenta.UseVisualStyleBackColor = true;
            this.buttonIniciarVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListViewDataOld
            // 
            this.ListViewDataOld.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ListViewDataOld.HideSelection = false;
            this.ListViewDataOld.Location = new System.Drawing.Point(386, 196);
            this.ListViewDataOld.Name = "ListViewDataOld";
            this.ListViewDataOld.Size = new System.Drawing.Size(300, 300);
            this.ListViewDataOld.TabIndex = 24;
            this.ListViewDataOld.UseCompatibleStateImageBehavior = false;
            this.ListViewDataOld.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // labelNombreClientePedidosAnteriores
            // 
            this.labelNombreClientePedidosAnteriores.AutoSize = true;
            this.labelNombreClientePedidosAnteriores.Location = new System.Drawing.Point(383, 158);
            this.labelNombreClientePedidosAnteriores.Name = "labelNombreClientePedidosAnteriores";
            this.labelNombreClientePedidosAnteriores.Size = new System.Drawing.Size(85, 13);
            this.labelNombreClientePedidosAnteriores.TabIndex = 26;
            this.labelNombreClientePedidosAnteriores.Text = "Nombre Cliente: ";
            // 
            // numericUpDownNumeroVenta
            // 
            this.numericUpDownNumeroVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownNumeroVenta.Location = new System.Drawing.Point(644, 156);
            this.numericUpDownNumeroVenta.Name = "numericUpDownNumeroVenta";
            this.numericUpDownNumeroVenta.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumeroVenta.TabIndex = 27;
            // 
            // buttonMostrarPedido
            // 
            this.buttonMostrarPedido.Location = new System.Drawing.Point(386, 93);
            this.buttonMostrarPedido.Name = "buttonMostrarPedido";
            this.buttonMostrarPedido.Size = new System.Drawing.Size(87, 32);
            this.buttonMostrarPedido.TabIndex = 28;
            this.buttonMostrarPedido.Text = "Mostrar Pedido";
            this.buttonMostrarPedido.UseVisualStyleBackColor = true;
            this.buttonMostrarPedido.Click += new System.EventHandler(this.buttonMostrarPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Historial de Pedidos";
            // 
            // labelNumeroDePedido
            // 
            this.labelNumeroDePedido.AutoSize = true;
            this.labelNumeroDePedido.Location = new System.Drawing.Point(153, 158);
            this.labelNumeroDePedido.Name = "labelNumeroDePedido";
            this.labelNumeroDePedido.Size = new System.Drawing.Size(97, 13);
            this.labelNumeroDePedido.TabIndex = 30;
            this.labelNumeroDePedido.Text = "Numero de pedido:";
            // 
            // labelMostrarTotal
            // 
            this.labelMostrarTotal.AutoSize = true;
            this.labelMostrarTotal.BackColor = System.Drawing.SystemColors.Window;
            this.labelMostrarTotal.ForeColor = System.Drawing.Color.Black;
            this.labelMostrarTotal.Location = new System.Drawing.Point(581, 499);
            this.labelMostrarTotal.Name = "labelMostrarTotal";
            this.labelMostrarTotal.Size = new System.Drawing.Size(46, 13);
            this.labelMostrarTotal.TabIndex = 31;
            this.labelMostrarTotal.Text = "Total: 0 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(793, 597);
            this.Controls.Add(this.labelMostrarTotal);
            this.Controls.Add(this.labelNumeroDePedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMostrarPedido);
            this.Controls.Add(this.numericUpDownNumeroVenta);
            this.Controls.Add(this.labelNombreClientePedidosAnteriores);
            this.Controls.Add(this.ListViewDataOld);
            this.Controls.Add(this.buttonIniciarVenta);
            this.Controls.Add(this.labelMostrarNombreCliente);
            this.Controls.Add(this.buttonCerrarPedido);
            this.Controls.Add(this.Concepto);
            this.Controls.Add(this.TextBoxConcepto);
            this.Controls.Add(this.ListViewData);
            this.Controls.Add(this.ButtonIngresar);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.TextBoxImporte);
            this.Controls.Add(this.TextBoxNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "COTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewData;
        private System.Windows.Forms.Button ButtonIngresar;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox TextBoxImporte;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxConcepto;
        private System.Windows.Forms.Label Concepto;
        private System.Windows.Forms.Button buttonCerrarPedido;
        private System.Windows.Forms.Label labelMostrarNombreCliente;
        private System.Windows.Forms.Button buttonIniciarVenta;
        private System.Windows.Forms.ListView ListViewDataOld;
        private System.Windows.Forms.Label labelNombreClientePedidosAnteriores;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroVenta;
        private System.Windows.Forms.Button buttonMostrarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumeroDePedido;
        private System.Windows.Forms.Label labelMostrarTotal;
    }
}

