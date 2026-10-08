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
            avatar_planes = new PictureBox();
            label_plan = new Label();
            panel2 = new Panel();
            label_saldo = new Label();
            panel_usuario = new Panel();
            btn_volver = new BotonMenu();
            tarjetaPlan1 = new TarjetaPlan();
            tarjetaPlan2 = new TarjetaPlan();
            tarjetaPlan3 = new TarjetaPlan();
            panel_planes = new Panel();
            ((System.ComponentModel.ISupportInitialize)avatar_planes).BeginInit();
            panel_usuario.SuspendLayout();
            panel_planes.SuspendLayout();
            SuspendLayout();
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
            // 
            // avatar_planes
            // 
            avatar_planes.Anchor = AnchorStyles.None;
            avatar_planes.BackColor = Color.Transparent;
            avatar_planes.Image = Properties.Resources.no_hay_usuario;
            avatar_planes.Location = new Point(3, 11);
            avatar_planes.Margin = new Padding(3, 2, 3, 2);
            avatar_planes.Name = "avatar_planes";
            avatar_planes.Size = new Size(134, 109);
            avatar_planes.SizeMode = PictureBoxSizeMode.Zoom;
            avatar_planes.TabIndex = 2;
            avatar_planes.TabStop = false;
            // 
            // label_plan
            // 
            label_plan.AutoSize = true;
            label_plan.BackColor = Color.Transparent;
            label_plan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_plan.ForeColor = Color.DarkOliveGreen;
            label_plan.Location = new Point(171, 81);
            label_plan.Name = "label_plan";
            label_plan.Size = new Size(78, 19);
            label_plan.TabIndex = 3;
            label_plan.Text = "Plan None";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 134);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 434);
            panel2.TabIndex = 2;
            // 
            // label_saldo
            // 
            label_saldo.AutoSize = true;
            label_saldo.BackColor = Color.Transparent;
            label_saldo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_saldo.ForeColor = Color.Navy;
            label_saldo.Location = new Point(171, 100);
            label_saldo.Name = "label_saldo";
            label_saldo.Size = new Size(126, 19);
            label_saldo.TabIndex = 4;
            label_saldo.Text = "Saldo Actual C$ 0";
            // 
            // panel_usuario
            // 
            panel_usuario.Anchor = AnchorStyles.None;
            panel_usuario.BackgroundImage = Properties.Resources.fondo_perfil;
            panel_usuario.BackgroundImageLayout = ImageLayout.Stretch;
            panel_usuario.Controls.Add(btn_volver);
            panel_usuario.Controls.Add(label_saldo);
            panel_usuario.Controls.Add(panel2);
            panel_usuario.Controls.Add(label_plan);
            panel_usuario.Controls.Add(avatar_planes);
            panel_usuario.Controls.Add(label_nombre);
            panel_usuario.Controls.Add(label_correo);
            panel_usuario.Location = new Point(30, 11);
            panel_usuario.Margin = new Padding(3, 2, 3, 2);
            panel_usuario.Name = "panel_usuario";
            panel_usuario.Size = new Size(1191, 139);
            panel_usuario.TabIndex = 3;
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
            btn_volver.Location = new Point(1052, 11);
            btn_volver.MargenImagenIzquierda = 15;
            btn_volver.Margin = new Padding(3, 2, 3, 2);
            btn_volver.Name = "btn_volver";
            btn_volver.PorcentajeEscalaImagen = 50;
            btn_volver.Size = new Size(136, 31);
            btn_volver.TabIndex = 32;
            btn_volver.Text = "←      Volver";
            btn_volver.TextAlign = ContentAlignment.MiddleLeft;
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // tarjetaPlan1
            // 
            tarjetaPlan1.BackColor = Color.Transparent;
            tarjetaPlan1.Location = new Point(39, 159);
            tarjetaPlan1.Margin = new Padding(3, 2, 3, 2);
            tarjetaPlan1.Name = "tarjetaPlan1";
            tarjetaPlan1.Size = new Size(296, 394);
            tarjetaPlan1.TabIndex = 0;
            tarjetaPlan1.ClickSeleccionar += tarjetaPlan1_ClickSeleccionar;
            // 
            // tarjetaPlan2
            // 
            tarjetaPlan2.BackColor = Color.Transparent;
            tarjetaPlan2.Location = new Point(441, 159);
            tarjetaPlan2.Margin = new Padding(3, 2, 3, 2);
            tarjetaPlan2.Name = "tarjetaPlan2";
            tarjetaPlan2.Size = new Size(296, 394);
            tarjetaPlan2.TabIndex = 1;
            tarjetaPlan2.TipoPlan = NivelPlan.Premium;
            tarjetaPlan2.ClickSeleccionar += tarjetaPlan2_ClickSeleccionar;
            // 
            // tarjetaPlan3
            // 
            tarjetaPlan3.BackColor = Color.Transparent;
            tarjetaPlan3.Location = new Point(840, 159);
            tarjetaPlan3.Margin = new Padding(3, 2, 3, 2);
            tarjetaPlan3.Name = "tarjetaPlan3";
            tarjetaPlan3.Size = new Size(296, 394);
            tarjetaPlan3.TabIndex = 2;
            tarjetaPlan3.TipoPlan = NivelPlan.Elite;
            tarjetaPlan3.ClickSeleccionar += tarjetaPlan3_ClickSeleccionar;
            // 
            // panel_planes
            // 
            panel_planes.Anchor = AnchorStyles.None;
            panel_planes.Controls.Add(tarjetaPlan3);
            panel_planes.Controls.Add(tarjetaPlan2);
            panel_planes.Controls.Add(tarjetaPlan1);
            panel_planes.Location = new Point(27, 11);
            panel_planes.Margin = new Padding(3, 2, 3, 2);
            panel_planes.Name = "panel_planes";
            panel_planes.Size = new Size(1194, 628);
            panel_planes.TabIndex = 0;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel_usuario);
            Controls.Add(panel_planes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planes";
            WindowState = FormWindowState.Maximized;
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)avatar_planes).EndInit();
            panel_usuario.ResumeLayout(false);
            panel_usuario.PerformLayout();
            panel_planes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label_correo;
        private Label label_nombre;
        private PictureBox avatar_planes;
        private Label label_plan;
        private Panel panel2;
        private Label label_saldo;
        private Panel panel_usuario;
        private TarjetaPlan tarjetaPlan1;
        private TarjetaPlan tarjetaPlan2;
        private TarjetaPlan tarjetaPlan3;
        private Panel panel_planes;
        private BotonMenu btn_volver;
    }
}