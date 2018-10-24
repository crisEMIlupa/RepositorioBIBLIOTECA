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
    public partial class RegistrosTodo : Form
    {
        public RegistrosTodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registroLibros usu = new registroLibros();
            this.Hide();
            usu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registroEstu usu = new registroEstu();
            this.Hide();
            usu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registroTesis usu = new registroTesis();
            this.Hide();
            usu.Show();
        }
    }
}
