using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace NicaCompare
{
    public partial class Form6 : Form
    {

        //____________๑.・🗑️︴Apoco lo vamos a ocupar? ︴🗑️✰  ๑_______________
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void imput_telefono_TextChanged(object sender, EventArgs e) { }
        private void campoTexto4_TextChanged(object sender, EventArgs e) { }
        private void label_saldo_Click(object sender, EventArgs e) { }
        
        
        private void label1_Click(object sender, EventArgs e) { }

        // ================= CONSTRUCTOR Y CARGA =================
        public Form6() { InitializeComponent(); cargar_datos_usuario(); }

        private void cargar_datos_usuario()
        {
            avatar1.Image = Imgagenes.Obtener(sesion_actual.Img, "usuario");
            avatar2.Image = Imgagenes.Obtener(sesion_actual.Img, "usuario");
            label_nombre.Text = sesion_actual.Nombre;
            label_correo.Text = sesion_actual.Correo;
            label_fecha.Text = "Usuario desde el " + sesion_actual.fecha_registro.ToString("dd/MM/yyyy");

            imput_correo.Text = sesion_actual.Correo;
            imput_nombre.Text = sesion_actual.Nombre;
            imput_telefono.Text = sesion_actual.Telefono.ToString();
            imput_fecha.Text = sesion_actual.fecha_registro.ToString("dd/MM/yyyy");

            label_tipo_cuenta.Text = "Cuenta " + sesion_actual.TipoUsuario;
            label_saldo.Text = "Saldo: C$ " + sesion_actual.Saldo;
        }

        // cambiar datos de usuario
        private void btn_guardar_cambios_Click(object sender, EventArgs e)
        {
            string correo = sesion_actual.Correo;
            if (!usuarios_db.Usuarios.ContainsKey(correo)) return;

            var usuarioDB = usuarios_db.Usuarios[correo];
            string contraguardada = usuarioDB.Password;

            // Validar Contra, Para Realizar Cambios
            if (imput_contra_actual.Text != contraguardada) { MessageBox.Show("La contraseña actual es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);return;}

            if (!string.IsNullOrWhiteSpace(imput_nuevacontra.Text)) { contraguardada = imput_nuevacontra.Text; } // Para cambiar contraseña del usuario

            // Validar que el telefono sea numerico pa que no truene el programa
            if (!int.TryParse(imput_telefono.Text, out int nuevoTelefono)) { MessageBox.Show("El número de teléfono no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // Actualizamos tanto en el diccionario como en la sesion actual usando la funcion global
            GestorUsuario.Actualizar(
                correo: correo, // no cambia porque es la Key o ID
                Nombre: imput_nombre.Text,
                Password: contraguardada,
                Telefono: nuevoTelefono
            );

            // Limpiamos campos y cargar otra vez los dts del usuario
            imput_contra_actual.Text = "";
            imput_nuevacontra.Text = "";
            cargar_datos_usuario();

            MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // cambiar avatar

        private void btn_cambiar_avatar_Click(object sender, EventArgs e)
        {            
            using (OpenFileDialog ofd = new OpenFileDialog()) // abrimos el selector de archivos
            {
                ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Seleccionar un nuevo Avatar 🥷";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string correo = sesion_actual.Correo;
                    if (string.IsNullOrEmpty(correo)) { return; }

                    // Usando mis funciones globales para que el codigo sea reusable y mas limpio                    
                    Imgagenes.Guardar(ofd.FileName, correo);
                    
                    GestorUsuario.Actualizar( correo: correo,Img: correo);

                    // recargamos la imagen en el pictureBox del perfil usando asset true
                    avatar1.Image = Imgagenes.Obtener(correo, "usuario");
                    avatar2.Image = Imgagenes.Obtener(correo, "usuario");

                    MessageBox.Show("Foto de perfil actualizada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_quitar_avatar_Click(object sender, EventArgs e) // quitar avatar
        {
            string correo = sesion_actual.Correo;

            if (string.IsNullOrEmpty(correo)) { return; } // x seguridad, no aser nada si no hay correo

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro que deseas eliminar tu foto de perfil?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.No) { return; } // si dise no no hacer nada
            
            Imgagenes.Eliminar(correo); // eliminamos el archivo usando la funcion global
            
            GestorUsuario.Actualizar(correo: correo, Img: ""); // actualizar la base de datos simulada y la sesion quitando la imagen
            // restaurar la imagen por defecto en los avatares
            avatar1.Image = Imgagenes.Obtener(correo, "usuario");
            avatar2.Image = Imgagenes.Obtener(correo, "usuario");

            MessageBox.Show("Foto de perfil eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_cancelar_cambios_Click(object sender, EventArgs e) { cargar_datos_usuario(); imput_contra_actual.Text = ""; imput_nuevacontra.Text = ""; }

        //____________๑.・︴btnes y pantallas? ︴✰  ๑_______________
        private void btn_recargar_Click(object sender, EventArgs e) { Pantallas.cambiar<Form7>(this); }
        private void btn_volver_Click(object sender, EventArgs e) { Pantallas.cambiar<Inicio>(this); }
        private void btn_ir_planes_Click(object sender, EventArgs e) { Pantallas.cambiar<Form8>(this); }
        private void botonRecargar_Click(object sender, EventArgs e) { Pantallas.cambiar<Form7>(this); }


    }
}