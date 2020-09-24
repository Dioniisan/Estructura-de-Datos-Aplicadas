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
            this.CboxOpciones.Location = new System.Drawing.Point(13, 21);
            this.CboxOpciones.Name = "CboxOpciones";
            this.CboxOpciones.Size = new System.Drawing.Size(121, 21);
            this.CboxOpciones.TabIndex = 0;
            this.CboxOpciones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PanelEjercicios
            // 
            this.PanelEjercicios.Location = new System.Drawing.Point(13, 57);
            this.PanelEjercicios.Name = "PanelEjercicios";
            this.PanelEjercicios.Size = new System.Drawing.Size(777, 385);
            this.PanelEjercicios.TabIndex = 1;
            // 
            // Recursividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelEjercicios);
            this.Controls.Add(this.CboxOpciones);
            this.Name = "Recursividad";
            this.Text = "Recursividad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxOpciones;
        private System.Windows.Forms.Panel PanelEjercicios;
    }
}

