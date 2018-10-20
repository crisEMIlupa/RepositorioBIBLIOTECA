namespace biblioteca
{
    partial class mostrarEst
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
            this.lst_libro = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bto_prestar = new System.Windows.Forms.Button();
            this.bto_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_libro
            // 
            this.lst_libro.FormattingEnabled = true;
            this.lst_libro.ItemHeight = 16;
            this.lst_libro.Location = new System.Drawing.Point(152, 224);
            this.lst_libro.Margin = new System.Windows.Forms.Padding(4);
            this.lst_libro.Name = "lst_libro";
            this.lst_libro.Size = new System.Drawing.Size(536, 180);
            this.lst_libro.TabIndex = 7;
            this.lst_libro.SelectedIndexChanged += new System.EventHandler(this.LST_MOVIL_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "volver atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bto_prestar
            // 
            this.bto_prestar.Location = new System.Drawing.Point(450, 458);
            this.bto_prestar.Name = "bto_prestar";
            this.bto_prestar.Size = new System.Drawing.Size(214, 64);
            this.bto_prestar.TabIndex = 18;
            this.bto_prestar.Text = "PRESTARSE";
            this.bto_prestar.UseVisualStyleBackColor = true;
            // 
            // bto_buscar
            // 
            this.bto_buscar.Location = new System.Drawing.Point(173, 458);
            this.bto_buscar.Name = "bto_buscar";
            this.bto_buscar.Size = new System.Drawing.Size(214, 64);
            this.bto_buscar.TabIndex = 17;
            this.bto_buscar.Text = "BUSCAR";
            this.bto_buscar.UseVisualStyleBackColor = true;
            this.bto_buscar.Click += new System.EventHandler(this.bto_buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "AUTOR:";
            // 
            // txt_autor
            // 
            this.txt_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.Location = new System.Drawing.Point(367, 116);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(297, 30);
            this.txt_autor.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "TITULO:";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(367, 59);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(297, 30);
            this.txt_titulo.TabIndex = 20;
            // 
            // mostrarEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bto_prestar);
            this.Controls.Add(this.bto_buscar);
            this.Controls.Add(this.lst_libro);
            this.Name = "mostrarEst";
            this.Text = "prestar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_libro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bto_prestar;
        private System.Windows.Forms.Button bto_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_titulo;
    }
}