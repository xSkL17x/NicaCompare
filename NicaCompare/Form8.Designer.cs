namespace NicaCompare
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label_correo = new Label();
            label_nombre = new Label();
            avatar1 = new PictureBox();
            label_plan = new Label();
            panel2 = new Panel();
            label_saldo = new Label();
            panel1 = new Panel();
            btn_volver = new BotonMenu();
            tarjetaPlan1 = new TarjetaPlan();
            tarjetaPlan2 = new TarjetaPlan();
            tarjetaPlan3 = new TarjetaPlan();
            panel_planes = new Panel();
            botonMenu2 = new BotonMenu();
            ((System.ComponentModel.ISupportInitialize)avatar1).BeginInit();
            panel1.SuspendLayout();
            panel_planes.SuspendLayout();
            SuspendLayout();
            // 
            // label_correo
            // 
            label_correo.AutoSize = true;
            label_correo.BackColor = Color.Transparent;
            label_correo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_correo.Location = new Point(194, 69);
            label_correo.Name = "label_correo";
            label_correo.Size = new Size(168, 23);
            label_correo.TabIndex = 2;
            label_correo.Text = "JomuUb@gmail.com";
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.BackColor = Color.Transparent;
            label_nombre.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nombre.ForeColor = Color.Navy;
            label_nombre.Location = new Point(194, 29);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(153, 32);
            label_nombre.TabIndex = 1;
            label_nombre.Text = "OTONIEL JR";
            // 
            // avatar1
            // 
            avatar1.Anchor = AnchorStyles.None;
            avatar1.BackColor = Color.Transparent;
            avatar1.Image = Properties.Resources.no_hay_usuario;
            avatar1.Location = new Point(3, 15);
            avatar1.Name = "avatar1";
            avatar1.Size = new Size(153, 145);
            avatar1.SizeMode = PictureBoxSizeMode.Zoom;
            avatar1.TabIndex = 2;
            avatar1.TabStop = false;
            // 
            // label_plan
            // 
            label_plan.AutoSize = true;
            label_plan.BackColor = Color.Transparent;
            label_plan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_plan.ForeColor = Color.DarkOliveGreen;
            label_plan.Location = new Point(195, 108);
            label_plan.Name = "label_plan";
            label_plan.Size = new Size(91, 23);
            label_plan.TabIndex = 3;
            label_plan.Text = "Plan None";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(1441, 579);
            panel2.TabIndex = 2;
            // 
            // label_saldo
            // 
            label_saldo.AutoSize = true;
            label_saldo.BackColor = Color.Transparent;
            label_saldo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_saldo.ForeColor = Color.Navy;
            label_saldo.Location = new Point(195, 133);
            label_saldo.Name = "label_saldo";
            label_saldo.Size = new Size(152, 23);
            label_saldo.TabIndex = 4;
            label_saldo.Text = "Saldo Actual C$ 0";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = Properties.Resources.fondo_perfil;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btn_volver);
            panel1.Controls.Add(label_saldo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label_plan);
            panel1.Controls.Add(avatar1);
            panel1.Controls.Add(label_nombre);
            panel1.Controls.Add(label_correo);
            panel1.Location = new Point(34, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1361, 185);
            panel1.TabIndex = 3;
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
            btn_volver.Location = new Point(1202, 15);
            btn_volver.MargenImagenIzquierda = 15;
            btn_volver.Name = "btn_volver";
            btn_volver.PorcentajeEscalaImagen = 50;
            btn_volver.Size = new Size(155, 41);
            btn_volver.TabIndex = 32;
            btn_volver.Text = "←      Volver";
            btn_volver.TextAlign = ContentAlignment.MiddleLeft;
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // tarjetaPlan1
            // 
            tarjetaPlan1.BackColor = Color.Transparent;
            tarjetaPlan1.Location = new Point(45, 212);
            tarjetaPlan1.Name = "tarjetaPlan1";
            tarjetaPlan1.Size = new Size(338, 525);
            tarjetaPlan1.TabIndex = 0;
            tarjetaPlan1.ClickSeleccionar += tarjetaPlan1_ClickSeleccionar;
            // 
            // tarjetaPlan2
            // 
            tarjetaPlan2.BackColor = Color.Transparent;
            tarjetaPlan2.Location = new Point(504, 212);
            tarjetaPlan2.Name = "tarjetaPlan2";
            tarjetaPlan2.Size = new Size(338, 525);
            tarjetaPlan2.TabIndex = 1;
            tarjetaPlan2.TipoPlan = NivelPlan.Premium;
            tarjetaPlan2.ClickSeleccionar += tarjetaPlan2_ClickSeleccionar;
            // 
            // tarjetaPlan3
            // 
            tarjetaPlan3.BackColor = Color.Transparent;
            tarjetaPlan3.Location = new Point(960, 212);
            tarjetaPlan3.Name = "tarjetaPlan3";
            tarjetaPlan3.Size = new Size(338, 525);
            tarjetaPlan3.TabIndex = 2;
            tarjetaPlan3.TipoPlan = NivelPlan.Elite;
            tarjetaPlan3.ClickSeleccionar += tarjetaPlan3_ClickSeleccionar;
            // 
            // panel_planes
            // 
            panel_planes.Anchor = AnchorStyles.None;
            panel_planes.Controls.Add(botonMenu2);
            panel_planes.Controls.Add(tarjetaPlan3);
            panel_planes.Controls.Add(tarjetaPlan2);
            panel_planes.Controls.Add(tarjetaPlan1);
            panel_planes.Location = new Point(31, 15);
            panel_planes.Name = "panel_planes";
            panel_planes.Size = new Size(1365, 837);
            panel_planes.TabIndex = 0;
            // 
            // botonMenu2
            // 
            botonMenu2.AutoColorearIconoBlanco = true;
            botonMenu2.AutoEscalarImagen = true;
            botonMenu2.BackColor = Color.Transparent;
            botonMenu2.BorderRadius = 18;
            botonMenu2.ColorHover = Color.FromArgb(13, 110, 253);
            botonMenu2.ColorTextoNormal = Color.FromArgb(70, 70, 70);
            botonMenu2.EsSeleccionado = false;
            botonMenu2.FlatAppearance.BorderSize = 0;
            botonMenu2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonMenu2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonMenu2.FlatStyle = FlatStyle.Flat;
            botonMenu2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            botonMenu2.ForeColor = Color.FromArgb(70, 70, 70);
            botonMenu2.Image = (Image)resources.GetObject("botonMenu2.Image");
            botonMenu2.Location = new Point(1092, 764);
            botonMenu2.MargenImagenIzquierda = 15;
            botonMenu2.Name = "botonMenu2";
            botonMenu2.PorcentajeEscalaImagen = 50;
            botonMenu2.Size = new Size(253, 53);
            botonMenu2.TabIndex = 20;
            botonMenu2.Text = "Cerrar sesion";
            botonMenu2.TextAlign = ContentAlignment.MiddleLeft;
            botonMenu2.UseVisualStyleBackColor = false;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(panel1);
            Controls.Add(panel_planes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planes";
            WindowState = FormWindowState.Maximized;
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)avatar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_planes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label_correo;
        private Label label_nombre;
        private PictureBox avatar1;
        private Label label_plan;
        private Panel panel2;
        private Label label_saldo;
        private Panel panel1;
        private TarjetaPlan tarjetaPlan1;
        private TarjetaPlan tarjetaPlan2;
        private TarjetaPlan tarjetaPlan3;
        private Panel panel_planes;
        private BotonMenu btn_volver;
        private BotonMenu botonMenu2;
    }
}