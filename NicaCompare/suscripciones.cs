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
    public partial class Form8 : Form
    {
        private void Form8_Load(object sender, EventArgs e) { }
        public Form8()
        {InitializeComponent(); cargar_datos_usuario();}
        private void cargar_datos_usuario()
        {
            if (GestorUsuario.ValidarSesion()) {
                label_nombre.Text = sesion_actual.Nombre;
                label_plan.Text = "Plan Actual :" + sesion_actual.TipoUsuario;
                label_correo.Text = sesion_actual.Correo;
                label_saldo.Text = "Saldo: C$" + sesion_actual.Saldo.ToString("0");
                avatar_planes.Image = Imgagenes.Obtener(sesion_actual.Img, "usuario");
            }
            else {
                label_nombre.Visible = false;
                label_plan.Visible = false;
                label_correo.Visible = false;
                label_saldo.Visible = false;
                avatar_planes.Visible = false;
            }
        }
        private void procesar_plan(string plan, int costo, int busquedasExtra)
        {
            // validar si hay sesion activa
            if (!GestorUsuario.ValidarSesion())
            {
                if (MessageBox.Show("Inicia Sesion👤 , Para activar Plan 😀", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Pantallas.cambiar<Login>(this);
                }
                return;
            }

            int Saldo = sesion_actual.Saldo;
            int restante = Saldo - costo;

            // validar si el saldo alcanza para el plan
            if (Saldo < costo)
            {
                if (MessageBox.Show("Saldo insuficiente, ¿desea recargar?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {recargar_saldo(this, EventArgs.Empty);}
            }
            else
            {
                if (MessageBox.Show(
                    $"¿Deseas cambiar al plan **{plan}**?\n\n" +
                    $"Precio: C$ {costo}/mes\n" +
                    $"Saldo actual: C$ {Saldo}\n" +
                    $"Saldo restante: C$ {restante}",
                    "Completar Suscripción",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // actualizamos saldo tipo de usuario y sumamos las busquedas del plan
                    GestorUsuario.Actualizar(
                        correo: sesion_actual.Correo,
                        TipoUsuario: plan,
                        Saldo: restante,
                        Busquedas: sesion_actual.Busquedas_restantes + busquedasExtra
                    );

                    MessageBox.Show
                        ($"¡El Plan {plan} ha sido adquirido con éxito!\n\nNuevo Saldo: C$ " +
                        $"{sesion_actual.Saldo}\nBusquedas disponibles: {sesion_actual.Busquedas_restantes}", 
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    Pantallas.cambiar<Form6>(this); // ir a la pantalla del perfil
                }
            }
        }

        // funciones de los botones de los planes (llama a una funcionpasando el dato para reutilizar la funcion)
        private void tarjetaPlan1_ClickSeleccionar(object sender, EventArgs e) { procesar_plan("Básico 🔹", 49, 100); }
        private void tarjetaPlan2_ClickSeleccionar(object sender, EventArgs e) { procesar_plan("Premium 💎", 99, 300); }
        private void tarjetaPlan3_ClickSeleccionar(object sender, EventArgs e) { procesar_plan("Plan Elite 👑", 149, 500); }
        private void recargar_saldo(object sender, EventArgs e) { Pantallas.cambiar<Form7>(this);}

        private void btn_volver_Click(object sender, EventArgs e)
        {

            if (GestorUsuario.ValidarSesion()) {Pantallas.cambiar<Form6>(this);}
            else{Pantallas.cambiar<Inicio>(this);}
        }
    }
}