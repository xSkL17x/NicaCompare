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
            label9 = new Label();
            label10 = new Label();
            campoTexto1 = new CampoTexto();
            campoTexto2 = new CampoTexto();
            campoTexto3 = new CampoTexto();
            campoTexto4 = new CampoTexto();
            campoTexto5 = new CampoTexto();
            campoTexto6 = new CampoTexto();
            campoTexto7 = new CampoTexto();
            campoTexto8 = new CampoTexto();
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
            botonMenu1 = new BotonMenu();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
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
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(394, 71);
            label10.Name = "label10";
            label10.Size = new Size(418, 19);
            label10.TabIndex = 14;
            label10.Text = "Ingresa los datos de tu metodo de pago para completar tu compra";
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
            campoTexto1.Location = new Point(16, 57);
            campoTexto1.Margin = new Padding(3, 2, 3, 2);
            campoTexto1.Name = "campoTexto1";
            campoTexto1.PlaceholderText = "1234 5678 9101 1121";
            campoTexto1.Size = new Size(634, 35);
            campoTexto1.TabIndex = 15;
            campoTexto1.TipoIcono = TipoIconoCampo.Tarjeta;
            campoTexto1.TextChanged += campoTexto1_TextChanged;
            // 
            // campoTexto2
            // 
            campoTexto2.BackColor = Color.Transparent;
            campoTexto2.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto2.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto2.BorderRadius = 12;
            campoTexto2.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            campoTexto2.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto2.EsPassword = false;
            campoTexto2.IconoPersonalizado = null;
            campoTexto2.Location = new Point(10, 133);
            campoTexto2.Margin = new Padding(3, 2, 3, 2);
            campoTexto2.Name = "campoTexto2";
            campoTexto2.PlaceholderText = "Como aparece en la tarjeta";
            campoTexto2.Size = new Size(306, 35);
            campoTexto2.TabIndex = 16;
            campoTexto2.TipoIcono = TipoIconoCampo.Usuario;
            campoTexto2.TextChanged += campoTexto2_TextChanged;
            // 
            // campoTexto3
            // 
            campoTexto3.BackColor = Color.Transparent;
            campoTexto3.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto3.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto3.BorderRadius = 12;
            campoTexto3.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            campoTexto3.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto3.EsPassword = false;
            campoTexto3.IconoPersonalizado = null;
            campoTexto3.Location = new Point(338, 133);
            campoTexto3.Margin = new Padding(3, 2, 3, 2);
            campoTexto3.Name = "campoTexto3";
            campoTexto3.PlaceholderText = "MM / AA";
            campoTexto3.Size = new Size(306, 35);
            campoTexto3.TabIndex = 17;
            campoTexto3.TipoIcono = TipoIconoCampo.Calendario;
            // 
            // campoTexto4
            // 
            campoTexto4.BackColor = Color.Transparent;
            campoTexto4.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto4.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto4.BorderRadius = 12;
            campoTexto4.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            campoTexto4.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto4.EsPassword = false;
            campoTexto4.IconoPersonalizado = null;
            campoTexto4.Location = new Point(10, 196);
            campoTexto4.Margin = new Padding(3, 2, 3, 2);
            campoTexto4.Name = "campoTexto4";
            campoTexto4.PlaceholderText = "123";
            campoTexto4.Size = new Size(306, 35);
            campoTexto4.TabIndex = 18;
            campoTexto4.TipoIcono = TipoIconoCampo.Tarjeta;
            // 
            // campoTexto5
            // 
            campoTexto5.BackColor = Color.Transparent;
            campoTexto5.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto5.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto5.BorderRadius = 12;
            campoTexto5.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            campoTexto5.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto5.EsPassword = false;
            campoTexto5.IconoPersonalizado = null;
            campoTexto5.Location = new Point(16, 299);
            campoTexto5.Margin = new Padding(3, 2, 3, 2);
            campoTexto5.Name = "campoTexto5";
            campoTexto5.PlaceholderText = "Tu nombre completo";
            campoTexto5.Size = new Size(306, 35);
            campoTexto5.TabIndex = 19;
            campoTexto5.TipoIcono = TipoIconoCampo.Usuario;
            campoTexto5.TextChanged += campoTexto5_TextChanged;
            // 
            // campoTexto6
            // 
            campoTexto6.BackColor = Color.Transparent;
            campoTexto6.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto6.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto6.BorderRadius = 12;
            campoTexto6.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            campoTexto6.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto6.EsPassword = false;
            campoTexto6.IconoPersonalizado = null;
            campoTexto6.Location = new Point(338, 299);
            campoTexto6.Margin = new Padding(3, 2, 3, 2);
            campoTexto6.Name = "campoTexto6";
            campoTexto6.PlaceholderText = "correo@ejemplo.com";
            campoTexto6.Size = new Size(306, 35);
            campoTexto6.TabIndex = 19;
            campoTexto6.TipoIcono = TipoIconoCampo.Correo;
            campoTexto6.TextChanged += campoTexto6_TextChanged;
            // 
            // campoTexto7
            // 
            campoTexto7.BackColor = Color.Transparent;
            campoTexto7.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto7.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto7.BorderRadius = 12;
            campoTexto7.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            campoTexto7.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto7.EsPassword = false;
            campoTexto7.IconoPersonalizado = null;
            campoTexto7.Location = new Point(10, 366);
            campoTexto7.Margin = new Padding(3, 2, 3, 2);
            campoTexto7.Name = "campoTexto7";
            campoTexto7.PlaceholderText = "+505 8*** ****";
            campoTexto7.Size = new Size(306, 35);
            campoTexto7.TabIndex = 20;
            campoTexto7.TipoIcono = TipoIconoCampo.Telefono;
            // 
            // campoTexto8
            // 
            campoTexto8.BackColor = Color.Transparent;
            campoTexto8.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto8.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto8.BorderRadius = 12;
            campoTexto8.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            campoTexto8.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto8.EsPassword = false;
            campoTexto8.IconoPersonalizado = null;
            campoTexto8.Location = new Point(338, 366);
            campoTexto8.Margin = new Padding(3, 2, 3, 2);
            campoTexto8.Name = "campoTexto8";
            campoTexto8.PlaceholderText = "Dirección, ciudad, departamento";
            campoTexto8.Size = new Size(306, 35);
            campoTexto8.TabIndex = 21;
            campoTexto8.TipoIcono = TipoIconoCampo.Ubicacion;
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
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(botonRedondeado1);
            panel1.Controls.Add(campoTexto1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(campoTexto2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(campoTexto4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(campoTexto5);
            panel1.Controls.Add(campoTexto3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(campoTexto7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(campoTexto6);
            panel1.Controls.Add(campoTexto8);
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
            // botonMenu1
            // 
            botonMenu1.AutoColorearIconoBlanco = true;
            botonMenu1.AutoEscalarImagen = true;
            botonMenu1.BackColor = Color.Transparent;
            botonMenu1.BorderRadius = 18;
            botonMenu1.ColorHover = Color.FromArgb(13, 110, 253);
            botonMenu1.ColorTextoNormal = Color.FromArgb(0, 0, 192);
            botonMenu1.EsSeleccionado = false;
            botonMenu1.FlatAppearance.BorderSize = 0;
            botonMenu1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonMenu1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonMenu1.FlatStyle = FlatStyle.Flat;
            botonMenu1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            botonMenu1.ForeColor = Color.FromArgb(0, 0, 192);
            botonMenu1.Location = new Point(1129, 12);
            botonMenu1.MargenImagenIzquierda = 15;
            botonMenu1.Margin = new Padding(3, 2, 3, 2);
            botonMenu1.Name = "botonMenu1";
            botonMenu1.PorcentajeEscalaImagen = 50;
            botonMenu1.Size = new Size(136, 31);
            botonMenu1.TabIndex = 31;
            botonMenu1.Text = "←      Volver";
            botonMenu1.TextAlign = ContentAlignment.MiddleLeft;
            botonMenu1.UseVisualStyleBackColor = true;
            botonMenu1.Click += botonMenu1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1264, 681);
            Controls.Add(botonMenu1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form7";
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
        private CampoTexto campoTexto1;
        private CampoTexto campoTexto2;
        private CampoTexto campoTexto3;
        private CampoTexto campoTexto4;
        private CampoTexto campoTexto5;
        private CampoTexto campoTexto6;
        private CampoTexto campoTexto7;
        private CampoTexto campoTexto8;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private BotonMenu botonMenu1;
        private BotonRedondeado botonRedondeado1;
        private Label label11;
    }
}