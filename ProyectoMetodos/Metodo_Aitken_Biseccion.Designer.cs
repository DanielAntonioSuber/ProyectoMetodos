﻿namespace ProyectoMetodos
{
    partial class Metodo_Aitken_Biseccion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Btxt = new System.Windows.Forms.TextBox();
            this.Atxt = new System.Windows.Forms.TextBox();
            this.ErrMaxtxt = new System.Windows.Forms.TextBox();
            this.NuMaxItertxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(809, 306);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 56);
            this.button1.TabIndex = 31;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btxt
            // 
            this.Btxt.BackColor = System.Drawing.SystemColors.Window;
            this.Btxt.Location = new System.Drawing.Point(520, 141);
            this.Btxt.Name = "Btxt";
            this.Btxt.Size = new System.Drawing.Size(128, 26);
            this.Btxt.TabIndex = 30;
            this.Btxt.TextChanged += new System.EventHandler(this.Btxt_TextChanged);
            // 
            // Atxt
            // 
            this.Atxt.BackColor = System.Drawing.SystemColors.Window;
            this.Atxt.Location = new System.Drawing.Point(520, 97);
            this.Atxt.Name = "Atxt";
            this.Atxt.Size = new System.Drawing.Size(128, 26);
            this.Atxt.TabIndex = 29;
            this.Atxt.TextChanged += new System.EventHandler(this.Atxt_TextChanged);
            // 
            // ErrMaxtxt
            // 
            this.ErrMaxtxt.BackColor = System.Drawing.SystemColors.Window;
            this.ErrMaxtxt.Location = new System.Drawing.Point(177, 141);
            this.ErrMaxtxt.Name = "ErrMaxtxt";
            this.ErrMaxtxt.Size = new System.Drawing.Size(128, 26);
            this.ErrMaxtxt.TabIndex = 28;
            this.ErrMaxtxt.TextChanged += new System.EventHandler(this.ErrMaxtxt_TextChanged);
            // 
            // NuMaxItertxt
            // 
            this.NuMaxItertxt.BackColor = System.Drawing.SystemColors.Window;
            this.NuMaxItertxt.Location = new System.Drawing.Point(339, 97);
            this.NuMaxItertxt.Name = "NuMaxItertxt";
            this.NuMaxItertxt.Size = new System.Drawing.Size(128, 26);
            this.NuMaxItertxt.TabIndex = 27;
            this.NuMaxItertxt.TextChanged += new System.EventHandler(this.NuMaxItertxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Error maximo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Numero maximo de iteraciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "METODO DE AITKEN CON BISECCION";
            // 
            // Metodo_Aitken_Biseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btxt);
            this.Controls.Add(this.Atxt);
            this.Controls.Add(this.ErrMaxtxt);
            this.Controls.Add(this.NuMaxItertxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Metodo_Aitken_Biseccion";
            this.Text = "Metodo_Aitken_Biseccion";
            this.Load += new System.EventHandler(this.Metodo_Aitken_Biseccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Btxt;
        private System.Windows.Forms.TextBox Atxt;
        private System.Windows.Forms.TextBox ErrMaxtxt;
        private System.Windows.Forms.TextBox NuMaxItertxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}