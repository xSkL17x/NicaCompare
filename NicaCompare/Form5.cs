using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicaCompare
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            Registro ventana2 = new Registro();
            ventana2.FormClosed += (s, args) => this.Close();
            ventana2.Show();
            this.Hide();
        }
    }
}
