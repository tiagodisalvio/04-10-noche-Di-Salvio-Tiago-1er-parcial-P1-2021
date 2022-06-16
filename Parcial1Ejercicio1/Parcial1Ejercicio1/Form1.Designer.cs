
namespace Parcial1Ejercicio1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inicioTimer = new System.Windows.Forms.Button();
            this.finTimer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LabelValor = new System.Windows.Forms.Label();
            this.LabelContar = new System.Windows.Forms.Label();
            this.LabelRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(387, 503);
            this.hScrollBar1.Maximum = 5;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(753, 75);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = ": Segundos seleccionados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1037, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numero Random:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1464, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mediante el uso de Hscrollbar, seleccione el tiempo deseado, luego presione Start" +
    " para iniciar y Stop para finalizar.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inicioTimer
            // 
            this.inicioTimer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inicioTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inicioTimer.ForeColor = System.Drawing.Color.ForestGreen;
            this.inicioTimer.Location = new System.Drawing.Point(469, 344);
            this.inicioTimer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inicioTimer.Name = "inicioTimer";
            this.inicioTimer.Size = new System.Drawing.Size(200, 55);
            this.inicioTimer.TabIndex = 10;
            this.inicioTimer.Text = "START";
            this.inicioTimer.UseVisualStyleBackColor = false;
            this.inicioTimer.Click += new System.EventHandler(this.inicioTimer_Click);
            // 
            // finTimer
            // 
            this.finTimer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finTimer.ForeColor = System.Drawing.Color.Red;
            this.finTimer.Location = new System.Drawing.Point(871, 344);
            this.finTimer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.finTimer.Name = "finTimer";
            this.finTimer.Size = new System.Drawing.Size(200, 55);
            this.finTimer.TabIndex = 10;
            this.finTimer.Text = "STOP";
            this.finTimer.UseVisualStyleBackColor = false;
            this.finTimer.Click += new System.EventHandler(this.finTimer_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LabelValor
            // 
            this.LabelValor.AutoSize = true;
            this.LabelValor.Cursor = System.Windows.Forms.Cursors.No;
            this.LabelValor.Location = new System.Drawing.Point(148, 194);
            this.LabelValor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LabelValor.Name = "LabelValor";
            this.LabelValor.Size = new System.Drawing.Size(33, 32);
            this.LabelValor.TabIndex = 12;
            this.LabelValor.Text = "--";
            // 
            // LabelContar
            // 
            this.LabelContar.AutoSize = true;
            this.LabelContar.Cursor = System.Windows.Forms.Cursors.No;
            this.LabelContar.ForeColor = System.Drawing.Color.Red;
            this.LabelContar.Location = new System.Drawing.Point(814, 194);
            this.LabelContar.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LabelContar.Name = "LabelContar";
            this.LabelContar.Size = new System.Drawing.Size(33, 32);
            this.LabelContar.TabIndex = 13;
            this.LabelContar.Text = "--";
            // 
            // LabelRandom
            // 
            this.LabelRandom.AutoSize = true;
            this.LabelRandom.Cursor = System.Windows.Forms.Cursors.No;
            this.LabelRandom.Location = new System.Drawing.Point(1265, 194);
            this.LabelRandom.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LabelRandom.Name = "LabelRandom";
            this.LabelRandom.Size = new System.Drawing.Size(33, 32);
            this.LabelRandom.TabIndex = 14;
            this.LabelRandom.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1539, 709);
            this.Controls.Add(this.LabelRandom);
            this.Controls.Add(this.LabelContar);
            this.Controls.Add(this.LabelValor);
            this.Controls.Add(this.finTimer);
            this.Controls.Add(this.inicioTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button inicioTimer;
        private System.Windows.Forms.Button finTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label LabelValor;
        private System.Windows.Forms.Label LabelContar;
        private System.Windows.Forms.Label LabelRandom;
    }
}

