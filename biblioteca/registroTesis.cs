using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class registroTesis : Form
    {
        validacion vali;
        private object errorProvider1;
        
        public registroTesis()
        {
            vali = new validacion();
            InitializeComponent();
        }

        private void bto_registrar_Click(object sender, EventArgs e)
        {
            /* if (txt_codigo.Text == "" || txt_titulo.Text == "" || txt_carrera.Text == "" || txt_nomTesista.Text == "" || txt_citesista.Text == "" || txt_nomtutor.Text == "" || txt_especialidad.Text == "" || txt_codigo.Text == "")
              {
                  errorProvider1.SetError(txt_codigo, "Ingrese CI");
                  errorProvider1.SetError(txt_titulo, "Ingrese Nombres");
                  errorProvider1.SetError(txt_carrera, "Ingrese Telefono");
                  errorProvider1.SetError(txt_nomTesista, "Ingrese Domicilio");
                  errorProvider1.SetError(txt_citesista, "Ingrese Domicilio");
                  errorProvider1.SetError(txt_nomtutor, "Ingrese Domicilio");
                  errorProvider1.SetError(txt_especialidad, "Ingrese Domicilio");
                  errorProvider1.SetError(txt_codigo, "Ingrese Domicilio");
              }
              else
              {
                  errorProvider1.SetError(txt_codigo, " ");
                  errorProvider1.SetError(txt_titulo, "");
                  errorProvider1.SetError(txt_carrera, "");
                  errorProvider1.SetError(txt_nomTesista, "");
                  errorProvider1.SetError(txt_citesista, "");
                  errorProvider1.SetError(txt_nomtutor, "");
                  errorProvider1.SetError(txt_especialidad, "");
                  errorProvider1.SetError(txt_codigo, "");
                  tesis Tes = new tesis();
                  Tes.codtes= txt_codigo.Text.Trim();
                  Tes.titulites = txt_titulo.Text.Trim();
                  Tes.carretes = txt_carrera.Text.Trim();
                  Tes.nomtes = txt_nomTesista.Text.Trim();
                  Tes.cites = txt_citesista.Text.Trim();
                  Tes.nombtes = txt_nomtutor.Text.Trim();
                  Tes.especialidadtes = txt_especialidad.Text.Trim();
                  Tes.codites = txt_codigo.Text.Trim();
                  int resultado = tesisBD.Agregar(Tes);
                  if (resultado > 0)
                  {
                      MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      txt_ci.Text = "";
                      txt_nombre.Text = "";
                      txt_telefono.Text = "";
                      txt_domicilio.Text = "";
                  }
                  else
                  {
                      MessageBox.Show("No se pudo guardar el Cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      txt_ci.Text = "";
                      txt_nombre.Text = "";
                      txt_telefono.Text = "";
                      txt_domicilio.Text = "";
                  }
              }*/
            tesis pCliente = new tesis();
            pCliente.codtes = txt_codigo.Text.Trim();
            pCliente.titulites = txt_titulo.Text.Trim();
            pCliente.carretes = txt_carrera.Text.Trim();
            pCliente.nomtes = txt_nomTesista.Text.Trim();
            pCliente.carretes = txt_citesista.Text;
            pCliente.nombtes = txt_nomtutor.Text.Trim();
            pCliente.especialidadtes = txt_especialidad.Text.Trim();
            pCliente.codites = txt_codtutor.Text.Trim();

            int resultado = tesisBD.Agregar(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show(" Registrado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo Registrar ", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        void Limpiar()
        {
            txt_codigo.Clear();
            txt_titulo.Clear();
            

            
            

        }
        private void txt_no(object sender, KeyPressEventArgs e)
        {
            vali.soloLetras(e);
        }

        private void txt_te(object sender, KeyPressEventArgs e)
        {
            vali.soloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio usu = new inicio();
            this.Hide();
            usu.Show();
        }
    }

    internal class validacion
    {
        internal void soloLetras(KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        internal void soloNumeros(KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
