namespace NicaCompare
{
    partial class Form1
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
            panel1 = new Panel();
            campoTexto1 = new CampoTexto();
            INGRESAR1 = new BotonAccion();
            campoPassword1 = new CampoPassword();
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(campoTexto1);
            panel1.Controls.Add(INGRESAR1);
            panel1.Controls.Add(campoPassword1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(252, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 616);
            panel1.TabIndex = 0;
            // 
            // campoTexto1
            // 
            campoTexto1.BackColor = Color.Transparent;
            campoTexto1.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto1.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto1.BorderRadius = 12;
            campoTexto1.Location = new Point(74, 292);
            campoTexto1.Name = "campoTexto1";
            campoTexto1.PlaceholderText = "Ingresa tu texto aquí";
            campoTexto1.Size = new Size(327, 46);
            campoTexto1.TabIndex = 13;
            campoTexto1.TipoIcono = TipoIconoCampo.Correo;
            // 
            // INGRESAR1
            // 
            INGRESAR1.BackColor = Color.Transparent;
            INGRESAR1.BorderRadius = 12;
            INGRESAR1.ColorNormal = Color.FromArgb(255, 122, 0);
            INGRESAR1.FlatAppearance.BorderSize = 0;
            INGRESAR1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            INGRESAR1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            INGRESAR1.FlatStyle = FlatStyle.Flat;
            INGRESAR1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            INGRESAR1.ForeColor = Color.White;
            INGRESAR1.Location = new Point(74, 434);
            INGRESAR1.MostrarFlecha = true;
            INGRESAR1.Name = "INGRESAR1";
            INGRESAR1.Size = new Size(327, 46);
            INGRESAR1.TabIndex = 12;
            INGRESAR1.Text = "INGRESAR";
            INGRESAR1.UseVisualStyleBackColor = false;
            INGRESAR1.Click += INGRESAR1_Click;
            // 
            // campoPassword1
            // 
            campoPassword1.BackColor = Color.Transparent;
            campoPassword1.BorderColor = Color.FromArgb(228, 231, 236);
            campoPassword1.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoPassword1.BorderRadius = 12;
            campoPassword1.Location = new Point(74, 370);
            campoPassword1.Name = "campoPassword1";
            campoPassword1.Padding = new Padding(10);
            campoPassword1.PlaceholderText = "Confirma tu contraseña";
            campoPassword1.Size = new Size(329, 46);
            campoPassword1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 191);
            label2.Name = "label2";
            label2.Size = new Size(281, 30);
            label2.TabIndex = 2;
            label2.Text = "BIENVENIDO DE NUEVO";
            label2.Click += label2_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = Color.FromArgb(0, 0, 192);
            linkLabel2.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel2.Location = new Point(267, 500);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Crea una";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 500);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 11;
            label6.Text = "¿No tienes cuenta?";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 269);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 3;
            label3.Text = "Correo  Electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 347);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 563);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 10;
            label5.Text = "UNAN Matagalpa Grupo #1";
            label5.Click += label5_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(67, 299);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(126, 117);
            label1.Name = "label1";
            label1.Size = new Size(216, 16);
            label1.TabIndex = 1;
            label1.Text = "---- COMPARA. ELIGE. AHORRA ---";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGO_222;
            pictureBox2.Location = new Point(74, -28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(319, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_04_at_1_50_14_PM_upscayl_5x_digital_art_4x;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1011, 636);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
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
        private LinkLabel linkLabel2;
        private Label label2;
        private CampoPassword campoPassword1;
        private BotonAccion INGRESAR1;
        private CampoTexto campoTexto1;
    }
}
