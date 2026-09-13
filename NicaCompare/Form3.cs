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
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void botonMenu1_Click(object sender, EventArgs e) { }
        private void botonMenu6_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void INGRESAR1_Click(object sender, EventArgs e) { }
        private void tarjetaTienda3_CheckedChanged(object sender, EventArgs e) { }
        private void tarjetaTienda2_CheckedChanged(object sender, EventArgs e) { }

        public Inicio()
        {
            InitializeComponent();
            CargarUsuarioActivo();
        }

        //____________๑.・🍨︴Boton Usuario ✰  ๑_______________
        private void CargarUsuarioActivo()
        {
            if (!string.IsNullOrEmpty(sesion_actual.Nombre)) { boton_usuario.Text = sesion_actual.Nombre; }
        }

        private void boton_usuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sesion_actual.Nombre))
            {
                Login ventana1 = new Login();
                ventana1.FormClosed += (s, args) => this.Close();
                ventana1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Aquí te llevará a la pantalla de usuario.", "Perfil de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}