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
    public partial class Form5 : Form
    {
        private void label1_Click(object sender, EventArgs e) { }
        public Form5() { InitializeComponent(); }

        private void botonRedondeado1_Click(object sender, EventArgs e){Pantallas.cambiar<Registro>(this);}

        private void btn_volver_Click(object sender, EventArgs e){ Pantallas.cambiar<Inicio>(this); }

    }
}
