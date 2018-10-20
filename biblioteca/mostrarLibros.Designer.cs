namespace biblioteca
{
    partial class mostrarLibros
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
            this.BTO_mostar_libro = new System.Windows.Forms.Button();
            this.bto_atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTO_mostar_libro
            // 
            this.BTO_mostar_libro.Location = new System.Drawing.Point(70, 533);
            this.BTO_mostar_libro.Name = "BTO_mostar_libro";
            this.BTO_mostar_libro.Size = new System.Drawing.Size(158, 48);
            this.BTO_mostar_libro.TabIndex = 9;
            this.BTO_mostar_libro.Text = "MOSTRAR";
            this.BTO_mostar_libro.UseVisualStyleBackColor = true;
            this.BTO_mostar_libro.Click += new System.EventHandler(this.BTO_mostar_libro_Click);
            // 
            // bto_atras
            // 
            this.bto_atras.Location = new System.Drawing.Point(781, 533);
            this.bto_atras.Name = "bto_atras";
            this.bto_atras.Size = new System.Drawing.Size(158, 48);
            this.bto_atras.TabIndex = 10;
            this.bto_atras.Text = "VOLVER ATRAS";
            this.bto_atras.UseVisualStyleBackColor = true;
            this.bto_atras.Click += new System.EventHandler(this.bto_atras_Click);
            // 
            // mostrarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 616);
            this.Controls.Add(this.bto_atras);
            this.Controls.Add(this.BTO_mostar_libro);
            this.Name = "mostrarLibros";
            this.Text = "mostrarLibros";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTO_mostar_libro;
        private System.Windows.Forms.Button bto_atras;
    }
}