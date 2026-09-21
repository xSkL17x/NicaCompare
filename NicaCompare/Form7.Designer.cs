namespace NicaCompare
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label9 = new Label();
            label10 = new Label();
            imput_tarjeta = new CampoTexto();
            imput_tarjeta_nombre = new CampoTexto();
            imput_fecha_expiracion = new CampoTexto();
            imput_cvv = new CampoTexto();
            imput_nombre = new CampoTexto();
            imput_correo = new CampoTexto();
            imput_telefono = new CampoTexto();
            imput_direccion = new CampoTexto();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            botonRedondeado1 = new BotonRedondeado();
            btn_volver = new BotonMenu();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(503, 24);
            label9.Name = "label9";
            label9.Size = new Size(204, 32);
            label9.TabIndex = 13;
            label9.Text = "Método de pago";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(394, 71);
            label10.Name = "label10";
            label10.Size = new Size(418, 19);
            label10.TabIndex = 14;
            label10.Text = "Ingresa los datos de tu metodo de pago para completar tu compra";
            // 
            // imput_tarjeta
            // 
            imput_tarjeta.BackColor = Color.Transparent;
            imput_tarjeta.BorderColor = Color.FromArgb(228, 231, 236);
            imput_tarjeta.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_tarjeta.BorderRadius = 12;
            imput_tarjeta.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_tarjeta.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_tarjeta.EsPassword = false;
            imput_tarjeta.IconoPersonalizado = null;
            imput_tarjeta.Location = new Point(16, 57);
            imput_tarjeta.Margin = new Padding(3, 2, 3, 2);
            imput_tarjeta.Name = "imput_tarjeta";
            imput_tarjeta.PlaceholderText = "1234 5678 9101 1121";
            imput_tarjeta.Size = new Size(634, 35);
            imput_tarjeta.TabIndex = 15;
            imput_tarjeta.TipoIcono = TipoIconoCampo.Tarjeta;
            imput_tarjeta.TextChanged += campoTexto1_TextChanged;
            // 
            // imput_tarjeta_nombre
            // 
            imput_tarjeta_nombre.BackColor = Color.Transparent;
            imput_tarjeta_nombre.BorderColor = Color.FromArgb(228, 231, 236);
            imput_tarjeta_nombre.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_tarjeta_nombre.BorderRadius = 12;
            imput_tarjeta_nombre.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_tarjeta_nombre.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_tarjeta_nombre.EsPassword = false;
            imput_tarjeta_nombre.IconoPersonalizado = null;
            imput_tarjeta_nombre.Location = new Point(10, 133);
            imput_tarjeta_nombre.Margin = new Padding(3, 2, 3, 2);
            imput_tarjeta_nombre.Name = "imput_tarjeta_nombre";
            imput_tarjeta_nombre.PlaceholderText = "Como aparece en la tarjeta";
            imput_tarjeta_nombre.Size = new Size(306, 35);
            imput_tarjeta_nombre.TabIndex = 16;
            imput_tarjeta_nombre.TipoIcono = TipoIconoCampo.Usuario;
            imput_tarjeta_nombre.TextChanged += campoTexto2_TextChanged;
            // 
            // imput_fecha_expiracion
            // 
            imput_fecha_expiracion.BackColor = Color.Transparent;
            imput_fecha_expiracion.BorderColor = Color.FromArgb(228, 231, 236);
            imput_fecha_expiracion.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_fecha_expiracion.BorderRadius = 12;
            imput_fecha_expiracion.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_fecha_expiracion.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_fecha_expiracion.EsPassword = false;
            imput_fecha_expiracion.IconoPersonalizado = null;
            imput_fecha_expiracion.Location = new Point(338, 133);
            imput_fecha_expiracion.Margin = new Padding(3, 2, 3, 2);
            imput_fecha_expiracion.Name = "imput_fecha_expiracion";
            imput_fecha_expiracion.PlaceholderText = "MM / AA";
            imput_fecha_expiracion.Size = new Size(306, 35);
            imput_fecha_expiracion.TabIndex = 17;
            imput_fecha_expiracion.TipoIcono = TipoIconoCampo.Calendario;
            // 
            // imput_cvv
            // 
            imput_cvv.BackColor = Color.Transparent;
            imput_cvv.BorderColor = Color.FromArgb(228, 231, 236);
            imput_cvv.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_cvv.BorderRadius = 12;
            imput_cvv.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_cvv.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_cvv.EsPassword = false;
            imput_cvv.IconoPersonalizado = null;
            imput_cvv.Location = new Point(10, 196);
            imput_cvv.Margin = new Padding(3, 2, 3, 2);
            imput_cvv.Name = "imput_cvv";
            imput_cvv.PlaceholderText = "123";
            imput_cvv.Size = new Size(306, 35);
            imput_cvv.TabIndex = 18;
            imput_cvv.TipoIcono = TipoIconoCampo.Tarjeta;
            // 
            // imput_nombre
            // 
            imput_nombre.BackColor = Color.Transparent;
            imput_nombre.BorderColor = Color.FromArgb(228, 231, 236);
            imput_nombre.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_nombre.BorderRadius = 12;
            imput_nombre.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_nombre.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_nombre.EsPassword = false;
            imput_nombre.IconoPersonalizado = null;
            imput_nombre.Location = new Point(16, 299);
            imput_nombre.Margin = new Padding(3, 2, 3, 2);
            imput_nombre.Name = "imput_nombre";
            imput_nombre.PlaceholderText = "Tu nombre completo";
            imput_nombre.Size = new Size(306, 35);
            imput_nombre.TabIndex = 19;
            imput_nombre.TipoIcono = TipoIconoCampo.Usuario;
            imput_nombre.TextChanged += campoTexto5_TextChanged;
            // 
            // imput_correo
            // 
            imput_correo.BackColor = Color.Transparent;
            imput_correo.BorderColor = Color.FromArgb(228, 231, 236);
            imput_correo.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_correo.BorderRadius = 12;
            imput_correo.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_correo.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_correo.EsPassword = false;
            imput_correo.IconoPersonalizado = null;
            imput_correo.Location = new Point(338, 299);
            imput_correo.Margin = new Padding(3, 2, 3, 2);
            imput_correo.Name = "imput_correo";
            imput_correo.PlaceholderText = "correo@ejemplo.com";
            imput_correo.Size = new Size(306, 35);
            imput_correo.TabIndex = 19;
            imput_correo.TipoIcono = TipoIconoCampo.Correo;
            imput_correo.TextChanged += campoTexto6_TextChanged;
            // 
            // imput_telefono
            // 
            imput_telefono.BackColor = Color.Transparent;
            imput_telefono.BorderColor = Color.FromArgb(228, 231, 236);
            imput_telefono.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_telefono.BorderRadius = 12;
            imput_telefono.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_telefono.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_telefono.EsPassword = false;
            imput_telefono.IconoPersonalizado = null;
            imput_telefono.Location = new Point(10, 366);
            imput_telefono.Margin = new Padding(3, 2, 3, 2);
            imput_telefono.Name = "imput_telefono";
            imput_telefono.PlaceholderText = "+505 8*** ****";
            imput_telefono.Size = new Size(306, 35);
            imput_telefono.TabIndex = 20;
            imput_telefono.TipoIcono = TipoIconoCampo.Telefono;
            // 
            // imput_direccion
            // 
            imput_direccion.BackColor = Color.Transparent;
            imput_direccion.BorderColor = Color.FromArgb(228, 231, 236);
            imput_direccion.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_direccion.BorderRadius = 12;
            imput_direccion.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_direccion.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_direccion.EsPassword = false;
            imput_direccion.IconoPersonalizado = null;
            imput_direccion.Location = new Point(338, 366);
            imput_direccion.Margin = new Padding(3, 2, 3, 2);
            imput_direccion.Name = "imput_direccion";
            imput_direccion.PlaceholderText = "Dirección, ciudad, departamento";
            imput_direccion.Size = new Size(306, 35);
            imput_direccion.TabIndex = 21;
            imput_direccion.TipoIcono = TipoIconoCampo.Ubicacion;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(254, 8);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 22;
            label4.Text = "Datos de tarjeta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(10, 113);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 23;
            label1.Text = "Nombre del titular";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(340, 113);
            label2.Name = "label2";
            label2.Size = new Size(143, 19);
            label2.TabIndex = 24;
            label2.Text = "Fecha de expiración";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(16, 177);
            label3.Name = "label3";
            label3.Size = new Size(193, 19);
            label3.TabIndex = 25;
            label3.Text = "Código de Seguridad (CVV)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(16, 280);
            label5.Name = "label5";
            label5.Size = new Size(133, 19);
            label5.TabIndex = 26;
            label5.Text = "Nombre completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(340, 280);
            label6.Name = "label6";
            label6.Size = new Size(135, 19);
            label6.TabIndex = 27;
            label6.Text = "Correo electronico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(10, 346);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 28;
            label7.Text = "Teléfono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(338, 346);
            label8.Name = "label8";
            label8.Size = new Size(172, 19);
            label8.TabIndex = 29;
            label8.Text = "Dirección de facturación";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(botonRedondeado1);
            panel1.Controls.Add(imput_tarjeta);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(imput_tarjeta_nombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(imput_cvv);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(imput_nombre);
            panel1.Controls.Add(imput_fecha_expiracion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(imput_telefono);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(imput_correo);
            panel1.Controls.Add(imput_direccion);
            panel1.Location = new Point(282, 109);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 464);
            panel1.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(16, 38);
            label11.Name = "label11";
            label11.Size = new Size(133, 19);
            label11.TabIndex = 31;
            label11.Text = "Numero de tarjeta";
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.Blue;
            botonRedondeado1.BorderRadius = 20;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(439, 412);
            botonRedondeado1.Margin = new Padding(3, 2, 3, 2);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(175, 38);
            botonRedondeado1.TabIndex = 30;
            botonRedondeado1.Text = "Confirmar   →";
            botonRedondeado1.UseVisualStyleBackColor = false;
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.None;
            btn_volver.AutoColorearIconoBlanco = true;
            btn_volver.AutoEscalarImagen = true;
            btn_volver.BackColor = Color.Transparent;
            btn_volver.BorderRadius = 18;
            btn_volver.ColorHover = Color.FromArgb(13, 110, 253);
            btn_volver.ColorTextoNormal = Color.FromArgb(0, 0, 192);
            btn_volver.EsSeleccionado = false;
            btn_volver.FlatAppearance.BorderSize = 0;
            btn_volver.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_volver.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btn_volver.ForeColor = Color.FromArgb(0, 0, 192);
            btn_volver.Location = new Point(1129, 12);
            btn_volver.MargenImagenIzquierda = 15;
            btn_volver.Margin = new Padding(3, 2, 3, 2);
            btn_volver.Name = "btn_volver";
            btn_volver.PorcentajeEscalaImagen = 50;
            btn_volver.Size = new Size(136, 31);
            btn_volver.TabIndex = 31;
            btn_volver.Text = "←      Volver";
            btn_volver.TextAlign = ContentAlignment.MiddleLeft;
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += botonMenu1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1264, 681);
            Controls.Add(btn_volver);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recargar 💳";
            WindowState = FormWindowState.Maximized;
            Load += Form7_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label10;
        private CampoTexto imput_tarjeta;
        private CampoTexto imput_tarjeta_nombre;
        private CampoTexto imput_fecha_expiracion;
        private CampoTexto imput_cvv;
        private CampoTexto imput_nombre;
        private CampoTexto imput_correo;
        private CampoTexto imput_telefono;
        private CampoTexto imput_direccion;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private BotonMenu btn_volver;
        private BotonRedondeado botonRedondeado1;
        private Label label11;
    }
}