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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void botonMenu1_Click(object sender, EventArgs e)
        {

        }

        private void botonMenu2_Click(object sender, EventArgs e)
        {
            Login ventana1 = new Login();
            ventana1.FormClosed += (s, args) => this.Close();
            ventana1.Show();
            this.Hide();
        }

        private void botonMenu6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INGRESAR1_Click(object sender, EventArgs e)
        {

        }

        private void tarjetaTienda3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
