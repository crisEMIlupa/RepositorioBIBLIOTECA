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
    public partial class registroEstu : Form
    {
        listaEstudiante lis_estudiante;
        public registroEstu()
        {
            lis_estudiante = new listaEstudiante();//INICIALIZO 
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bto_mostrar_estu_Click(object sender, EventArgs e)
        {
            /* nodoEstudiante cab = lis_estudiante.vacio();//METODO QUE DEVUELVE LA CABEZA DE LA 

             if (cab == null)
             {
                 MessageBox.Show("NO HAY LIBROS REGISTRADOS PARA MOSTRAR");
             }
             else
             {
                 lst_estudiante.Items.Add("////////////////////////////////////");
                 while (cab != null)
                 {
                     lst_estudiante.Items.Add("NOMBRE:" + cab.get_nombre());
                     lst_estudiante.Items.Add("CODIGO:" + cab.get_codigo());
                     lst_estudiante.Items.Add("CARRERA: " + cab.get_carrera());
                     lst_estudiante.Items.Add("SEMESTRE: " + cab.get_semestre());
                     lst_estudiante.Items.Add("TELEFONO: " + cab.get_telefono());
                     lst_estudiante.Items.Add("DOMICILIO: " + cab.get_domicilio());
                     lst_estudiante.Items.Add("////////////////////////////////////");
                     cab = cab.get_sig();//MUEVO LA CABEZA AL SIG
                 }
             }*/
            dgvBuscar.DataSource = tesisBD.Buscar();
        }

        private void bto_registrar_Click(object sender, EventArgs e)
        {
            /* string titu = (txt_nomb.Text);
             string cog = (txt_codigo.Text);
             string edi = (txt_carr.Text);
             string edito = (txt_semestre.Text);
             int aut = int.Parse(txt_telefono.Text);
             string carre = (txt_domicilio.Text);

             lis_estudiante.crear_lista(titu, cog, edi, edito, aut, carre);
             //LIMPIAR
             txt_nomb.Clear();
             txt_codigo.Text = "";
             txt_carr.Text = "";
             txt_semestre.Clear();
             txt_telefono.Clear();
             txt_domicilio.Clear();

             // lst_libro.Items.Clear();
             //
             //TXT_CODIGO_MOVIL.Focus();*/


            estudiante pEstidiante = new estudiante();
            pEstidiante.codEstu = txt_codigo.Text.Trim();
            pEstidiante.nombreEstu = txt_nomb.Text.Trim();
            pEstidiante.semestreEstu = txt_semestre.Text.Trim();
            pEstidiante.carreraEstu = txt_carr.Text.Trim();
            pEstidiante.domicilioEstu = txt_domicilio.Text.Trim();
            pEstidiante.telefonoEstu = txt_telefono.Text.Trim();
            

            int resultado = estudianteBD.Agregar(pEstidiante);
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
            txt_nomb.Clear();
            txt_semestre.Clear();
            txt_carr.Clear();
            txt_domicilio.Clear();
            txt_telefono.Clear();
            

        }
        private void bto_volver_Click(object sender, EventArgs e)
        {
            inicio usu = new inicio();
            this.Hide();
            usu.Show();
        }
    }
}
