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
    public partial class mostrarLibros : Form
    {
        public mostrarLibros()
        {
            InitializeComponent();
        }

        private void bto_atras_Click(object sender, EventArgs e)
        {
            registroLibros bo = new registroLibros();
            this.Hide();
            bo.Show();
        }

        private void BTO_mostar_libro_Click(object sender, EventArgs e)
        {
        }
    }
}
