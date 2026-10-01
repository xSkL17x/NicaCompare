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
            panel_planes = new Panel();
            tarjetaPlan3 = new TarjetaPlan();
            tarjetaPlan2 = new TarjetaPlan();
            tarjetaPlan1 = new TarjetaPlan();
            panel1 = new Panel();
            label_saldo = new Label();
            panel2 = new Panel();
            label_plan = new Label();
            avatar1 = new PictureBox();
            label_nombre = new Label();
            label_correo = new Label();
            panel_planes.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar1).BeginInit();
            SuspendLayout();
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = Properties.Resources.fondo_perfil;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label_saldo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label_plan);
            panel1.Controls.Add(avatar1);
            panel1.Controls.Add(label_nombre);
            panel1.Controls.Add(label_correo);
            panel1.Location = new Point(30, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 139);
            panel1.TabIndex = 3;
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
            // panel2
            // 
            panel2.Location = new Point(0, 134);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 434);
            panel2.TabIndex = 2;
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
            // avatar1
            // 
            avatar1.Anchor = AnchorStyles.None;
            avatar1.BackColor = Color.Transparent;
            avatar1.Image = Properties.Resources.no_hay_usuario;
            avatar1.Location = new Point(3, 11);
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
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(panel_planes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planes";
            WindowState = FormWindowState.Maximized;
            Load += Form8_Load;
            panel_planes.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_planes;
        private TarjetaPlan tarjetaPlan3;
        private TarjetaPlan tarjetaPlan2;
        private TarjetaPlan tarjetaPlan1;
        private Panel panel1;
        private Panel panel2;
        private Label label_plan;
        private PictureBox avatar1;
        private Label label_nombre;
        private Label label_correo;
        private Label label_saldo;
    }
}