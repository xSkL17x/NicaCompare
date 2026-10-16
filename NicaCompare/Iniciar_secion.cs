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


        // //❍﹏﹏﹏﹏﹏﹏ Botones para moverse entre pantalla ──────────────╮
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { Pantallas.cambiar<Registro>(this); }
        private void btn_iniciar_sincuenta_Click(object sender, EventArgs e) { Pantallas.cambiar<Inicio>(this); }

        // //❍﹏﹏﹏﹏﹏﹏ Botones Inicio de secion ──────────────╮
        private void IniciarSecion(object sender, EventArgs e)
        {
            string correo = (inicio_nombre.Text ?? "").Trim().ToLower();
            string password = inicioPassword.Text ?? ""; 

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password)) // validacion de campos vacios
            {
                MessageBox.Show("Por favor, ingrese el correo y la contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validacion de correo y contraseña
            if (usuarios_db.Usuarios.ContainsKey(correo) && usuarios_db.Usuarios[correo].Password == password)
            {

                // si el usuario existe cargar datos de usuario en la sesion actual (variable globales para manejo de secion)
                var usuario = usuarios_db.Usuarios[correo];             
                sesion_actual.Correo = correo;
                sesion_actual.Nombre = usuario.Nombre;
                sesion_actual.TipoUsuario = usuario.TipoUsuario;
                sesion_actual.Saldo = usuario.Saldo;
                sesion_actual.Telefono = usuario.Telefono;
                sesion_actual.fecha_registro = usuario.fecha_registro;
                sesion_actual.Busquedas_restantes = usuario.Busquedas_restantes; 
                sesion_actual.Img = usuario.Img;

                Pantallas.cambiar<Inicio>(this); // luego de cargar los datos ir a la pantalla de inicio
            }
            // si no encuentra usuario mostrar mensaje de error
            else { MessageBox.Show("Correo o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }




    }


}