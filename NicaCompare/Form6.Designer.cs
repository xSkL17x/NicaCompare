namespace NicaCompare
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            panel2 = new Panel();
            label_fecha = new Label();
            avatar1 = new PictureBox();
            label_nombre = new Label();
            label_correo = new Label();
            imput_nombre = new CampoTexto();
            imput_telefono = new CampoTexto();
            imput_fecha = new CampoTexto();
            imput_correo = new CampoTexto();
            label4 = new Label();
            label5 = new Label();
            label_tipo_cuenta = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            btn_recargar = new BotonRedondeado();
            label_saldo = new Label();
            panel4 = new Panel();
            avatar2 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            botonRedondeado2 = new BotonRedondeado();
            botonRedondeado1 = new BotonRedondeado();
            panel5 = new Panel();
            botonRedondeado3 = new BotonRedondeado();
            botonRedondeado4 = new BotonRedondeado();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = Properties.Resources.fondo_perfil;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label_fecha);
            panel1.Controls.Add(avatar1);
            panel1.Controls.Add(label_nombre);
            panel1.Controls.Add(label_correo);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 139);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 134);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 434);
            panel2.TabIndex = 2;
            // 
            // label_fecha
            // 
            label_fecha.AutoSize = true;
            label_fecha.BackColor = Color.Transparent;
            label_fecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fecha.ForeColor = Color.Navy;
            label_fecha.Location = new Point(171, 81);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(140, 19);
            label_fecha.TabIndex = 3;
            label_fecha.Text = "Usuario desde 2026";
            // 
            // avatar1
            // 
            avatar1.Anchor = AnchorStyles.None;
            avatar1.BackColor = Color.Transparent;
            avatar1.Image = Properties.Resources.no_hay_usuario;
            avatar1.Location = new Point(12, 10);
            avatar1.Margin = new Padding(3, 2, 3, 2);
            avatar1.Name = "avatar1";
            avatar1.Size = new Size(134, 109);
            avatar1.SizeMode = PictureBoxSizeMode.Zoom;
            avatar1.TabIndex = 2;
            avatar1.TabStop = false;
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.BackColor = Color.Transparent;
            label_nombre.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nombre.ForeColor = Color.Navy;
            label_nombre.Location = new Point(170, 22);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(124, 25);
            label_nombre.TabIndex = 1;
            label_nombre.Text = "OTONIEL JR";
            label_nombre.Click += label2_Click;
            // 
            // label_correo
            // 
            label_correo.AutoSize = true;
            label_correo.BackColor = Color.Transparent;
            label_correo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_correo.Location = new Point(170, 52);
            label_correo.Name = "label_correo";
            label_correo.Size = new Size(135, 19);
            label_correo.TabIndex = 2;
            label_correo.Text = "JomuUb@gmail.com";
            label_correo.Click += label3_Click;
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
            imput_nombre.Location = new Point(31, 245);
            imput_nombre.Margin = new Padding(3, 2, 3, 2);
            imput_nombre.Name = "imput_nombre";
            imput_nombre.PlaceholderText = "Tu nombre completo";
            imput_nombre.Size = new Size(350, 45);
            imput_nombre.TabIndex = 2;
            imput_nombre.TipoIcono = TipoIconoCampo.Usuario;
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
            imput_telefono.Location = new Point(31, 363);
            imput_telefono.Margin = new Padding(3, 2, 3, 2);
            imput_telefono.Name = "imput_telefono";
            imput_telefono.PlaceholderText = "+505 8*** ****";
            imput_telefono.Size = new Size(350, 45);
            imput_telefono.TabIndex = 3;
            imput_telefono.TipoIcono = TipoIconoCampo.Telefono;
            // 
            // imput_fecha
            // 
            imput_fecha.BackColor = Color.Transparent;
            imput_fecha.BorderColor = Color.FromArgb(228, 231, 236);
            imput_fecha.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_fecha.BorderRadius = 12;
            imput_fecha.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_fecha.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_fecha.Enabled = false;
            imput_fecha.EsPassword = false;
            imput_fecha.IconoPersonalizado = null;
            imput_fecha.ImeMode = ImeMode.NoControl;
            imput_fecha.Location = new Point(453, 219);
            imput_fecha.Margin = new Padding(3, 2, 3, 2);
            imput_fecha.Name = "imput_fecha";
            imput_fecha.PlaceholderText = "DD / MM / AAAA";
            imput_fecha.Size = new Size(350, 45);
            imput_fecha.TabIndex = 6;
            imput_fecha.TipoIcono = TipoIconoCampo.Calendario;
            imput_fecha.TextChanged += campoTexto4_TextChanged;
            // 
            // imput_correo
            // 
            imput_correo.BackColor = Color.Transparent;
            imput_correo.BorderColor = Color.FromArgb(228, 231, 236);
            imput_correo.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_correo.BorderRadius = 12;
            imput_correo.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_correo.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_correo.Enabled = false;
            imput_correo.EsPassword = false;
            imput_correo.IconoPersonalizado = null;
            imput_correo.ImeMode = ImeMode.NoControl;
            imput_correo.Location = new Point(453, 101);
            imput_correo.Margin = new Padding(3, 2, 3, 2);
            imput_correo.Name = "imput_correo";
            imput_correo.PlaceholderText = "correo@ejemplo.com";
            imput_correo.Size = new Size(350, 45);
            imput_correo.TabIndex = 5;
            imput_correo.TipoIcono = TipoIconoCampo.Correo;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(34, 225);
            label4.Name = "label4";
            label4.Size = new Size(135, 19);
            label4.TabIndex = 7;
            label4.Text = "Nombre Completo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(34, 338);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // label_tipo_cuenta
            // 
            label_tipo_cuenta.AutoSize = true;
            label_tipo_cuenta.BackColor = Color.Transparent;
            label_tipo_cuenta.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_tipo_cuenta.ForeColor = Color.Navy;
            label_tipo_cuenta.Location = new Point(61, 282);
            label_tipo_cuenta.Name = "label_tipo_cuenta";
            label_tipo_cuenta.Size = new Size(240, 37);
            label_tipo_cuenta.TabIndex = 9;
            label_tipo_cuenta.Text = "Cuenta Premium";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(455, 82);
            label7.Name = "label7";
            label7.Size = new Size(134, 19);
            label7.TabIndex = 10;
            label7.Text = "Correo Electrónico";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(453, 199);
            label8.Name = "label8";
            label8.Size = new Size(125, 19);
            label8.TabIndex = 11;
            label8.Text = "Fecha de registro";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(34, 151);
            label9.Name = "label9";
            label9.Size = new Size(203, 25);
            label9.TabIndex = 12;
            label9.Text = "Información Personal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(34, 174);
            label10.Name = "label10";
            label10.Size = new Size(432, 19);
            label10.TabIndex = 4;
            label10.Text = "Actualiza tus datos para tener una mejor experiencia en nica compare";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.Controls.Add(btn_recargar);
            panel3.Controls.Add(label_saldo);
            panel3.Controls.Add(label_tipo_cuenta);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(imput_correo);
            panel3.Controls.Add(imput_fecha);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(panel5);
            panel3.ImeMode = ImeMode.Close;
            panel3.Location = new Point(10, 144);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1242, 446);
            panel3.TabIndex = 13;
            // 
            // btn_recargar
            // 
            btn_recargar.BackColor = Color.FromArgb(255, 255, 128);
            btn_recargar.BorderRadius = 20;
            btn_recargar.Cursor = Cursors.Hand;
            btn_recargar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btn_recargar.FlatAppearance.BorderSize = 2;
            btn_recargar.FlatStyle = FlatStyle.Flat;
            btn_recargar.Font = new Font("Segoe Fluent Icons", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_recargar.ForeColor = Color.Black;
            btn_recargar.Location = new Point(492, 340);
            btn_recargar.Margin = new Padding(3, 2, 3, 2);
            btn_recargar.Name = "btn_recargar";
            btn_recargar.Size = new Size(195, 38);
            btn_recargar.TabIndex = 6;
            btn_recargar.Text = "Recargar";
            btn_recargar.UseVisualStyleBackColor = false;
            btn_recargar.Click += btn_recargar_Click;
            // 
            // label_saldo
            // 
            label_saldo.AutoSize = true;
            label_saldo.BackColor = Color.Transparent;
            label_saldo.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_saldo.ForeColor = Color.Navy;
            label_saldo.Location = new Point(475, 282);
            label_saldo.Name = "label_saldo";
            label_saldo.Size = new Size(240, 37);
            label_saldo.TabIndex = 17;
            label_saldo.Text = "Cuenta Premium";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(avatar2);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(botonRedondeado2);
            panel4.Controls.Add(botonRedondeado1);
            panel4.Location = new Point(847, 7);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(388, 312);
            panel4.TabIndex = 14;
            // 
            // avatar2
            // 
            avatar2.Anchor = AnchorStyles.None;
            avatar2.BackColor = Color.Transparent;
            avatar2.Image = Properties.Resources.no_hay_usuario;
            avatar2.Location = new Point(86, 74);
            avatar2.Margin = new Padding(3, 2, 3, 2);
            avatar2.Name = "avatar2";
            avatar2.Size = new Size(198, 150);
            avatar2.SizeMode = PictureBoxSizeMode.Zoom;
            avatar2.TabIndex = 4;
            avatar2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 38);
            label12.Name = "label12";
            label12.Size = new Size(204, 19);
            label12.TabIndex = 4;
            label12.Text = "Puedes cambiar tu foto de perfil";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(16, 17);
            label11.Name = "label11";
            label11.Size = new Size(116, 21);
            label11.TabIndex = 4;
            label11.Text = "Foto de perfil";
            // 
            // botonRedondeado2
            // 
            botonRedondeado2.BackColor = Color.FromArgb(255, 128, 0);
            botonRedondeado2.BorderRadius = 20;
            botonRedondeado2.FlatAppearance.BorderSize = 0;
            botonRedondeado2.FlatStyle = FlatStyle.Flat;
            botonRedondeado2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado2.ForeColor = Color.White;
            botonRedondeado2.ImageAlign = ContentAlignment.TopLeft;
            botonRedondeado2.Location = new Point(202, 237);
            botonRedondeado2.Margin = new Padding(3, 2, 3, 2);
            botonRedondeado2.Name = "botonRedondeado2";
            botonRedondeado2.Size = new Size(171, 38);
            botonRedondeado2.TabIndex = 2;
            botonRedondeado2.Text = "Eliminar foto";
            botonRedondeado2.UseVisualStyleBackColor = false;
            botonRedondeado2.Click += botonRedondeado2_Click;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.FromArgb(0, 0, 192);
            botonRedondeado1.BorderRadius = 20;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(16, 237);
            botonRedondeado1.Margin = new Padding(3, 2, 3, 2);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(174, 38);
            botonRedondeado1.TabIndex = 1;
            botonRedondeado1.Text = "Subir foto";
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(botonRedondeado3);
            panel5.Controls.Add(botonRedondeado4);
            panel5.Location = new Point(847, 340);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(388, 85);
            panel5.TabIndex = 16;
            // 
            // botonRedondeado3
            // 
            botonRedondeado3.BackColor = Color.FromArgb(255, 128, 0);
            botonRedondeado3.BorderRadius = 20;
            botonRedondeado3.FlatAppearance.BorderSize = 0;
            botonRedondeado3.FlatStyle = FlatStyle.Flat;
            botonRedondeado3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado3.ForeColor = Color.White;
            botonRedondeado3.ImageAlign = ContentAlignment.TopLeft;
            botonRedondeado3.Location = new Point(229, 21);
            botonRedondeado3.Margin = new Padding(3, 2, 3, 2);
            botonRedondeado3.Name = "botonRedondeado3";
            botonRedondeado3.Size = new Size(144, 38);
            botonRedondeado3.TabIndex = 5;
            botonRedondeado3.Text = "canselar";
            botonRedondeado3.UseVisualStyleBackColor = false;
            botonRedondeado3.Click += botonRedondeado3_Click;
            // 
            // botonRedondeado4
            // 
            botonRedondeado4.BackColor = Color.FromArgb(0, 0, 192);
            botonRedondeado4.BorderRadius = 20;
            botonRedondeado4.FlatAppearance.BorderSize = 0;
            botonRedondeado4.FlatStyle = FlatStyle.Flat;
            botonRedondeado4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado4.ForeColor = Color.White;
            botonRedondeado4.Location = new Point(16, 21);
            botonRedondeado4.Margin = new Padding(3, 2, 3, 2);
            botonRedondeado4.Name = "botonRedondeado4";
            botonRedondeado4.Size = new Size(195, 38);
            botonRedondeado4.TabIndex = 5;
            botonRedondeado4.Text = "Guardar cambios";
            botonRedondeado4.UseVisualStyleBackColor = false;
            botonRedondeado4.Click += botonRedondeado4_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_07_at_12_37_13_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(imput_telefono);
            Controls.Add(imput_nombre);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mi Perfil 👤";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar2).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_correo;
        private Label label_nombre;
        private PictureBox avatar1;
        private Label label_fecha;
        private Panel panel2;
        private CampoTexto imput_nombre;
        private CampoTexto imput_telefono;
        private CampoTexto campoTexto3;
        private CampoTexto imput_fecha;
        private CampoTexto imput_correo;
        private Label label4;
        private Label label5;
        private Label label_tipo_cuenta;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel3;
        private Panel panel4;
        private BotonRedondeado botonRedondeado2;
        private BotonRedondeado botonRedondeado1;
        private Label label12;
        private Label label11;
        private BotonRedondeado botonRedondeado3;
        private BotonRedondeado botonRedondeado4;
        private Panel panel5;
        private PictureBox avatar2;
        private Label label_saldo;
        private BotonRedondeado btn_recargar;
    }
}