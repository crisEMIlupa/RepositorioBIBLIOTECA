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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bto_ingresar_Click(object sender, EventArgs e)
        {
             inicio bo = new inicio();
            this.Hide();
            bo.Show();

        }
    }
    
}
