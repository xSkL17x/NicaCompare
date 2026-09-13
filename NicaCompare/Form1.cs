using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace NicaCompare
{
    public partial class Login : Form
    {
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void btningresar_Paint(object sender, PaintEventArgs e) { }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void inicio_nombre_TextChanged(object sender, EventArgs e) { }

        public Login() { InitializeComponent(); }

        //█████ █████  ███  █   █      █   
        //  █   █     █   █ ██ ██     ██   
        //  █   ████  █████ █ █ █      █   
        //  █   █     █   █ █   █      █   
        //  █   █████ █   █ █   █     ███  

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro ventana2 = new Registro();
            ventana2.FormClosed += (s, args) => this.Close();
            ventana2.Show();
            this.Hide();
        }

        private void IniciarSecion(object sender, EventArgs e)
        {
            string correo = (inicio_nombre.Text ?? "").Trim().ToLower(); //input del form
            string password = inicioPassword.Text ?? ""; //input del form

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese el correo y la contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Usuarios_Guardados.Usuarios.ContainsKey(correo) && Usuarios_Guardados.Usuarios[correo].Password == password) // buscar en los Usuarios
            {
                Inicio ventana3 = new Inicio();
                ventana3.FormClosed += (s, args) => this.Close();
                ventana3.Show();
                this.Hide();
            }
            else { MessageBox.Show("Correo o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }

    public static class Usuarios_Guardados
    {
        public static Dictionary<string, (string Nombre, string Password)> Usuarios = new Dictionary<string, (string Nombre, string Password)>
        {
            { "skl@unan.ni", ("Skl", "17") },
            { "oto@.unan.ni", ("Oto", "123") },
            { "jahary@.unan.ni", ("Jahary", "123") },
            { "moises@.unan.ni", ("Moises", "123") }
        };
    }
}