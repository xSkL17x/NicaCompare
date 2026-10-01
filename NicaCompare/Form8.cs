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
            label_plan.Text = "Plan Actual :" + sesion_actual.TipoUsuario;
            label_correo.Text = sesion_actual.Correo;
            label_saldo.Text = "Saldo: C$" + sesion_actual.Saldo.ToString("0");
        }
        private void procesar_plan(string plan, int costo)
        {
            if (sesion_actual.Saldo < costo)
            {
                if (MessageBox.Show("Saldo insuficiente, ¿desea recargar?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    recargar_saldo(this, EventArgs.Empty);
            }
            else
            {
                sesion_actual.Saldo -= costo;
                cargar_datos_usuario();
            }
        }
        private void tarjetaPlan1_ClickSeleccionar(object sender, EventArgs e) { procesar_plan("Plan Básico", 49); }
        private void tarjetaPlan2_ClickSeleccionar(object sender, EventArgs e) { procesar_plan("Plan Intermedio", 99); }
        private void tarjetaPlan3_ClickSeleccionar(object sender, EventArgs e) { procesar_plan("Plan Premium", 149); }
        private void recargar_saldo(object sender, EventArgs e) { Form7 recargar = new Form7(); recargar.FormClosed += (s, args) => this.Close(); recargar.Show(); this.Hide(); }
    }
}