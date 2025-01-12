namespace ProyectoMetodos
{
    partial class Derivada_Númerica
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
            this.button1 = new System.Windows.Forms.Button();
            this.Resultado_2pts_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultado_4pts_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Resultado_3pts_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.h_txt = new System.Windows.Forms.TextBox();
            this.x0_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(477, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Resultado_2pts_txt
            // 
            this.Resultado_2pts_txt.Enabled = false;
            this.Resultado_2pts_txt.Location = new System.Drawing.Point(202, 178);
            this.Resultado_2pts_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Resultado_2pts_txt.Name = "Resultado_2pts_txt";
            this.Resultado_2pts_txt.Size = new System.Drawing.Size(109, 20);
            this.Resultado_2pts_txt.TabIndex = 38;
            this.Resultado_2pts_txt.TextChanged += new System.EventHandler(this.Resultado_2pts_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Resultado 2 puntos =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(129, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "DERIVADA CON 2, 3 Y 4 PUNTOS";
            // 
            // Resultado_4pts_txt
            // 
            this.Resultado_4pts_txt.Enabled = false;
            this.Resultado_4pts_txt.Location = new System.Drawing.Point(202, 283);
            this.Resultado_4pts_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Resultado_4pts_txt.Name = "Resultado_4pts_txt";
            this.Resultado_4pts_txt.Size = new System.Drawing.Size(109, 20);
            this.Resultado_4pts_txt.TabIndex = 43;
            this.Resultado_4pts_txt.TextChanged += new System.EventHandler(this.Resultado_4pts_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Resultado 4 puntos";
            // 
            // Resultado_3pts_txt
            // 
            this.Resultado_3pts_txt.Enabled = false;
            this.Resultado_3pts_txt.Location = new System.Drawing.Point(202, 231);
            this.Resultado_3pts_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Resultado_3pts_txt.Name = "Resultado_3pts_txt";
            this.Resultado_3pts_txt.Size = new System.Drawing.Size(109, 20);
            this.Resultado_3pts_txt.TabIndex = 45;
            this.Resultado_3pts_txt.TextChanged += new System.EventHandler(this.Resultado_3pts_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Resultado 3 puntos";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(477, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 36);
            this.button2.TabIndex = 46;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(477, 271);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 36);
            this.button3.TabIndex = 47;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // h_txt
            // 
            this.h_txt.Location = new System.Drawing.Point(308, 110);
            this.h_txt.Margin = new System.Windows.Forms.Padding(2);
            this.h_txt.Name = "h_txt";
            this.h_txt.Size = new System.Drawing.Size(95, 20);
            this.h_txt.TabIndex = 51;
            // 
            // x0_txt
            // 
            this.x0_txt.Location = new System.Drawing.Point(308, 83);
            this.x0_txt.Margin = new System.Windows.Forms.Padding(2);
            this.x0_txt.Name = "x0_txt";
            this.x0_txt.Size = new System.Drawing.Size(95, 20);
            this.x0_txt.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "h = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "x0";
            // 
            // Derivada_Númerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.h_txt);
            this.Controls.Add(this.x0_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Resultado_3pts_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Resultado_4pts_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado_2pts_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Derivada_Númerica";
            this.Text = "Derivación Númerica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Resultado_2pts_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Resultado_4pts_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Resultado_3pts_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox h_txt;
        private System.Windows.Forms.TextBox x0_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}