namespace NicaCompare
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel1 = new Panel();
            btn_volver = new BotonMenu();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            botonRedondeado1 = new BotonRedondeado();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.pequenop_2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btn_volver);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 139);
            panel1.TabIndex = 0;
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Right;
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
            btn_volver.Location = new Point(1125, 31);
            btn_volver.MargenImagenIzquierda = 15;
            btn_volver.Margin = new Padding(3, 2, 3, 2);
            btn_volver.Name = "btn_volver";
            btn_volver.PorcentajeEscalaImagen = 50;
            btn_volver.Size = new Size(136, 31);
            btn_volver.TabIndex = 34;
            btn_volver.Text = "←      Volver";
            btn_volver.TextAlign = ContentAlignment.MiddleLeft;
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 85);
            label3.Name = "label3";
            label3.Size = new Size(439, 19);
            label3.TabIndex = 2;
            label3.Text = "Personaliza tu perfil para tener una mejor experiencia en NicaCompare.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(38, 44);
            label2.Name = "label2";
            label2.Size = new Size(245, 41);
            label2.TabIndex = 1;
            label2.Text = "Tu información";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Mi Perfil";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.no_hay_usuario;
            pictureBox2.Location = new Point(130, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(122, 254);
            label4.Name = "label4";
            label4.Size = new Size(262, 30);
            label4.TabIndex = 3;
            label4.Text = "Aún no tienes un perfil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(83, 294);
            label5.Name = "label5";
            label5.Size = new Size(335, 20);
            label5.TabIndex = 4;
            label5.Text = "Configura tu perfil para guardar tus preferencias, ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 320);
            label6.Name = "label6";
            label6.Size = new Size(398, 20);
            label6.TabIndex = 5;
            label6.Text = "ver historial de precios, recibir notificaciones y mucho más.";
            // 
            // botonRedondeado1
            // 
            botonRedondeado1.BackColor = Color.FromArgb(0, 0, 192);
            botonRedondeado1.BorderRadius = 20;
            botonRedondeado1.FlatAppearance.BorderSize = 0;
            botonRedondeado1.FlatStyle = FlatStyle.Flat;
            botonRedondeado1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonRedondeado1.ForeColor = Color.White;
            botonRedondeado1.Location = new Point(141, 370);
            botonRedondeado1.Margin = new Padding(3, 2, 3, 2);
            botonRedondeado1.Name = "botonRedondeado1";
            botonRedondeado1.Size = new Size(216, 36);
            botonRedondeado1.TabIndex = 6;
            botonRedondeado1.Text = "Crear Perfil";
            botonRedondeado1.UseVisualStyleBackColor = false;
            botonRedondeado1.Click += botonRedondeado1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(botonRedondeado1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(406, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 478);
            panel2.TabIndex = 7;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NicaCompare | Registro ✍️";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private BotonRedondeado botonRedondeado1;
        private Panel panel2;
        private BotonMenu btn_volver;
    }
}