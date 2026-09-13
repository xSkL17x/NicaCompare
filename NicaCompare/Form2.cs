using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace NicaCompare
{
    public partial class Registro : Form
    {
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void campoTexto1_TextChanged(object sender, EventArgs e) { }

        public Registro() { InitializeComponent(); }

        //╰┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈┈➤ㄅқŁ ⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘⫘

        private void ir_al_login(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ventana1 = new Login();
            ventana1.FormClosed += (s, args) => this.Close();
            ventana1.Show();
            this.Hide();
        }

        private void Crear_Cuenta(object sender, EventArgs e)
        {
            string nombre = (registro_nombre.Text ?? "").Trim();
            string correo = (registro_correo.Text ?? "").Trim().ToLower();
            string password = campoPassword1.Text ?? "";
            string passwordConf = campoPassword2.Text ?? "";

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordConf))
            { MessageBox.Show("Por favor, llene todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;}

            if (!correo.Contains("@") || (!correo.EndsWith(".com") && !correo.EndsWith(".ni") && !correo.EndsWith(".es")))
            { MessageBox.Show("Porfavor Ingrese Un Correo Válido", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (password.Length < 5)
            { MessageBox.Show("La contraseña debe tener al menos 5 caracteres.", "Contraseña muy corta", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (password != passwordConf)
            { MessageBox.Show("Las contraseñas no coinciden.", "Error en contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);  return; }

            if (Usuarios_Guardados.Usuarios.ContainsKey(correo))
            { MessageBox.Show("El correo ya se encuentra registrado.", "Registro denegado", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            Usuarios_Guardados.Usuarios.Add(correo, (nombre, password));

            MessageBox.Show($"{nombre} su Cuenta fue Creada con exito\n\nCorreo: {correo}", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login ventanaLogin = new Login();
            ventanaLogin.FormClosed += (s, args) => this.Close();
            ventanaLogin.Show();
            this.Hide();
        }
    }
}