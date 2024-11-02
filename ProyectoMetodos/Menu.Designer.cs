namespace ProyectoMetodos
{
    partial class Menu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeBisecciomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeFalsaPosicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeSecanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeNewtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeSteffensenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeAikenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aitkenBiseccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aitkenSecanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeHornerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.integracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpson13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpson38ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeMullerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 57);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // metodosToolStripMenuItem
            // 
            this.metodosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.metodosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoDeBisecciomToolStripMenuItem,
            this.metodoDeFalsaPosicionToolStripMenuItem,
            this.metodoDeToolStripMenuItem,
            this.metodoDeSecanteToolStripMenuItem,
            this.metodoDeNewtonToolStripMenuItem,
            this.metodoDeSteffensenToolStripMenuItem,
            this.metodoDeAikenToolStripMenuItem,
            this.metodoDeHornerToolStripMenuItem,
            this.metodoDeMullerToolStripMenuItem});
            this.metodosToolStripMenuItem.Name = "metodosToolStripMenuItem";
            this.metodosToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.metodosToolStripMenuItem.Text = "Metodos";
            this.metodosToolStripMenuItem.Click += new System.EventHandler(this.metodosToolStripMenuItem_Click);
            // 
            // metodoDeBisecciomToolStripMenuItem
            // 
            this.metodoDeBisecciomToolStripMenuItem.Name = "metodoDeBisecciomToolStripMenuItem";
            this.metodoDeBisecciomToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeBisecciomToolStripMenuItem.Text = "Metodo de Biseccion";
            this.metodoDeBisecciomToolStripMenuItem.Click += new System.EventHandler(this.metodoDeBisecciomToolStripMenuItem_Click);
            // 
            // metodoDeFalsaPosicionToolStripMenuItem
            // 
            this.metodoDeFalsaPosicionToolStripMenuItem.Name = "metodoDeFalsaPosicionToolStripMenuItem";
            this.metodoDeFalsaPosicionToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeFalsaPosicionToolStripMenuItem.Text = "Metodo de Falsa Posicion";
            this.metodoDeFalsaPosicionToolStripMenuItem.Click += new System.EventHandler(this.metodoDeFalsaPosicionToolStripMenuItem_Click);
            // 
            // metodoDeToolStripMenuItem
            // 
            this.metodoDeToolStripMenuItem.Name = "metodoDeToolStripMenuItem";
            this.metodoDeToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeToolStripMenuItem.Text = "Metodo de Punto Fijo";
            this.metodoDeToolStripMenuItem.Click += new System.EventHandler(this.metodoDeToolStripMenuItem_Click);
            // 
            // metodoDeSecanteToolStripMenuItem
            // 
            this.metodoDeSecanteToolStripMenuItem.Name = "metodoDeSecanteToolStripMenuItem";
            this.metodoDeSecanteToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeSecanteToolStripMenuItem.Text = "Metodo de Secante";
            this.metodoDeSecanteToolStripMenuItem.Click += new System.EventHandler(this.metodoDeSecanteToolStripMenuItem_Click);
            // 
            // metodoDeNewtonToolStripMenuItem
            // 
            this.metodoDeNewtonToolStripMenuItem.Name = "metodoDeNewtonToolStripMenuItem";
            this.metodoDeNewtonToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeNewtonToolStripMenuItem.Text = "Metodo de Newton";
            this.metodoDeNewtonToolStripMenuItem.Click += new System.EventHandler(this.metodoDeNewtonToolStripMenuItem_Click);
            // 
            // metodoDeSteffensenToolStripMenuItem
            // 
            this.metodoDeSteffensenToolStripMenuItem.Name = "metodoDeSteffensenToolStripMenuItem";
            this.metodoDeSteffensenToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeSteffensenToolStripMenuItem.Text = "Metodo de Steffensen";
            this.metodoDeSteffensenToolStripMenuItem.Click += new System.EventHandler(this.metodoDeSteffensenToolStripMenuItem_Click);
            // 
            // metodoDeAikenToolStripMenuItem
            // 
            this.metodoDeAikenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aitkenBiseccionToolStripMenuItem,
            this.aitkenSecanteToolStripMenuItem});
            this.metodoDeAikenToolStripMenuItem.Name = "metodoDeAikenToolStripMenuItem";
            this.metodoDeAikenToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeAikenToolStripMenuItem.Text = "Metodo de Aiken";
            this.metodoDeAikenToolStripMenuItem.Click += new System.EventHandler(this.metodoDeAikenToolStripMenuItem_Click);
            // 
            // aitkenBiseccionToolStripMenuItem
            // 
            this.aitkenBiseccionToolStripMenuItem.Name = "aitkenBiseccionToolStripMenuItem";
            this.aitkenBiseccionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aitkenBiseccionToolStripMenuItem.Text = "Aitken Biseccion";
            this.aitkenBiseccionToolStripMenuItem.Click += new System.EventHandler(this.aitkenBiseccionToolStripMenuItem_Click);
            // 
            // aitkenSecanteToolStripMenuItem
            // 
            this.aitkenSecanteToolStripMenuItem.Name = "aitkenSecanteToolStripMenuItem";
            this.aitkenSecanteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aitkenSecanteToolStripMenuItem.Text = "Aitken Secante";
            this.aitkenSecanteToolStripMenuItem.Click += new System.EventHandler(this.aitkenSecanteToolStripMenuItem_Click);
            // 
            // metodoDeHornerToolStripMenuItem
            // 
            this.metodoDeHornerToolStripMenuItem.Name = "metodoDeHornerToolStripMenuItem";
            this.metodoDeHornerToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeHornerToolStripMenuItem.Text = "Metodo de Horner";
            this.metodoDeHornerToolStripMenuItem.Click += new System.EventHandler(this.metodoDeHornerToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integracionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // integracionToolStripMenuItem
            // 
            this.integracionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.integracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trapecioToolStripMenuItem,
            this.simpson13ToolStripMenuItem,
            this.simpson38ToolStripMenuItem});
            this.integracionToolStripMenuItem.Name = "integracionToolStripMenuItem";
            this.integracionToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.integracionToolStripMenuItem.Text = "Integracion";
            this.integracionToolStripMenuItem.Click += new System.EventHandler(this.integracionToolStripMenuItem_Click);
            // 
            // trapecioToolStripMenuItem
            // 
            this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.trapecioToolStripMenuItem.Text = "Trapecio";
            this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.trapecioToolStripMenuItem_Click);
            // 
            // simpson13ToolStripMenuItem
            // 
            this.simpson13ToolStripMenuItem.Name = "simpson13ToolStripMenuItem";
            this.simpson13ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.simpson13ToolStripMenuItem.Text = "Simpson 1_3";
            this.simpson13ToolStripMenuItem.Click += new System.EventHandler(this.simpson13ToolStripMenuItem_Click);
            // 
            // simpson38ToolStripMenuItem
            // 
            this.simpson38ToolStripMenuItem.Name = "simpson38ToolStripMenuItem";
            this.simpson38ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.simpson38ToolStripMenuItem.Text = "Simpson 3_8";
            this.simpson38ToolStripMenuItem.Click += new System.EventHandler(this.simpson38ToolStripMenuItem_Click);
            // 
            // metodoDeMullerToolStripMenuItem
            // 
            this.metodoDeMullerToolStripMenuItem.Name = "metodoDeMullerToolStripMenuItem";
            this.metodoDeMullerToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.metodoDeMullerToolStripMenuItem.Text = "Metodo de Muller";
            this.metodoDeMullerToolStripMenuItem.Click += new System.EventHandler(this.metodoDeMullerToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem metodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeBisecciomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeFalsaPosicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeSecanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeNewtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeSteffensenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeAikenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aitkenBiseccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aitkenSecanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeHornerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem integracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpson13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpson38ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem metodoDeMullerToolStripMenuItem;
    }
}