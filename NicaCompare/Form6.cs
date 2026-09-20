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
    public partial class Form6 : Form
    {

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

        private void campoTexto4_TextChanged(object sender, EventArgs e) { }

        private void botonRedondeado1_Click(object sender, EventArgs e) { }
        private void botonRedondeado2_Click(object sender, EventArgs e) { }
        private void botonRedondeado3_Click(object sender, EventArgs e) { }
        private void botonRedondeado4_Click(object sender, EventArgs e) { }

        public Form6()
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

        private void cargar_datos_usuario()
        {
            label_nombre.Text = sesion_actual.Nombre;
        }


    }
    }