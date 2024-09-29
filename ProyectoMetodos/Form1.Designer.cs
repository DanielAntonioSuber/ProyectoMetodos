namespace ProyectoMetodos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metodoDeBiseccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeLaFalsaPosicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeNewtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.metodoIteracionDePuntoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeLaSecanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeMullerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.metodoSteffensenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metodoAitkenBiseccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoAitkenSecanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoDeBiseccionToolStripMenuItem,
            this.metodoDeLaFalsaPosicionToolStripMenuItem,
            this.metodoDeNewtonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 66);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // metodoDeBiseccionToolStripMenuItem
            // 
            this.metodoDeBiseccionToolStripMenuItem.Name = "metodoDeBiseccionToolStripMenuItem";
            this.metodoDeBiseccionToolStripMenuItem.Size = new System.Drawing.Size(194, 29);
            this.metodoDeBiseccionToolStripMenuItem.Text = "Metodo de Biseccion";
            this.metodoDeBiseccionToolStripMenuItem.Click += new System.EventHandler(this.metodoDeBiseccionToolStripMenuItem_Click);
            // 
            // metodoDeLaFalsaPosicionToolStripMenuItem
            // 
            this.metodoDeLaFalsaPosicionToolStripMenuItem.Name = "metodoDeLaFalsaPosicionToolStripMenuItem";
            this.metodoDeLaFalsaPosicionToolStripMenuItem.Size = new System.Drawing.Size(248, 29);
            this.metodoDeLaFalsaPosicionToolStripMenuItem.Text = "Metodo de la falsa posicion";
            this.metodoDeLaFalsaPosicionToolStripMenuItem.Click += new System.EventHandler(this.metodoDeLaFalsaPosicionToolStripMenuItem_Click);
            // 
            // metodoDeNewtonToolStripMenuItem
            // 
            this.metodoDeNewtonToolStripMenuItem.Name = "metodoDeNewtonToolStripMenuItem";
            this.metodoDeNewtonToolStripMenuItem.Size = new System.Drawing.Size(184, 29);
            this.metodoDeNewtonToolStripMenuItem.Text = "Metodo de Newton";
            this.metodoDeNewtonToolStripMenuItem.Click += new System.EventHandler(this.metodoDeNewtonToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoIteracionDePuntoFijoToolStripMenuItem,
            this.metodoDeLaSecanteToolStripMenuItem,
            this.metodoDeMullerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 33);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // metodoIteracionDePuntoFijoToolStripMenuItem
            // 
            this.metodoIteracionDePuntoFijoToolStripMenuItem.Name = "metodoIteracionDePuntoFijoToolStripMenuItem";
            this.metodoIteracionDePuntoFijoToolStripMenuItem.Size = new System.Drawing.Size(272, 29);
            this.metodoIteracionDePuntoFijoToolStripMenuItem.Text = "Metodo iteracion de punto fijo";
            this.metodoIteracionDePuntoFijoToolStripMenuItem.Click += new System.EventHandler(this.metodoIteracionDePuntoFijoToolStripMenuItem_Click);
            // 
            // metodoDeLaSecanteToolStripMenuItem
            // 
            this.metodoDeLaSecanteToolStripMenuItem.Name = "metodoDeLaSecanteToolStripMenuItem";
            this.metodoDeLaSecanteToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.metodoDeLaSecanteToolStripMenuItem.Text = "Metodo de la secante";
            this.metodoDeLaSecanteToolStripMenuItem.Click += new System.EventHandler(this.metodoDeLaSecanteToolStripMenuItem_Click);
            // 
            // metodoDeMullerToolStripMenuItem
            // 
            this.metodoDeMullerToolStripMenuItem.Name = "metodoDeMullerToolStripMenuItem";
            this.metodoDeMullerToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.metodoDeMullerToolStripMenuItem.Text = "Metodo de Muller";
            this.metodoDeMullerToolStripMenuItem.Click += new System.EventHandler(this.metodoDeMullerToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoSteffensenToolStripMenuItem,
            this.metodoAitkenBiseccionToolStripMenuItem,
            this.metodoAitkenSecanteToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 33);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // metodoSteffensenToolStripMenuItem
            // 
            this.metodoSteffensenToolStripMenuItem.Name = "metodoSteffensenToolStripMenuItem";
            this.metodoSteffensenToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.metodoSteffensenToolStripMenuItem.Text = "Metodo Steffensen";
            this.metodoSteffensenToolStripMenuItem.Click += new System.EventHandler(this.metodoSteffensenToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // metodoAitkenBiseccionToolStripMenuItem
            // 
            this.metodoAitkenBiseccionToolStripMenuItem.Name = "metodoAitkenBiseccionToolStripMenuItem";
            this.metodoAitkenBiseccionToolStripMenuItem.Size = new System.Drawing.Size(224, 29);
            this.metodoAitkenBiseccionToolStripMenuItem.Text = "Metodo Aitken Biseccion";
            this.metodoAitkenBiseccionToolStripMenuItem.Click += new System.EventHandler(this.metodoAitkenBiseccionToolStripMenuItem_Click);
            // 
            // metodoAitkenSecanteToolStripMenuItem
            // 
            this.metodoAitkenSecanteToolStripMenuItem.Name = "metodoAitkenSecanteToolStripMenuItem";
            this.metodoAitkenSecanteToolStripMenuItem.Size = new System.Drawing.Size(213, 29);
            this.metodoAitkenSecanteToolStripMenuItem.Text = "Metodo Aitken Secante";
            this.metodoAitkenSecanteToolStripMenuItem.Click += new System.EventHandler(this.metodoAitkenSecanteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "Form1";
            this.Text = "Metodos numericos para obtener raices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem metodoDeBiseccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeLaFalsaPosicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeNewtonToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem metodoIteracionDePuntoFijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeLaSecanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeMullerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem metodoSteffensenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem metodoAitkenBiseccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoAitkenSecanteToolStripMenuItem;
    }
}

