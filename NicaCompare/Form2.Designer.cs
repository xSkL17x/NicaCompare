namespace NicaCompare
{
    partial class Registro
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new ReaLTaiizor.Controls.Panel();
            Crearcuenta = new BotonAccion();
            registro_correo = new CampoTexto();
            registro_nombre = new CampoTexto();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            volver_inicio = new LinkLabel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            linkLabel4 = new LinkLabel();
            label5 = new Label();
            linkLabel3 = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            campoPassword1 = new CampoPassword();
            campoPassword2 = new CampoPassword();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(campoPassword2);
            panel1.Controls.Add(campoPassword1);
            panel1.Controls.Add(Crearcuenta);
            panel1.Controls.Add(registro_correo);
            panel1.Controls.Add(registro_nombre);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(volver_inicio);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(483, 95);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 5, 5, 5);
            panel1.Size = new Size(440, 707);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            panel1.Click += panel1_Click;
            // 
            // Crearcuenta
            // 
            Crearcuenta.Anchor = AnchorStyles.None;
            Crearcuenta.BackColor = Color.Transparent;
            Crearcuenta.BorderRadius = 12;
            Crearcuenta.ColorNormal = Color.FromArgb(255, 122, 0);
            Crearcuenta.FlatAppearance.BorderSize = 0;
            Crearcuenta.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Crearcuenta.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Crearcuenta.FlatStyle = FlatStyle.Flat;
            Crearcuenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Crearcuenta.ForeColor = Color.White;
            Crearcuenta.Location = new Point(56, 577);
            Crearcuenta.MostrarFlecha = true;
            Crearcuenta.Name = "Crearcuenta";
            Crearcuenta.Size = new Size(327, 45);
            Crearcuenta.TabIndex = 13;
            Crearcuenta.Text = "Crear Cuenta";
            Crearcuenta.UseVisualStyleBackColor = false;
            Crearcuenta.Click += Crear_Cuenta;
            // 
            // registro_correo
            // 
            registro_correo.Anchor = AnchorStyles.None;
            registro_correo.BackColor = Color.Transparent;
            registro_correo.BorderColor = Color.FromArgb(228, 231, 236);
            registro_correo.BorderFocusColor = Color.FromArgb(13, 110, 253);
            registro_correo.BorderRadius = 12;
            registro_correo.ColorIcono = Color.FromArgb(130, 138, 150);
            registro_correo.EsPassword = false;
            registro_correo.IconoPersonalizado = null;
            registro_correo.Location = new Point(56, 367);
            registro_correo.Name = "registro_correo";
            registro_correo.PlaceholderText = "Ingresa tu texto aquí";
            registro_correo.Size = new Size(327, 45);
            registro_correo.TabIndex = 21;
            registro_correo.TipoIcono = TipoIconoCampo.Correo;
            // 
            // registro_nombre
            // 
            registro_nombre.Anchor = AnchorStyles.None;
            registro_nombre.BackColor = Color.Transparent;
            registro_nombre.BorderColor = Color.FromArgb(228, 231, 236);
            registro_nombre.BorderFocusColor = Color.FromArgb(13, 110, 253);
            registro_nombre.BorderRadius = 12;
            registro_nombre.ColorIcono = Color.FromArgb(130, 138, 150);
            registro_nombre.EsPassword = false;
            registro_nombre.IconoPersonalizado = null;
            registro_nombre.Location = new Point(56, 297);
            registro_nombre.Name = "registro_nombre";
            registro_nombre.PlaceholderText = "Ingresa tu texto aquí";
            registro_nombre.Size = new Size(327, 45);
            registro_nombre.TabIndex = 20;
            registro_nombre.TipoIcono = TipoIconoCampo.Usuario;
            registro_nombre.TextChanged += campoTexto1_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(103, 85);
            label11.Name = "label11";
            label11.Size = new Size(216, 16);
            label11.TabIndex = 8;
            label11.Text = "---- COMPARA. ELIGE. AHORRA ---";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(0, 0, 192);
            label10.Location = new Point(191, 243);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 19;
            label10.Text = "NicaCompare";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(133, 243);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 18;
            label9.Text = "Únete a";
            // 
            // volver_inicio
            // 
            volver_inicio.Anchor = AnchorStyles.None;
            volver_inicio.AutoSize = true;
            volver_inicio.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            volver_inicio.ForeColor = SystemColors.HotTrack;
            volver_inicio.LinkColor = Color.FromArgb(0, 0, 192);
            volver_inicio.Location = new Point(234, 639);
            volver_inicio.Name = "volver_inicio";
            volver_inicio.Size = new Size(102, 20);
            volver_inicio.TabIndex = 10;
            volver_inicio.TabStop = true;
            volver_inicio.Text = "Accede aquí";
            volver_inicio.LinkClicked += ir_al_login;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(99, 639);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 12;
            label8.Text = "¿Ya tienes cuenta?";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(120, 683);
            label7.Name = "label7";
            label7.Size = new Size(193, 20);
            label7.TabIndex = 11;
            label7.Text = "UNAN Matagalpa Grupo #1";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(56, 487);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 14;
            label6.Text = "Confirmar Contraseña";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(49, 577);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(0, 20);
            linkLabel4.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 416);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 11;
            label5.Text = "Contraseña";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(49, 497);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(0, 20);
            linkLabel3.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 344);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 8;
            label4.Text = "Correo  Electronico";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 275);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre Completo";
            label3.Click += label3_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(49, 425);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 20);
            linkLabel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(210, 207);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 4;
            label2.Text = "CUENTA";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(112, 207);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 3;
            label1.Text = "CREAR";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.LOGO_222;
            pictureBox2.Location = new Point(56, -29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(319, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // campoPassword1
            // 
            campoPassword1.Anchor = AnchorStyles.None;
            campoPassword1.BackColor = Color.Transparent;
            campoPassword1.BorderColor = Color.FromArgb(228, 231, 236);
            campoPassword1.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoPassword1.BorderRadius = 12;
            campoPassword1.Location = new Point(56, 439);
            campoPassword1.Name = "campoPassword1";
            campoPassword1.Padding = new Padding(10, 11, 10, 11);
            campoPassword1.PlaceholderText = "Confirma tu contraseña";
            campoPassword1.Size = new Size(329, 45);
            campoPassword1.TabIndex = 23;
            // 
            // campoPassword2
            // 
            campoPassword2.Anchor = AnchorStyles.None;
            campoPassword2.BackColor = Color.Transparent;
            campoPassword2.BorderColor = Color.FromArgb(228, 231, 236);
            campoPassword2.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoPassword2.BorderRadius = 12;
            campoPassword2.Location = new Point(56, 510);
            campoPassword2.Name = "campoPassword2";
            campoPassword2.Padding = new Padding(10, 11, 10, 11);
            campoPassword2.PlaceholderText = "Confirma tu contraseña";
            campoPassword2.Size = new Size(329, 45);
            campoPassword2.TabIndex = 24;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_04_at_1_50_14_PM_upscayl_5x_digital_art_4x;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1445, 908);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NicaCompare | Registro ✍️";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
        private LinkLabel linkLabel4;
        private Label label5;
        private LinkLabel linkLabel3;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel2;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private LinkLabel volver_inicio;
        private Label label11;
        private CampoTexto registro_correo;
        private CampoTexto registro_nombre;
        private BotonAccion Crearcuenta;
        private CampoPassword campoPassword2;
        private CampoPassword campoPassword1;
    }
}