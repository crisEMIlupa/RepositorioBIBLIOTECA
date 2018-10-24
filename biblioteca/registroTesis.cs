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
      //  private object errorProvider1;
        
        public registroTesis()
        {
            vali = new validacion();
            InitializeComponent();
        }

        private void bto_registrar_Click(object sender, EventArgs e)
        {
            tesis pTesis = new tesis();
            pTesis.codtes = txt_codigo.Text.Trim();
            pTesis.titulites = txt_titulo.Text.Trim();
            pTesis.carretes = txt_carreraa.Text.Trim();
            pTesis.nombretes = txt_nombreTesista.Text.Trim();
            pTesis.cites = txt_citesista.Text.Trim();
            pTesis.nombtes = txt_nomtutor.Text.Trim();
            pTesis.especialidadtes = txt_especialidad.Text.Trim();
            pTesis.codites = txt_codtutor.Text.Trim();

            int resultado = tesisBD.Agregar(pTesis);
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
       public void Limpiar()
        {
            txt_codigo.Clear();
            txt_titulo.Clear();
            txt_carreraa.Clear();
            txt_nombreTesista.Clear();
            txt_citesista.Clear();
            txt_nomtutor.Clear();
            txt_especialidad.Clear();
            txt_codtutor.Clear();

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

        private void bto_mostrar_li_Click(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = tesisBD.Buscar();
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
