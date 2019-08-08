namespace Formulario
{
    partial class Unidad1
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
            this.botonbiseccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonreglafalsa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonbiseccion
            // 
            this.botonbiseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonbiseccion.Location = new System.Drawing.Point(157, 172);
            this.botonbiseccion.Name = "botonbiseccion";
            this.botonbiseccion.Size = new System.Drawing.Size(150, 41);
            this.botonbiseccion.TabIndex = 0;
            this.botonbiseccion.Text = "BISECCIÓN";
            this.botonbiseccion.UseVisualStyleBackColor = true;
            this.botonbiseccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÉTODOS CERRADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "MÉTODOS ABIERTOS";
            // 
            // botonreglafalsa
            // 
            this.botonreglafalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonreglafalsa.Location = new System.Drawing.Point(157, 308);
            this.botonreglafalsa.Name = "botonreglafalsa";
            this.botonreglafalsa.Size = new System.Drawing.Size(150, 41);
            this.botonreglafalsa.TabIndex = 3;
            this.botonreglafalsa.Text = "REGLA FALSA";
            this.botonreglafalsa.UseVisualStyleBackColor = true;
            this.botonreglafalsa.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(499, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "NEWTON - RAPHSON";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(499, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "SECANTE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Unidad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.botonreglafalsa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonbiseccion);
            this.Name = "Unidad1";
            this.Text = "Raíces de funciones";
            this.Load += new System.EventHandler(this.Unidad1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonbiseccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonreglafalsa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}