namespace Formulario
{
    partial class SistEcuaciones
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
            this.cantelem = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.generar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cantelem
            // 
            this.cantelem.Location = new System.Drawing.Point(315, 70);
            this.cantelem.Name = "cantelem";
            this.cantelem.Size = new System.Drawing.Size(100, 20);
            this.cantelem.TabIndex = 0;
            this.cantelem.TextChanged += new System.EventHandler(this.cantelem_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(450, 70);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(75, 23);
            this.generar.TabIndex = 2;
            this.generar.Text = "GENERAR";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(44, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 286);
            this.panel1.TabIndex = 3;
            // 
            // SistEcuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.generar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cantelem);
            this.Name = "SistEcuaciones";
            this.Text = "SistEcuaciones";
            this.Load += new System.EventHandler(this.SistEcuaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cantelem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Panel panel1;
    }
}