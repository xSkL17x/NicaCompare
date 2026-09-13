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
        private void inicioPassword_TextChanged(object sender, EventArgs e) { }

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
            string correo = (inicio_nombre.Text ?? "").Trim().ToLower(); //input en el diseno
            string password = inicioPassword.Text ?? ""; //input en el diseno

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            { MessageBox.Show("Por favor, ingrese el correo y la contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (usuarios_db.Usuarios.ContainsKey(correo) && usuarios_db.Usuarios[correo].Password == password)
            {
                sesion_actual.Correo = correo;
                sesion_actual.Nombre = usuarios_db.Usuarios[correo].Nombre;
                sesion_actual.TipoUsuario = usuarios_db.Usuarios[correo].TipoUsuario;
                sesion_actual.Saldo = usuarios_db.Usuarios[correo].Saldo;

                Inicio ventana3 = new Inicio();
                ventana3.FormClosed += (s, args) => this.Close();
                ventana3.Show();
                this.Hide();
            }
            else { MessageBox.Show("Correo o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_iniciar_sincuenta_Click(object sender, EventArgs e)
        {

            Inicio ventana3 = new Inicio();
            ventana3.FormClosed += (s, args) => this.Close();
            ventana3.Show();
            this.Hide();

        }
    }


}