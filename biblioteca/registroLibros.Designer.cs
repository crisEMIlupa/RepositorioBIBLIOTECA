﻿namespace biblioteca
{
    partial class registroLibros
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
            this.bto_registrar = new System.Windows.Forms.Button();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_edicion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.bto_mostrar_li = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lst_libro = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bto_registrar
            // 
            this.bto_registrar.Location = new System.Drawing.Point(68, 471);
            this.bto_registrar.Name = "bto_registrar";
            this.bto_registrar.Size = new System.Drawing.Size(214, 64);
            this.bto_registrar.TabIndex = 0;
            this.bto_registrar.Text = "REGISTRAR";
            this.bto_registrar.UseVisualStyleBackColor = true;
            this.bto_registrar.Click += new System.EventHandler(this.bto_registrar_Click);
            // 
            // txt_titulo
            // 
            this.txt_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(288, 51);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(297, 30);
            this.txt_titulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TITULO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AUTOR:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(288, 108);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(297, 30);
            this.txt_codigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "EDICION:";
            // 
            // txt_edicion
            // 
            this.txt_edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edicion.Location = new System.Drawing.Point(288, 164);
            this.txt_edicion.Name = "txt_edicion";
            this.txt_edicion.Size = new System.Drawing.Size(297, 30);
            this.txt_edicion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "EDITORIAL:";
            // 
            // txt_editorial
            // 
            this.txt_editorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editorial.Location = new System.Drawing.Point(288, 227);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(297, 30);
            this.txt_editorial.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "CODIGO:";
            // 
            // txt_autor
            // 
            this.txt_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.Location = new System.Drawing.Point(288, 285);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(297, 30);
            this.txt_autor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "CARRERA:";
            // 
            // txt_carrera
            // 
            this.txt_carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carrera.Location = new System.Drawing.Point(288, 343);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(297, 30);
            this.txt_carrera.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "MATERIA:";
            // 
            // txt_materia
            // 
            this.txt_materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_materia.Location = new System.Drawing.Point(288, 397);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(297, 30);
            this.txt_materia.TabIndex = 13;
            // 
            // bto_mostrar_li
            // 
            this.bto_mostrar_li.Location = new System.Drawing.Point(345, 471);
            this.bto_mostrar_li.Name = "bto_mostrar_li";
            this.bto_mostrar_li.Size = new System.Drawing.Size(214, 64);
            this.bto_mostrar_li.TabIndex = 15;
            this.bto_mostrar_li.Text = "MOSTRAR";
            this.bto_mostrar_li.UseVisualStyleBackColor = true;
            this.bto_mostrar_li.Click += new System.EventHandler(this.bto_mostrar_li_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "volver atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_libro
            // 
            this.lst_libro.FormattingEnabled = true;
            this.lst_libro.ItemHeight = 16;
            this.lst_libro.Location = new System.Drawing.Point(640, 37);
            this.lst_libro.Margin = new System.Windows.Forms.Padding(4);
            this.lst_libro.Name = "lst_libro";
            this.lst_libro.Size = new System.Drawing.Size(543, 580);
            this.lst_libro.TabIndex = 17;
            // 
            // registroLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 636);
            this.Controls.Add(this.lst_libro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bto_mostrar_li);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_materia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_carrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_editorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_edicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.bto_registrar);
            this.Name = "registroLibros";
            this.Text = "registroLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bto_registrar;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_edicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_editorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_carrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.Button bto_mostrar_li;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_libro;
    }
}