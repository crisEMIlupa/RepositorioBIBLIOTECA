namespace biblioteca
{
    partial class registroEstu
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
            this.bto_volver = new System.Windows.Forms.Button();
            this.bto_mostrar_estu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_semestre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_carr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomb = new System.Windows.Forms.TextBox();
            this.bto_registrar = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // bto_volver
            // 
            this.bto_volver.Location = new System.Drawing.Point(184, 610);
            this.bto_volver.Name = "bto_volver";
            this.bto_volver.Size = new System.Drawing.Size(161, 45);
            this.bto_volver.TabIndex = 34;
            this.bto_volver.Text = "volver atras";
            this.bto_volver.UseVisualStyleBackColor = true;
            this.bto_volver.Click += new System.EventHandler(this.bto_volver_Click);
            // 
            // bto_mostrar_estu
            // 
            this.bto_mostrar_estu.Location = new System.Drawing.Point(298, 521);
            this.bto_mostrar_estu.Name = "bto_mostrar_estu";
            this.bto_mostrar_estu.Size = new System.Drawing.Size(214, 64);
            this.bto_mostrar_estu.TabIndex = 33;
            this.bto_mostrar_estu.Text = "MOSTRAR";
            this.bto_mostrar_estu.UseVisualStyleBackColor = true;
            this.bto_mostrar_estu.Click += new System.EventHandler(this.bto_mostrar_estu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "DOMICILIO:";
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_domicilio.Location = new System.Drawing.Point(315, 341);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(297, 30);
            this.txt_domicilio.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "CODIGO:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(315, 406);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(297, 30);
            this.txt_telefono.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "SEMESTRE:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_semestre
            // 
            this.txt_semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_semestre.Location = new System.Drawing.Point(315, 217);
            this.txt_semestre.Name = "txt_semestre";
            this.txt_semestre.Size = new System.Drawing.Size(297, 30);
            this.txt_semestre.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "CARRERA:";
            // 
            // txt_carr
            // 
            this.txt_carr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carr.Location = new System.Drawing.Point(315, 275);
            this.txt_carr.Name = "txt_carr";
            this.txt_carr.Size = new System.Drawing.Size(297, 30);
            this.txt_carr.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "TELEFONO:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(315, 85);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(297, 30);
            this.txt_codigo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "NOMBRE-APELLIDOS:";
            // 
            // txt_nomb
            // 
            this.txt_nomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomb.Location = new System.Drawing.Point(315, 150);
            this.txt_nomb.Name = "txt_nomb";
            this.txt_nomb.Size = new System.Drawing.Size(297, 30);
            this.txt_nomb.TabIndex = 19;
            // 
            // bto_registrar
            // 
            this.bto_registrar.Location = new System.Drawing.Point(21, 521);
            this.bto_registrar.Name = "bto_registrar";
            this.bto_registrar.Size = new System.Drawing.Size(214, 64);
            this.bto_registrar.TabIndex = 18;
            this.bto_registrar.Text = "REGISTRAR";
            this.bto_registrar.UseVisualStyleBackColor = true;
            this.bto_registrar.Click += new System.EventHandler(this.bto_registrar_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(630, 118);
            this.dgvBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.ReadOnly = true;
            this.dgvBuscar.Size = new System.Drawing.Size(661, 303);
            this.dgvBuscar.TabIndex = 36;
            // 
            // registroEstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 744);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.bto_volver);
            this.Controls.Add(this.bto_mostrar_estu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_domicilio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_semestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_carr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomb);
            this.Controls.Add(this.bto_registrar);
            this.Name = "registroEstu";
            this.Text = "registroEstu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bto_volver;
        private System.Windows.Forms.Button bto_mostrar_estu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_semestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_carr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomb;
        private System.Windows.Forms.Button bto_registrar;
        private System.Windows.Forms.DataGridView dgvBuscar;
    }
}