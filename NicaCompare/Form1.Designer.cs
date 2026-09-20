namespace NicaCompare
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            botonAccion1 = new BotonAccion();
            inicio_nombre = new CampoTexto();
            Inicio_INGRESAR = new BotonAccion();
            inicioPassword = new CampoPassword();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(botonAccion1);
            panel1.Controls.Add(inicio_nombre);
            panel1.Controls.Add(Inicio_INGRESAR);
            panel1.Controls.Add(inicioPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(377, 4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 666);
            panel1.TabIndex = 0;
            // 
            // botonAccion1
            // 
            botonAccion1.Anchor = AnchorStyles.None;
            botonAccion1.BackColor = Color.Transparent;
            botonAccion1.BorderRadius = 12;
            botonAccion1.ColorNormal = Color.Navy;
            botonAccion1.FlatAppearance.BorderSize = 0;
            botonAccion1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonAccion1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonAccion1.FlatStyle = FlatStyle.Flat;
            botonAccion1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonAccion1.ForeColor = Color.White;
            botonAccion1.Location = new Point(113, 474);
            botonAccion1.Margin = new Padding(3, 2, 3, 2);
            botonAccion1.MostrarFlecha = true;
            botonAccion1.Name = "botonAccion1";
            botonAccion1.Size = new Size(286, 34);
            botonAccion1.TabIndex = 14;
            botonAccion1.Text = "INICIAR SIN CUENTA";
            botonAccion1.UseVisualStyleBackColor = false;
            botonAccion1.Click += botonAccion1_Click;
            // 
            // inicio_nombre
            // 
            inicio_nombre.Anchor = AnchorStyles.None;
            inicio_nombre.BackColor = Color.Transparent;
            inicio_nombre.BorderColor = Color.FromArgb(228, 231, 236);
            inicio_nombre.BorderFocusColor = Color.FromArgb(13, 110, 253);
            inicio_nombre.BorderRadius = 12;
            inicio_nombre.ColorFondoIcono = Color.FromArgb(241, 245, 249);
            inicio_nombre.ColorIcono = Color.FromArgb(100, 116, 139);
            inicio_nombre.EsPassword = false;
            inicio_nombre.IconoPersonalizado = null;
            inicio_nombre.Location = new Point(113, 321);
            inicio_nombre.Margin = new Padding(3, 2, 3, 2);
            inicio_nombre.Name = "inicio_nombre";
            inicio_nombre.PlaceholderText = "correo@ejemplo.com";
            inicio_nombre.Size = new Size(286, 34);
            inicio_nombre.TabIndex = 13;
            inicio_nombre.TipoIcono = TipoIconoCampo.Correo;
            inicio_nombre.TextChanged += inicio_nombre_TextChanged;
            // 
            // Inicio_INGRESAR
            // 
            Inicio_INGRESAR.Anchor = AnchorStyles.None;
            Inicio_INGRESAR.BackColor = Color.Transparent;
            Inicio_INGRESAR.BorderRadius = 12;
            Inicio_INGRESAR.ColorNormal = Color.FromArgb(255, 122, 0);
            Inicio_INGRESAR.FlatAppearance.BorderSize = 0;
            Inicio_INGRESAR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Inicio_INGRESAR.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Inicio_INGRESAR.FlatStyle = FlatStyle.Flat;
            Inicio_INGRESAR.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Inicio_INGRESAR.ForeColor = Color.White;
            Inicio_INGRESAR.Location = new Point(113, 428);
            Inicio_INGRESAR.Margin = new Padding(3, 2, 3, 2);
            Inicio_INGRESAR.MostrarFlecha = true;
            Inicio_INGRESAR.Name = "Inicio_INGRESAR";
            Inicio_INGRESAR.Size = new Size(286, 34);
            Inicio_INGRESAR.TabIndex = 12;
            Inicio_INGRESAR.Text = "INGRESAR";
            Inicio_INGRESAR.UseVisualStyleBackColor = false;
            Inicio_INGRESAR.Click += IniciarSecion;
            // 
            // inicioPassword
            // 
            inicioPassword.Anchor = AnchorStyles.None;
            inicioPassword.BackColor = Color.Transparent;
            inicioPassword.BorderColor = Color.FromArgb(228, 231, 236);
            inicioPassword.BorderFocusColor = Color.FromArgb(13, 110, 253);
            inicioPassword.BorderRadius = 12;
            inicioPassword.Location = new Point(113, 380);
            inicioPassword.Margin = new Padding(3, 2, 3, 2);
            inicioPassword.Name = "inicioPassword";
            inicioPassword.Padding = new Padding(9, 8, 9, 8);
            inicioPassword.PlaceholderText = "Confirma tu contraseña";
            inicioPassword.Size = new Size(288, 34);
            inicioPassword.TabIndex = 1;
            inicioPassword.TextChanged += inicioPassword_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 245);
            label2.Name = "label2";
            label2.Size = new Size(224, 24);
            label2.TabIndex = 2;
            label2.Text = "BIENVENIDO DE NUEVO";
            label2.Click += label2_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = Color.FromArgb(0, 0, 192);
            linkLabel2.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel2.Location = new Point(280, 524);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(88, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Crear Cuenta";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(157, 524);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 11;
            label6.Text = "¿No tienes cuenta?";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(113, 304);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 3;
            label3.Text = "Correo  Electronico";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 362);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(178, 626);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 10;
            label5.Text = "UNAN Matagalpa Grupo #1";
            label5.Click += label5_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(59, 224);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(158, 190);
            label1.Name = "label1";
            label1.Size = new Size(176, 13);
            label1.TabIndex = 1;
            label1.Text = "---- COMPARA. ELIGE. AHORRA ---";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.LOGO_222;
            pictureBox2.Location = new Point(113, 81);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(279, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_04_at_1_50_14_PM_upscayl_5x_digital_art_4x;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NicaCompare | Login 👤";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private ColorDialog colorDialog1;
        private Label label5;
        private Label label6;
        private Label label2;
        private CampoPassword inicioPassword;
        private BotonAccion Inicio_INGRESAR;
        private CampoTexto inicio_nombre;
        private LinkLabel linkLabel2;
        private BotonAccion botonAccion1;
    }
}
