using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace NicaCompare
{
    public partial class Login : Form
    {


        public Login() { InitializeComponent(); }

        //█████ █████  ███  █   █      █   
        //  █   █     █   █ ██ ██     ██   
        //  █   ████  █████ █ █ █      █   
        //  █   █     █   █ █   █      █   
        //  █   █████ █   █ █   █     ███  

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { Pantallas.cambiar<Registro>(this); }
        private void btn_iniciar_sincuenta_Click(object sender, EventArgs e) { Pantallas.cambiar<Inicio>(this); }

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
                sesion_actual.Telefono = usuarios_db.Usuarios[correo].Telefono;
                sesion_actual.fecha_registro = usuarios_db.Usuarios[correo].fecha_registro;

                Pantallas.cambiar<Inicio>(this);
            }
            else { MessageBox.Show("Correo o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        


    }


}