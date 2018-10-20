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
    public partial class mostrarEst : Form
    {
        listaLibro lis_libro;
        public mostrarEst()
        {
            lis_libro = new listaLibro();//INICIALIZO 
            InitializeComponent();
        }

        private void LST_MOVIL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bto_buscar_Click(object sender, EventArgs e)
        {
            //BUSCAR POR MARCA Y MODELO
            string mar = txt_titulo.Text;
            string mod = txt_autor.Text;
            nodoLibro aux = lis_libro.buscar(mar, mod);
            if (aux == null)
            {
                MessageBox.Show("NO TENEMOS EL LIBRO");
            }
            else
            {
                txt_titulo.Text = aux.get_titulo().ToString();
                txt_autor.Text = aux.get_autor();
               /* CBO_MARCA_MOVIL.Text = aux.get_marca();
                TXT_MODELO_MOVIL.Text = aux.get_modelo();
                TXT_PRECIO_MOVIL.Text = aux.get_precio().ToString();
                TXT_CANTIDAD_MOVIL.Text = aux.get_cantidad().ToString();*/
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
