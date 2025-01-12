namespace ProyectoMetodos
{
    partial class Eliminacion_Gaussiana
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumIncogtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pParcialRB = new System.Windows.Forms.RadioButton();
            this.pMaximoRB = new System.Windows.Forms.RadioButton();
            this.gaussRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(333, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 28);
            this.label1.TabIndex = 76;
            this.label1.Text = "ELIMINACION GAUSSIANA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Numero de incognitas:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Matriz Aumentada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumIncogtxt
            // 
            this.NumIncogtxt.Location = new System.Drawing.Point(221, 125);
            this.NumIncogtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumIncogtxt.Name = "NumIncogtxt";
            this.NumIncogtxt.Size = new System.Drawing.Size(112, 22);
            this.NumIncogtxt.TabIndex = 85;
            this.NumIncogtxt.TextChanged += new System.EventHandler(this.NumIncogtxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(507, 283);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(548, 206);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(524, 282);
            this.dataGridView2.TabIndex = 87;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(460, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 70);
            this.button1.TabIndex = 88;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pParcialRB);
            this.groupBox1.Controls.Add(this.pMaximoRB);
            this.groupBox1.Controls.Add(this.gaussRB);
            this.groupBox1.Location = new System.Drawing.Point(320, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 51);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // pParcialRB
            // 
            this.pParcialRB.AutoSize = true;
            this.pParcialRB.Location = new System.Drawing.Point(337, 15);
            this.pParcialRB.Name = "pParcialRB";
            this.pParcialRB.Size = new System.Drawing.Size(118, 20);
            this.pParcialRB.TabIndex = 2;
            this.pParcialRB.TabStop = true;
            this.pParcialRB.Text = "Pivoteo parcial";
            this.pParcialRB.UseVisualStyleBackColor = true;
            // 
            // pMaximoRB
            // 
            this.pMaximoRB.AutoSize = true;
            this.pMaximoRB.Location = new System.Drawing.Point(153, 15);
            this.pMaximoRB.Name = "pMaximoRB";
            this.pMaximoRB.Size = new System.Drawing.Size(124, 20);
            this.pMaximoRB.TabIndex = 1;
            this.pMaximoRB.TabStop = true;
            this.pMaximoRB.Text = "Pivoteo máximo";
            this.pMaximoRB.UseVisualStyleBackColor = true;
            // 
            // gaussRB
            // 
            this.gaussRB.AutoSize = true;
            this.gaussRB.Location = new System.Drawing.Point(15, 15);
            this.gaussRB.Name = "gaussRB";
            this.gaussRB.Size = new System.Drawing.Size(67, 20);
            this.gaussRB.TabIndex = 0;
            this.gaussRB.TabStop = true;
            this.gaussRB.Text = "Gauss";
            this.gaussRB.UseVisualStyleBackColor = true;
            // 
            // Eliminacion_Gaussiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NumIncogtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Eliminacion_Gaussiana";
            this.Text = "Eliminacion_Gaussiana";
            this.Load += new System.EventHandler(this.Eliminacion_Gaussiana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumIncogtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pParcialRB;
        private System.Windows.Forms.RadioButton pMaximoRB;
        private System.Windows.Forms.RadioButton gaussRB;
    }
}