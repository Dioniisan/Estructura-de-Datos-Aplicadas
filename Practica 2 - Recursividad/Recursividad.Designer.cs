namespace Practica_2___Recursividad
{
    partial class Recursividad
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
            this.CboxOpciones = new System.Windows.Forms.ComboBox();
            this.PanelEjercicios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboxOpciones
            // 
            this.CboxOpciones.FormattingEnabled = true;
            this.CboxOpciones.Items.AddRange(new object[] {
            "Factorial",
            "Fibonacci",
            "MCD",
            "Monedas",
            "Torres de Hanói"});
            this.CboxOpciones.Location = new System.Drawing.Point(177, 21);
            this.CboxOpciones.Name = "CboxOpciones";
            this.CboxOpciones.Size = new System.Drawing.Size(121, 21);
            this.CboxOpciones.TabIndex = 0;
            this.CboxOpciones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PanelEjercicios
            // 
            this.PanelEjercicios.Location = new System.Drawing.Point(13, 57);
            this.PanelEjercicios.Name = "PanelEjercicios";
            this.PanelEjercicios.Size = new System.Drawing.Size(800, 450);
            this.PanelEjercicios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Por favor, elija una opción:";
            // 
            // Recursividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelEjercicios);
            this.Controls.Add(this.CboxOpciones);
            this.Name = "Recursividad";
            this.Text = "Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxOpciones;
        private System.Windows.Forms.Panel PanelEjercicios;
        private System.Windows.Forms.Label label1;
    }
}

