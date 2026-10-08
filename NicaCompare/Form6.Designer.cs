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
            panel10 = new Panel();
            btn_volver = new BotonMenu();
            panel7 = new Panel();
            label_correo = new Label();
            label_nombre = new Label();
            avatar1 = new PictureBox();
            label_fecha = new Label();
            panel2 = new Panel();
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
            panel9 = new Panel();
            panel4 = new Panel();
            avatar2 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            botonRedondeado2 = new BotonRedondeado();
            botonRedondeado1 = new BotonRedondeado();
            panel6 = new Panel();
            btn_recargar = new BotonRedondeado();
            label_saldo = new Label();
            btn_elegir_plan = new BotonRedondeado();
            panel8 = new Panel();
            imput_nuevacontra = new CampoPassword();
            panel5 = new Panel();
            btn_cancelar = new BotonRedondeado();
            btn_guardar_cambios = new BotonRedondeado();
            label3 = new Label();
            imput_contra_actual = new CampoPassword();
            label2 = new Label();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar1).BeginInit();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar2).BeginInit();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fondo_perfil;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 126);
            panel1.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(btn_volver);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(1064, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 126);
            panel10.TabIndex = 35;
            // 
            // btn_volver
            // 
            btn_volver.AutoColorearIconoBlanco = true;
            btn_volver.AutoEscalarImagen = true;
            btn_volver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            btn_volver.Location = new Point(52, 43);
            btn_volver.MargenImagenIzquierda = 15;
            btn_volver.Margin = new Padding(3, 2, 3, 2);
            btn_volver.Name = "btn_volver";
            btn_volver.PorcentajeEscalaImagen = 50;
            btn_volver.Size = new Size(136, 31);
            btn_volver.TabIndex = 33;
            btn_volver.Text = "←      Volver";
            btn_volver.TextAlign = ContentAlignment.MiddleLeft;
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(label_correo);
            panel7.Controls.Add(label_nombre);
            panel7.Controls.Add(avatar1);
            panel7.Controls.Add(label_fecha);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(406, 126);
            panel7.TabIndex = 34;
            // 
            // label_correo
            // 
            label_correo.BackColor = Color.Transparent;
            label_correo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_correo.Location = new Point(164, 55);
            label_correo.Name = "label_correo";
            label_correo.Size = new Size(135, 19);
            label_correo.TabIndex = 2;
            label_correo.Text = "JomuUb@gmail.com";
            label_correo.Click += label3_Click;
            // 
            // label_nombre
            // 
            label_nombre.BackColor = Color.Transparent;
            label_nombre.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nombre.ForeColor = Color.Navy;
            label_nombre.Location = new Point(164, 25);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(124, 25);
            label_nombre.TabIndex = 1;
            label_nombre.Text = "OTONIEL JR";
            label_nombre.Click += label2_Click;
            // 
            // avatar1
            // 
            avatar1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            avatar1.BackColor = Color.Transparent;
            avatar1.Image = Properties.Resources.no_hay_usuario;
            avatar1.Location = new Point(8, 10);
            avatar1.Margin = new Padding(3, 2, 3, 2);
            avatar1.Name = "avatar1";
            avatar1.Size = new Size(134, 109);
            avatar1.SizeMode = PictureBoxSizeMode.Zoom;
            avatar1.TabIndex = 2;
            avatar1.TabStop = false;
            // 
            // label_fecha
            // 
            label_fecha.BackColor = Color.Transparent;
            label_fecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fecha.ForeColor = Color.Navy;
            label_fecha.Location = new Point(165, 84);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(140, 19);
            label_fecha.TabIndex = 3;
            label_fecha.Text = "Usuario desde 2026";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 134);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 434);
            panel2.TabIndex = 2;
            // 
            // imput_nombre
            // 
            imput_nombre.Anchor = AnchorStyles.None;
            imput_nombre.BackColor = Color.Transparent;
            imput_nombre.BorderColor = Color.FromArgb(228, 231, 236);
            imput_nombre.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_nombre.BorderRadius = 12;
            imput_nombre.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_nombre.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_nombre.EsPassword = false;
            imput_nombre.IconoPersonalizado = null;
            imput_nombre.Location = new Point(21, 140);
            imput_nombre.Margin = new Padding(3, 2, 3, 2);
            imput_nombre.Name = "imput_nombre";
            imput_nombre.PlaceholderText = "Tu nombre completo";
            imput_nombre.Size = new Size(350, 45);
            imput_nombre.TabIndex = 2;
            imput_nombre.TipoIcono = TipoIconoCampo.Usuario;
            // 
            // imput_telefono
            // 
            imput_telefono.Anchor = AnchorStyles.None;
            imput_telefono.BackColor = Color.Transparent;
            imput_telefono.BorderColor = Color.FromArgb(228, 231, 236);
            imput_telefono.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_telefono.BorderRadius = 12;
            imput_telefono.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            imput_telefono.ColorIcono = Color.FromArgb(130, 138, 150);
            imput_telefono.EsPassword = false;
            imput_telefono.IconoPersonalizado = null;
            imput_telefono.Location = new Point(21, 244);
            imput_telefono.Margin = new Padding(3, 2, 3, 2);
            imput_telefono.Name = "imput_telefono";
            imput_telefono.PlaceholderText = "+505 8*** ****";
            imput_telefono.Size = new Size(350, 45);
            imput_telefono.TabIndex = 3;
            imput_telefono.TipoIcono = TipoIconoCampo.Telefono;
            imput_telefono.TextChanged += imput_telefono_TextChanged;
            // 
            // imput_fecha
            // 
            imput_fecha.Anchor = AnchorStyles.None;
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
            imput_fecha.Location = new Point(452, 133);
            imput_fecha.Margin = new Padding(3, 2, 3, 2);
            imput_fecha.Name = "imput_fecha";
            imput_fecha.PlaceholderText = "DD / MM / AAAA";
            imput_fecha.Size = new Size(288, 45);
            imput_fecha.TabIndex = 6;
            imput_fecha.TipoIcono = TipoIconoCampo.Calendario;
            imput_fecha.TextChanged += campoTexto4_TextChanged;
            // 
            // imput_correo
            // 
            imput_correo.Anchor = AnchorStyles.None;
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
            imput_correo.Location = new Point(20, 345);
            imput_correo.Margin = new Padding(3, 2, 3, 2);
            imput_correo.Name = "imput_correo";
            imput_correo.PlaceholderText = "correo@ejemplo.com";
            imput_correo.Size = new Size(350, 45);
            imput_correo.TabIndex = 5;
            imput_correo.TipoIcono = TipoIconoCampo.Correo;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(32, 100);
            label4.Name = "label4";
            label4.Size = new Size(135, 19);
            label4.TabIndex = 7;
            label4.Text = "Nombre Completo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(32, 213);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // label_tipo_cuenta
            // 
            label_tipo_cuenta.Anchor = AnchorStyles.None;
            label_tipo_cuenta.BackColor = Color.Transparent;
            label_tipo_cuenta.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_tipo_cuenta.ForeColor = Color.Navy;
            label_tipo_cuenta.Location = new Point(25, 44);
            label_tipo_cuenta.Name = "label_tipo_cuenta";
            label_tipo_cuenta.Size = new Size(188, 31);
            label_tipo_cuenta.TabIndex = 9;
            label_tipo_cuenta.Text = "Cuenta NONE";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(32, 310);
            label7.Name = "label7";
            label7.Size = new Size(134, 19);
            label7.TabIndex = 10;
            label7.Text = "Correo Electrónico";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(452, 93);
            label8.Name = "label8";
            label8.Size = new Size(125, 19);
            label8.TabIndex = 11;
            label8.Text = "Fecha de registro";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(21, 19);
            label9.Name = "label9";
            label9.Size = new Size(203, 25);
            label9.TabIndex = 12;
            label9.Text = "Información Personal";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 42);
            label10.Name = "label10";
            label10.Size = new Size(432, 19);
            label10.TabIndex = 4;
            label10.Text = "Actualiza tus datos para tener una mejor experiencia en nica compare";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Dock = DockStyle.Fill;
            panel3.ImeMode = ImeMode.Close;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1264, 681);
            panel3.TabIndex = 13;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(panel6);
            panel9.Location = new Point(780, 139);
            panel9.Name = "panel9";
            panel9.Size = new Size(478, 530);
            panel9.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(avatar2);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(botonRedondeado2);
            panel4.Controls.Add(botonRedondeado1);
            panel4.Location = new Point(33, 15);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(420, 293);
            panel4.TabIndex = 14;
            panel4.Visible = false;
            // 
            // avatar2
            // 
            avatar2.Anchor = AnchorStyles.None;
            avatar2.BackColor = Color.Transparent;
            avatar2.Image = Properties.Resources.no_hay_usuario;
            avatar2.Location = new Point(102, 64);
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
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(btn_recargar);
            panel6.Controls.Add(label_saldo);
            panel6.Controls.Add(label_tipo_cuenta);
            panel6.Controls.Add(btn_elegir_plan);
            panel6.Location = new Point(8, 313);
            panel6.Name = "panel6";
            panel6.Size = new Size(467, 214);
            panel6.TabIndex = 25;
            // 
            // btn_recargar
            // 
            btn_recargar.Anchor = AnchorStyles.None;
            btn_recargar.BackColor = Color.FromArgb(255, 128, 0);
            btn_recargar.BorderRadius = 20;
            btn_recargar.FlatAppearance.BorderSize = 0;
            btn_recargar.FlatStyle = FlatStyle.Flat;
            btn_recargar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_recargar.ForeColor = Color.White;
            btn_recargar.ImageAlign = ContentAlignment.TopLeft;
            btn_recargar.Location = new Point(268, 122);
            btn_recargar.Margin = new Padding(3, 2, 3, 2);
            btn_recargar.Name = "btn_recargar";
            btn_recargar.Size = new Size(194, 38);
            btn_recargar.TabIndex = 18;
            btn_recargar.Text = "recargar saldo";
            btn_recargar.UseVisualStyleBackColor = false;
            btn_recargar.Click += botonRecargar_Click;
            // 
            // label_saldo
            // 
            label_saldo.Anchor = AnchorStyles.None;
            label_saldo.BackColor = Color.Transparent;
            label_saldo.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_saldo.ForeColor = Color.Navy;
            label_saldo.Location = new Point(292, 44);
            label_saldo.Name = "label_saldo";
            label_saldo.Size = new Size(147, 31);
            label_saldo.TabIndex = 17;
            label_saldo.Text = "Saldo C$ 0";
            label_saldo.Click += label_saldo_Click;
            // 
            // btn_elegir_plan
            // 
            btn_elegir_plan.Anchor = AnchorStyles.None;
            btn_elegir_plan.BackColor = Color.FromArgb(0, 0, 192);
            btn_elegir_plan.BorderRadius = 20;
            btn_elegir_plan.FlatAppearance.BorderSize = 0;
            btn_elegir_plan.FlatStyle = FlatStyle.Flat;
            btn_elegir_plan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_elegir_plan.ForeColor = Color.White;
            btn_elegir_plan.ImageAlign = ContentAlignment.TopLeft;
            btn_elegir_plan.Location = new Point(13, 122);
            btn_elegir_plan.Margin = new Padding(3, 2, 3, 2);
            btn_elegir_plan.Name = "btn_elegir_plan";
            btn_elegir_plan.Size = new Size(223, 38);
            btn_elegir_plan.TabIndex = 19;
            btn_elegir_plan.Text = "Elegir Plan";
            btn_elegir_plan.UseVisualStyleBackColor = false;
            btn_elegir_plan.Click += btn_ir_planes_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(imput_nuevacontra);
            panel8.Controls.Add(panel5);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(imput_contra_actual);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(imput_nombre);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(imput_correo);
            panel8.Controls.Add(imput_telefono);
            panel8.Controls.Add(imput_fecha);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(12, 139);
            panel8.Name = "panel8";
            panel8.Size = new Size(762, 530);
            panel8.TabIndex = 14;
            // 
            // imput_nuevacontra
            // 
            imput_nuevacontra.Anchor = AnchorStyles.None;
            imput_nuevacontra.BackColor = Color.Transparent;
            imput_nuevacontra.BorderColor = Color.FromArgb(228, 231, 236);
            imput_nuevacontra.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_nuevacontra.BorderRadius = 12;
            imput_nuevacontra.Location = new Point(453, 342);
            imput_nuevacontra.Margin = new Padding(3, 2, 3, 2);
            imput_nuevacontra.Name = "imput_nuevacontra";
            imput_nuevacontra.Padding = new Padding(9, 8, 9, 8);
            imput_nuevacontra.PlaceholderText = "Confirma tu contraseña";
            imput_nuevacontra.Size = new Size(288, 34);
            imput_nuevacontra.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(btn_cancelar);
            panel5.Controls.Add(btn_guardar_cambios);
            panel5.Location = new Point(214, 413);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(388, 85);
            panel5.TabIndex = 16;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 0);
            btn_cancelar.BorderRadius = 20;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.ImageAlign = ContentAlignment.TopLeft;
            btn_cancelar.Location = new Point(229, 21);
            btn_cancelar.Margin = new Padding(3, 2, 3, 2);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(144, 38);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "canselar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_cambios_Click;
            // 
            // btn_guardar_cambios
            // 
            btn_guardar_cambios.BackColor = Color.FromArgb(0, 0, 192);
            btn_guardar_cambios.BorderRadius = 20;
            btn_guardar_cambios.FlatAppearance.BorderSize = 0;
            btn_guardar_cambios.FlatStyle = FlatStyle.Flat;
            btn_guardar_cambios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_guardar_cambios.ForeColor = Color.White;
            btn_guardar_cambios.Location = new Point(16, 21);
            btn_guardar_cambios.Margin = new Padding(3, 2, 3, 2);
            btn_guardar_cambios.Name = "btn_guardar_cambios";
            btn_guardar_cambios.Size = new Size(195, 38);
            btn_guardar_cambios.TabIndex = 5;
            btn_guardar_cambios.Text = "Guardar cambios";
            btn_guardar_cambios.UseVisualStyleBackColor = false;
            btn_guardar_cambios.Click += btn_guardar_cambios_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(453, 324);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 24;
            label3.Text = "Contraseña Nueva";
            // 
            // imput_contra_actual
            // 
            imput_contra_actual.Anchor = AnchorStyles.None;
            imput_contra_actual.BackColor = Color.Transparent;
            imput_contra_actual.BorderColor = Color.FromArgb(228, 231, 236);
            imput_contra_actual.BorderFocusColor = Color.FromArgb(13, 110, 253);
            imput_contra_actual.BorderRadius = 12;
            imput_contra_actual.Location = new Point(453, 278);
            imput_contra_actual.Margin = new Padding(3, 2, 3, 2);
            imput_contra_actual.Name = "imput_contra_actual";
            imput_contra_actual.Padding = new Padding(9, 8, 9, 8);
            imput_contra_actual.PlaceholderText = "Confirma tu contraseña";
            imput_contra_actual.Size = new Size(288, 34);
            imput_contra_actual.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(453, 260);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 22;
            label2.Text = "Contraseña Actual";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_07_at_12_37_13_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mi Perfil 👤";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avatar1).EndInit();
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar2).EndInit();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
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
        private BotonRedondeado btn_cancelar;
        private BotonRedondeado btn_guardar_cambios;
        private Panel panel5;
        private PictureBox avatar2;
        private Label label_saldo;
        private BotonRedondeado btn_elegir_plan;
        private BotonRedondeado btn_recargar;
        private BotonMenu btn_volver;
        private CampoPassword imput_contra_actual;
        private Label label2;
        private CampoPassword imput_nuevacontra;
        private Label label3;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
    }
}