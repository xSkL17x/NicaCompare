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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            campoTexto1 = new CampoTexto();
            campoTexto2 = new CampoTexto();
            campoTexto3 = new CampoTexto();
            campoTexto4 = new CampoTexto();
            campoTexto5 = new CampoTexto();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            botonRedondeado1 = new BotonRedondeado();
            botonRedondeado2 = new BotonRedondeado();
            label11 = new Label();
            label12 = new Label();
            botonRedondeado3 = new BotonRedondeado();
            botonRedondeado4 = new BotonRedondeado();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fondo_perfil;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1441, 185);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(1441, 579);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(195, 108);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 3;
            label1.Text = "Usuario desde 2026";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.no_hay_usuario;
            pictureBox2.Location = new Point(35, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(194, 30);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 1;
            label2.Text = "OTONIEL JR";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 70);
            label3.Name = "label3";
            label3.Size = new Size(168, 23);
            label3.TabIndex = 2;
            label3.Text = "JomuUb@gmail.com";
            label3.Click += label3_Click;
            // 
            // campoTexto1
            // 
            campoTexto1.BackColor = Color.Transparent;
            campoTexto1.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto1.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto1.BorderRadius = 12;
            campoTexto1.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto1.EsPassword = false;
            campoTexto1.IconoPersonalizado = null;
            campoTexto1.Location = new Point(35, 327);
            campoTexto1.Name = "campoTexto1";
            campoTexto1.PlaceholderText = "Ingresa tu texto aquí";
            campoTexto1.Size = new Size(400, 60);
            campoTexto1.TabIndex = 2;
            campoTexto1.TipoIcono = TipoIconoCampo.Usuario;
            // 
            // campoTexto2
            // 
            campoTexto2.BackColor = Color.Transparent;
            campoTexto2.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto2.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto2.BorderRadius = 12;
            campoTexto2.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto2.EsPassword = false;
            campoTexto2.IconoPersonalizado = null;
            campoTexto2.Location = new Point(35, 484);
            campoTexto2.Name = "campoTexto2";
            campoTexto2.PlaceholderText = "Ingresa tu texto aquí";
            campoTexto2.Size = new Size(400, 60);
            campoTexto2.TabIndex = 3;
            campoTexto2.TipoIcono = TipoIconoCampo.Telefono;
            // 
            // campoTexto3
            // 
            campoTexto3.BackColor = Color.Transparent;
            campoTexto3.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto3.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto3.BorderRadius = 12;
            campoTexto3.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto3.EsPassword = false;
            campoTexto3.IconoPersonalizado = null;
            campoTexto3.Location = new Point(35, 645);
            campoTexto3.Name = "campoTexto3";
            campoTexto3.PlaceholderText = "";
            campoTexto3.Size = new Size(400, 60);
            campoTexto3.TabIndex = 4;
            campoTexto3.TipoIcono = TipoIconoCampo.Ubicacion;
            // 
            // campoTexto4
            // 
            campoTexto4.BackColor = Color.Transparent;
            campoTexto4.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto4.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto4.BorderRadius = 12;
            campoTexto4.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto4.EsPassword = false;
            campoTexto4.IconoPersonalizado = null;
            campoTexto4.Location = new Point(518, 292);
            campoTexto4.Name = "campoTexto4";
            campoTexto4.PlaceholderText = "Ingresa tu texto aquí";
            campoTexto4.Size = new Size(400, 60);
            campoTexto4.TabIndex = 6;
            campoTexto4.TipoIcono = TipoIconoCampo.Calendario;
            campoTexto4.TextChanged += campoTexto4_TextChanged;
            // 
            // campoTexto5
            // 
            campoTexto5.BackColor = Color.Transparent;
            campoTexto5.BorderColor = Color.FromArgb(228, 231, 236);
            campoTexto5.BorderFocusColor = Color.FromArgb(13, 110, 253);
            campoTexto5.BorderRadius = 12;
            campoTexto5.ColorIcono = Color.FromArgb(130, 138, 150);
            campoTexto5.EsPassword = false;
            campoTexto5.IconoPersonalizado = null;
            campoTexto5.Location = new Point(518, 135);
            campoTexto5.Name = "campoTexto5";
            campoTexto5.PlaceholderText = "Ingresa tu texto aquí";
            campoTexto5.Size = new Size(400, 60);
            campoTexto5.TabIndex = 5;
            campoTexto5.TipoIcono = TipoIconoCampo.Correo;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(39, 300);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 7;
            label4.Text = "Nombre Completo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(39, 450);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(39, 606);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 9;
            label6.Text = "Ubicacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(520, 110);
            label7.Name = "label7";
            label7.Size = new Size(157, 23);
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
            label8.Location = new Point(518, 265);
            label8.Name = "label8";
            label8.Size = new Size(174, 23);
            label8.TabIndex = 11;
            label8.Text = "Fecha de nacimiento";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(39, 201);
            label9.Name = "label9";
            label9.Size = new Size(243, 31);
            label9.TabIndex = 12;
            label9.Text = "Información Personal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(39, 232);
            label10.Name = "label10";
            label10.Size = new Size(544, 23);
            label10.TabIndex = 4;
            label10.Text = "Actualiza tus datos para tener una mejor experiencia en nica compare";
            // 
            // panel3
            // 
            panel3.Controls.Add(campoTexto5);
            panel3.Controls.Add(campoTexto4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(12, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 538);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(botonRedondeado2);
            panel4.Controls.Add(botonRedondeado1);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(979, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(444, 416);
            panel4.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.no_hay_usuario;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(104, 105);
            button1.Name = "button1";
            button1.Size = new Size(247, 200);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.FromArgb(0, 0, 192);
            botonRedondeado1.BorderRadius = 20;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(18, 316);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(199, 50);
            botonRedondeado1.TabIndex = 1;
            botonRedondeado1.Text = "Subir foto";
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // botonRedondeado2
            // 
            botonRedondeado2.BackColor = Color.FromArgb(255, 128, 0);
            botonRedondeado2.BorderRadius = 20;
            botonRedondeado2.FlatAppearance.BorderSize = 0;
            botonRedondeado2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado2.ForeColor = Color.White;
            botonRedondeado2.ImageAlign = ContentAlignment.TopLeft;
            botonRedondeado2.Location = new Point(231, 316);
            botonRedondeado2.Name = "botonRedondeado2";
            botonRedondeado2.Size = new Size(195, 50);
            botonRedondeado2.TabIndex = 2;
            botonRedondeado2.Text = "Eliminar foto";
            botonRedondeado2.UseVisualStyleBackColor = false;
            botonRedondeado2.Click += botonRedondeado2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(18, 23);
            label11.Name = "label11";
            label11.Size = new Size(147, 28);
            label11.TabIndex = 4;
            label11.Text = "Foto de perfil";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 51);
            label12.Name = "label12";
            label12.Size = new Size(255, 23);
            label12.TabIndex = 4;
            label12.Text = "Puedes cambiar tu foto de perfil";
            // 
            // botonRedondeado3
            // 
            botonRedondeado3.BackColor = Color.FromArgb(255, 128, 0);
            botonRedondeado3.BorderRadius = 20;
            botonRedondeado3.FlatAppearance.BorderSize = 0;
            botonRedondeado3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado3.ForeColor = Color.White;
            botonRedondeado3.ImageAlign = ContentAlignment.TopLeft;
            botonRedondeado3.Location = new Point(262, 28);
            botonRedondeado3.Name = "botonRedondeado3";
            botonRedondeado3.Size = new Size(164, 50);
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
            botonRedondeado4.Location = new Point(18, 28);
            botonRedondeado4.Name = "botonRedondeado4";
            botonRedondeado4.Size = new Size(223, 50);
            botonRedondeado4.TabIndex = 5;
            botonRedondeado4.Text = "Guardar cambios";
            botonRedondeado4.UseVisualStyleBackColor = false;
            botonRedondeado4.Click += botonRedondeado4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(botonRedondeado3);
            panel5.Controls.Add(botonRedondeado4);
            panel5.Location = new Point(979, 617);
            panel5.Name = "panel5";
            panel5.Size = new Size(444, 113);
            panel5.TabIndex = 16;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_07_at_12_37_13_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1435, 767);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(campoTexto3);
            Controls.Add(campoTexto2);
            Controls.Add(campoTexto1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Name = "Form6";
            Text = "Form6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel2;
        private CampoTexto campoTexto1;
        private CampoTexto campoTexto2;
        private CampoTexto campoTexto3;
        private CampoTexto campoTexto4;
        private CampoTexto campoTexto5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private BotonRedondeado botonRedondeado2;
        private BotonRedondeado botonRedondeado1;
        private Label label12;
        private Label label11;
        private BotonRedondeado botonRedondeado3;
        private BotonRedondeado botonRedondeado4;
        private Panel panel5;
    }
}