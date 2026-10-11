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
            string correo = (inicio_nombre.Text ?? "").Trim().ToLower();
            string password = inicioPassword.Text ?? ""; 

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese el correo y la contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuarios_db.Usuarios.ContainsKey(correo) && usuarios_db.Usuarios[correo].Password == password)
            {                
                var usuario = usuarios_db.Usuarios[correo];             
                sesion_actual.Correo = correo;
                sesion_actual.Nombre = usuario.Nombre;
                sesion_actual.TipoUsuario = usuario.TipoUsuario;
                sesion_actual.Saldo = usuario.Saldo;
                sesion_actual.Telefono = usuario.Telefono;
                sesion_actual.fecha_registro = usuario.fecha_registro;
                sesion_actual.Busquedas_restantes = usuario.Busquedas_restantes; 
                sesion_actual.Img = usuario.Img;

                Pantallas.cambiar<Inicio>(this);
            }
            else  { MessageBox.Show("Correo o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }




    }


}