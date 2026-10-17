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
    public partial class Form7 : Form
    {
        //____________๑.・🗑️︴Funciones sin ocupar? ︴🗑️✰  ๑_______________
        private void Form7_Load(object sender, EventArgs e) { }
        private void campoTexto1_TextChanged(object sender, EventArgs e) { }
        private void campoTexto5_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void campoTexto6_TextChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void campoTexto2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label8_Click() { }
        private void label8_Click(object sender, EventArgs e) { }
        private void imput_telefono_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void imput_cvv_TextChanged(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void campoTexto1_TextChanged_1(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        //____________๑.・︴btnes y pantallas? ︴✰  ๑_______________
        private void botonMenu1_Click(object sender, EventArgs e) { Pantallas.cambiar<Form6>(this);}

        // ================= CONSTRUCTOR Y CARGA =================
        public Form7()
        {
            if (string.IsNullOrEmpty(sesion_actual.Nombre)) {Pantallas.cambiar<Inicio>(this);}
            InitializeComponent();
            cargar_datos_usuario();
        }

        private void cargar_datos_usuario()
        {
            imput_correo.Text = sesion_actual.Correo;
            imput_nombre.Text = sesion_actual.Nombre;
            imput_telefono.Text = sesion_actual.Telefono.ToString();

            Random rand = new Random();
            imput_tarjeta_nombre.Text = sesion_actual.Nombre;
            imput_tarjeta.Text = $"4532 {rand.Next(1000, 9999)} {rand.Next(1000, 9999)} {rand.Next(1000, 9999)}";
            imput_cvv.Text = rand.Next(100, 999).ToString();
            imput_fecha_expiracion.Text = $"{rand.Next(1, 13):D2}/{rand.Next(26, 30)}";
        }

        // confirmar pago y recargar saldo validando que la cantidad sea numerica
        private void btn_confirmar_pago_Click(object sender, EventArgs e)
        {
            // validar que todos los campos obligatorios esten llenos
            if (string.IsNullOrWhiteSpace(imput_tarjeta.Text) ||
                string.IsNullOrWhiteSpace(imput_tarjeta_nombre.Text) ||
                string.IsNullOrWhiteSpace(imput_cvv.Text) ||
                string.IsNullOrWhiteSpace(imput_fecha_expiracion.Text) ||
                string.IsNullOrWhiteSpace(imput_nombre.Text) ||
                string.IsNullOrWhiteSpace(imput_telefono.Text) ||
                string.IsNullOrWhiteSpace(imput_correo.Text) ||
                string.IsNullOrWhiteSpace(imput_direccion.Text) ||
                string.IsNullOrWhiteSpace(lbl_Cantidad_recargar.Text))
            {
                MessageBox.Show("Por favor llena todos los campos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(lbl_Cantidad_recargar.Text, out int montoRecarga) || montoRecarga <= 0) //validar que sea numero y que no sea 0 o menos
            {
                MessageBox.Show("Ingresa una cantidad numerica valida para recargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // simular un saldo random en la tarjeta entre 50 y 400, pa mas chido
            Random rand = new Random();
            int saldoEnTarjeta = rand.Next(50, 401);

            // validar si el saldo en la tarjeta cubre la recarga
            if (montoRecarga > saldoEnTarjeta)
            {
                MessageBox.Show($"Saldo insuficiente en la tarjeta\n\nTienes disponible: C$ {saldoEnTarjeta}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // actualizar el saldo usando la funcion global GestorUsuario
            GestorUsuario.Actualizar(correo: sesion_actual.Correo,Saldo: sesion_actual.Saldo + montoRecarga);

            MessageBox.Show($"¡Recarga realizada con exito!\n\nNuevo Saldo: C$ {sesion_actual.Saldo}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // regresar a la pantalla del perfil (Form6)
            Pantallas.cambiar<Form6>(this);
        }


    }
}