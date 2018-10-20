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
    public partial class registroLibros : Form
    {
        listaLibro lis_libro;
        public registroLibros()
        {
            InitializeComponent();
            lis_libro = new listaLibro();//INICIALIZO 
        }

        private void bto_registrar_Click(object sender, EventArgs e)
        {
            string titu = (txt_titulo.Text);
            string cog = (txt_codigo.Text);
            string edi = (txt_edicion.Text);
            string edito = (txt_editorial.Text);
            string aut = (txt_autor.Text);
            string carre = (txt_carrera.Text);
            string mat = (txt_materia.Text);
           lis_libro.crear_lista(titu,cog, edi,edito , aut, carre, mat);
            //LIMPIAR
            txt_titulo.Clear();
            txt_codigo.Text = "";
            txt_edicion.Text = "";
            txt_editorial.Clear();
            txt_autor.Clear();
            txt_carrera.Clear();
            txt_materia.Clear();
           // lst_libro.Items.Clear();
            //
            //TXT_CODIGO_MOVIL.Focus();
        }

        private void bto_mostrar_li_Click(object sender, EventArgs e)
        {
            nodoLibro cab = lis_libro.vacio();//METODO QUE DEVUELVE LA CABEZA DE LA 

            if (cab == null)
            {
                MessageBox.Show("NO HAY LIBROS REGISTRADOS PARA MOSTRAR");
            }
            else
            {
                lst_libro.Items.Add("////////////////////////////////////");
                while (cab != null)
                {
                    lst_libro.Items.Add("TITULO:" + cab.get_titulo());
                    lst_libro.Items.Add("CODIGO:" + cab.get_codigo());
                    lst_libro.Items.Add("EDICION: " + cab.get_edicion());
                    lst_libro.Items.Add("EDITORIAL: " + cab.get_editorial());
                    lst_libro.Items.Add("AUTOR: " + cab.get_autor());
                    lst_libro.Items.Add("CARRERA: " + cab.get_carrera());
                    lst_libro.Items.Add("MATERIA: " + cab.get_materia());
                    lst_libro.Items.Add("////////////////////////////////////");
                    cab = cab.get_sig();//MUEVO LA CABEZA AL SIG
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio usu = new inicio();
            this.Hide();
            usu.Show();
        }
    }

       
    
}
