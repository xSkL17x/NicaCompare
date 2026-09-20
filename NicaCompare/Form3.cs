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
        private void barraBusqueda1_BuscarClicked(object sender, EventArgs e) { }
        private void Inicio_Load(object sender, EventArgs e) { }
        private void botonMenu2_Click(object sender, EventArgs e) { }
        private void botonMenu2_Click_1(object sender, EventArgs e) { }
        private void barraBusqueda1_BuscarClicked_1(object sender, EventArgs e) { }
        public Inicio()
        {
            InitializeComponent();
            CargarUsuarioActivo();
        }

        //____________๑.・🍨︴Boton Usuario ✰  ๑_______________
        private void CargarUsuarioActivo() { if (!string.IsNullOrEmpty(sesion_actual.Nombre)) { boton_usuario.Text = sesion_actual.Nombre; btn_Usuario_2.Text = sesion_actual.Nombre; } }

        private void boton_usuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sesion_actual.Nombre))
            {
                Form5 Registro2 = new Form5(); Registro2.FormClosed += (s, args) => this.Close();
                Registro2.Show(); this.Hide();
            }
            else
            {
                Form6 Perfil = new Form6(); Perfil.FormClosed += (s, args) => this.Close();
                Perfil.Show(); this.Hide();
            }
        }


    }
}