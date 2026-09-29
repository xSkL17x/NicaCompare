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
            panel1 = new Panel();
            tarjetaPlan1 = new TarjetaPlan();
            tarjetaPlan2 = new TarjetaPlan();
            tarjetaPlan3 = new TarjetaPlan();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tarjetaPlan3);
            panel1.Controls.Add(tarjetaPlan2);
            panel1.Controls.Add(tarjetaPlan1);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 766);
            panel1.TabIndex = 0;
            // 
            // tarjetaPlan1
            // 
            tarjetaPlan1.BackColor = Color.Transparent;
            tarjetaPlan1.Location = new Point(52, 148);
            tarjetaPlan1.Name = "tarjetaPlan1";
            tarjetaPlan1.Size = new Size(338, 525);
            tarjetaPlan1.TabIndex = 0;
            // 
            // tarjetaPlan2
            // 
            tarjetaPlan2.BackColor = Color.Transparent;
            tarjetaPlan2.Location = new Point(512, 148);
            tarjetaPlan2.Name = "tarjetaPlan2";
            tarjetaPlan2.Size = new Size(338, 525);
            tarjetaPlan2.TabIndex = 1;
            tarjetaPlan2.TipoPlan = NivelPlan.Premium;
            // 
            // tarjetaPlan3
            // 
            tarjetaPlan3.BackColor = Color.Transparent;
            tarjetaPlan3.Location = new Point(968, 148);
            tarjetaPlan3.Name = "tarjetaPlan3";
            tarjetaPlan3.Size = new Size(338, 525);
            tarjetaPlan3.TabIndex = 2;
            tarjetaPlan3.TipoPlan = NivelPlan.Elite;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 769);
            Controls.Add(panel1);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SKL ES LA MAQUINA";
            WindowState = FormWindowState.Maximized;
            Load += Form8_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TarjetaPlan tarjetaPlan3;
        private TarjetaPlan tarjetaPlan2;
        private TarjetaPlan tarjetaPlan1;
    }
}