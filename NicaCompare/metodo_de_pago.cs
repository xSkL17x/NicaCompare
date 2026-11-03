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
        private void botonMenu1_Click(object sender, EventArgs e) { this.Close(); }

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

            Random random = new Random();
            imput_tarjeta_nombre.Text = sesion_actual.Nombre;
            imput_tarjeta.Text = $"4532 {random.Next(1000, 9999)} {random.Next(1000, 9999)} {random.Next(1000, 9999)}";
            imput_cvv.Text = random.Next(100, 999).ToString();
            imput_fecha_expiracion.Text = $"{random.Next(1, 13):D2}/{random.Next(26, 30)}";
        }

        // confirmar pago y recargar saldo validando que la cantidad sea numerica
        private readonly int saldoEnTarjeta = new Random().Next(50, 401);

        private void btn_confirmar_pago_Click(object sender, EventArgs e)
        {
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

            string correo = imput_correo.Text.Trim();
            if (!correo.Contains("@") || (!correo.EndsWith(".com") && !correo.EndsWith(".es") && !correo.EndsWith(".ni")))
            {
                MessageBox.Show("Ingresa un correo electrónico válido ", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(lbl_Cantidad_recargar.Text, out int montoRecarga) || montoRecarga <= 0)
            {
                MessageBox.Show("Ingresa una cantidad numerica valida para recargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (montoRecarga > saldoEnTarjeta)
            {
                MessageBox.Show($"Saldo insuficiente en la tarjeta\n\nTienes disponible: C$ {saldoEnTarjeta}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GestorUsuario.Actualizar(correo: sesion_actual.Correo, Saldo: sesion_actual.Saldo + montoRecarga);
            MessageBox.Show($"¡Recarga realizada con exito!\n\nNuevo Saldo: C$ {sesion_actual.Saldo}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


    }
}