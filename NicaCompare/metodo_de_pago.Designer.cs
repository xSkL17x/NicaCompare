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
            campoTexto1 = new CampoTexto();
            label11 = new Label();
            botonRedondeado1 = new BotonRedondeado();
            btn_volver = new BotonMenu();
            label12 = new Label();
            label13 = new Label();
            panel2 = new Panel();
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
            label9.Location = new Point(575, 32);
            label9.Name = "label9";
            label9.Size = new Size(253, 41);
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
            label10.Location = new Point(450, 95);
            label10.Name = "label10";
            label10.Size = new Size(522, 23);
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
            imput_tarjeta.Location = new Point(11, 85);
            imput_tarjeta.Name = "imput_tarjeta";
            imput_tarjeta.PlaceholderText = "1234 5678 9101 1121";
            imput_tarjeta.Size = new Size(725, 47);
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
            imput_tarjeta_nombre.Location = new Point(11, 174);
            imput_tarjeta_nombre.Name = "imput_tarjeta_nombre";
            imput_tarjeta_nombre.PlaceholderText = "Como aparece en la tarjeta";
            imput_tarjeta_nombre.Size = new Size(552, 47);
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
            imput_fecha_expiracion.Location = new Point(386, 266);
            imput_fecha_expiracion.Name = "imput_fecha_expiracion";
            imput_fecha_expiracion.PlaceholderText = "MM / AA";
            imput_fecha_expiracion.Size = new Size(350, 47);
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
            imput_cvv.Location = new Point(11, 266);
            imput_cvv.Name = "imput_cvv";
            imput_cvv.PlaceholderText = "123";
            imput_cvv.Size = new Size(350, 47);
            imput_cvv.TabIndex = 18;
            imput_cvv.TipoIcono = TipoIconoCampo.Tarjeta;
            imput_cvv.TextChanged += imput_cvv_TextChanged;
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
            imput_nombre.Location = new Point(12, 361);
            imput_nombre.Name = "imput_nombre";
            imput_nombre.PlaceholderText = "Tu nombre completo";
            imput_nombre.Size = new Size(350, 47);
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
            imput_correo.Location = new Point(387, 453);
            imput_correo.Name = "imput_correo";
            imput_correo.PlaceholderText = "correo@ejemplo.com";
            imput_correo.Size = new Size(350, 47);
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
            imput_telefono.Location = new Point(18, 453);
            imput_telefono.Name = "imput_telefono";
            imput_telefono.PlaceholderText = "+505 8*** ****";
            imput_telefono.Size = new Size(350, 47);
            imput_telefono.TabIndex = 20;
            imput_telefono.TipoIcono = TipoIconoCampo.Telefono;
            imput_telefono.TextChanged += imput_telefono_TextChanged;
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
            imput_direccion.Location = new Point(387, 542);
            imput_direccion.Name = "imput_direccion";
            imput_direccion.PlaceholderText = "Dirección, ciudad, departamento";
            imput_direccion.Size = new Size(350, 47);
            imput_direccion.TabIndex = 21;
            imput_direccion.TipoIcono = TipoIconoCampo.Ubicacion;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(285, 17);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 22;
            label4.Text = "Datos de tarjeta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(11, 148);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
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
            label2.Location = new Point(387, 240);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
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
            label3.Location = new Point(11, 240);
            label3.Name = "label3";
            label3.Size = new Size(231, 23);
            label3.TabIndex = 25;
            label3.Text = "Código de Seguridad (CVV)";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(11, 332);
            label5.Name = "label5";
            label5.Size = new Size(157, 23);
            label5.TabIndex = 26;
            label5.Text = "Nombre completo";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(387, 427);
            label6.Name = "label6";
            label6.Size = new Size(157, 23);
            label6.TabIndex = 27;
            label6.Text = "Correo electronico";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(18, 427);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 28;
            label7.Text = "Teléfono";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(387, 516);
            label8.Name = "label8";
            label8.Size = new Size(205, 23);
            label8.TabIndex = 29;
            label8.Text = "Dirección de facturación";
            label8.Click += label8_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(campoTexto1);
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
            panel1.Location = new Point(322, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 730);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint;
            // 
            // campoTexto1
            // 
            campoTexto1.BackColor = Color.Transparent;
            campoTexto1.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto1.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto1.BorderRadius = 12;
            campoTexto1.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            campoTexto1.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto1.EsPassword = false;
            campoTexto1.IconoPersonalizado = null;
            campoTexto1.Location = new Point(18, 542);
            campoTexto1.Name = "campoTexto1";
            campoTexto1.PlaceholderText = "Saldo a recargar C$";
            campoTexto1.Size = new Size(275, 47);
            campoTexto1.TabIndex = 32;
            campoTexto1.TipoIcono = TipoIconoCampo.Tarjeta;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(11, 59);
            label11.Name = "label11";
            label11.Size = new Size(158, 23);
            label11.TabIndex = 31;
            label11.Text = "Numero de tarjeta";
            label11.Click += label11_Click;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.Blue;
            botonRedondeado1.BorderRadius = 20;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(513, 639);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(200, 51);
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
            btn_volver.Location = new Point(1290, 16);
            btn_volver.MargenImagenIzquierda = 15;
            btn_volver.Name = "btn_volver";
            btn_volver.PorcentajeEscalaImagen = 50;
            btn_volver.Size = new Size(155, 41);
            btn_volver.TabIndex = 31;
            btn_volver.Text = "←      Volver";
            btn_volver.TextAlign = ContentAlignment.MiddleLeft;
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += botonMenu1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(36, 48);
            label12.Name = "label12";
            label12.Size = new Size(149, 41);
            label12.TabIndex = 32;
            label12.Text = "Saldo C$:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(179, 48);
            label13.Name = "label13";
            label13.Size = new Size(82, 41);
            label13.TabIndex = 33;
            label13.Text = "0000";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(25, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 125);
            panel2.TabIndex = 34;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_07_at_12_37_13_PM;
            ClientSize = new Size(1445, 908);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btn_volver);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private CampoTexto campoTexto1;
        private Label label12;
        private Label label13;
        private Panel panel2;
    }
}