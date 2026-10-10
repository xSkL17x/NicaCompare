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
        public Form7()
        {
            if (string.IsNullOrEmpty(sesion_actual.Nombre))
            {
                Inicio home = new Inicio();
                home.FormClosed += (s, args) => this.Close();
                home.Show();
                this.Hide();
                return;
            }

            InitializeComponent();
            cargar_datos_usuario();
        }

        private void Form7_Load(object sender, EventArgs e) { }
        private void campoTexto1_TextChanged(object sender, EventArgs e) { }
        private void campoTexto5_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void campoTexto6_TextChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void campoTexto2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void botonMenu1_Click(object sender, EventArgs e)
        {
            Form6 home = new Form6();
            home.FormClosed += (s, args) => this.Close();
            home.Show();
            this.Hide();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void imput_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void imput_cvv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void campoTexto1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
