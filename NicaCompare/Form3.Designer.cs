namespace NicaCompare
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            boton_usuario = new BotonMenu();
            tarjetaTienda1 = new TarjetaTienda();
            tarjetaTienda2 = new TarjetaTienda();
            tarjetaTienda3 = new TarjetaTienda();
            LABEL = new Label();
            label1 = new Label();
            barraBusqueda1 = new BarraBusqueda();
            label2 = new Label();
            panel_Busqueda = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label11 = new Label();
            panel6 = new Panel();
            botonMenu6 = new BotonMenu();
            contenedor_categorias_tabla = new Panel();
            label_txt_compare = new Label();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            TABLAPRODUCTOS = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Tienda = new DataGridViewTextBoxColumn();
            label_producto_busqueda = new Label();
            panel3 = new Panel();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            lbl_Compare_gallo = new Label();
            lbl_Compare_gcm = new Label();
            lbl_Compare_sicsa = new Label();
            lbl_busquedas_restantes = new Label();
            panel_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            contenedor_categorias_tabla.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TABLAPRODUCTOS).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // boton_usuario
            // 
            boton_usuario.AutoColorearIconoBlanco = true;
            boton_usuario.AutoEllipsis = true;
            boton_usuario.AutoEscalarImagen = true;
            boton_usuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            boton_usuario.BackColor = Color.Transparent;
            boton_usuario.BorderRadius = 18;
            boton_usuario.ColorHover = Color.FromArgb(13, 110, 253);
            boton_usuario.ColorTextoNormal = Color.FromArgb(70, 70, 70);
            boton_usuario.EsSeleccionado = false;
            boton_usuario.FlatAppearance.BorderSize = 0;
            boton_usuario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            boton_usuario.FlatAppearance.MouseOverBackColor = Color.Transparent;
            boton_usuario.FlatStyle = FlatStyle.Flat;
            boton_usuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            boton_usuario.ForeColor = Color.FromArgb(70, 70, 70);
            boton_usuario.Image = Properties.Resources.usuario;
            boton_usuario.Location = new Point(261, 9);
            boton_usuario.MargenImagenIzquierda = 15;
            boton_usuario.Margin = new Padding(3, 2, 3, 2);
            boton_usuario.Name = "boton_usuario";
            boton_usuario.PorcentajeEscalaImagen = 50;
            boton_usuario.Size = new Size(166, 36);
            boton_usuario.TabIndex = 16;
            boton_usuario.Text = "Inicio de Sesión";
            boton_usuario.TextAlign = ContentAlignment.MiddleRight;
            boton_usuario.UseVisualStyleBackColor = false;
            boton_usuario.Click += boton_usuario_Click;
            // 
            // tarjetaTienda1
            // 
            tarjetaTienda1.BackColor = Color.Transparent;
            tarjetaTienda1.BackgroundImage = (Image)resources.GetObject("tarjetaTienda1.BackgroundImage");
            tarjetaTienda1.BackgroundImageLayout = ImageLayout.Center;
            tarjetaTienda1.ColorBorde = Color.FromArgb(220, 224, 230);
            tarjetaTienda1.ColorCheck = Color.FromArgb(13, 110, 253);
            tarjetaTienda1.Enabled = false;
            tarjetaTienda1.Imagen = null;
            tarjetaTienda1.Location = new Point(187, 4);
            tarjetaTienda1.MargenImagen = 8;
            tarjetaTienda1.Margin = new Padding(3, 2, 3, 2);
            tarjetaTienda1.MinimumSize = new Size(35, 22);
            tarjetaTienda1.MostrarBorde = false;
            tarjetaTienda1.MostrarSeparador = true;
            tarjetaTienda1.Name = "tarjetaTienda1";
            tarjetaTienda1.Seleccionado = true;
            tarjetaTienda1.Size = new Size(180, 110);
            tarjetaTienda1.TabIndex = 18;
            tarjetaTienda1.TamañoImagen = new Size(0, 0);
            tarjetaTienda1.Text = "tarjetaTienda1";
            tarjetaTienda1.CheckedChanged += tarjetaTienda1_CheckedChanged;
            // 
            // tarjetaTienda2
            // 
            tarjetaTienda2.BackColor = Color.Transparent;
            tarjetaTienda2.BackgroundImage = (Image)resources.GetObject("tarjetaTienda2.BackgroundImage");
            tarjetaTienda2.BackgroundImageLayout = ImageLayout.Center;
            tarjetaTienda2.ColorBorde = Color.FromArgb(220, 224, 230);
            tarjetaTienda2.ColorCheck = Color.FromArgb(13, 110, 253);
            tarjetaTienda2.Imagen = null;
            tarjetaTienda2.Location = new Point(376, 4);
            tarjetaTienda2.MargenImagen = 8;
            tarjetaTienda2.Margin = new Padding(3, 2, 3, 2);
            tarjetaTienda2.MinimumSize = new Size(35, 22);
            tarjetaTienda2.MostrarBorde = false;
            tarjetaTienda2.MostrarSeparador = true;
            tarjetaTienda2.Name = "tarjetaTienda2";
            tarjetaTienda2.Seleccionado = true;
            tarjetaTienda2.Size = new Size(180, 110);
            tarjetaTienda2.TabIndex = 19;
            tarjetaTienda2.TamañoImagen = new Size(0, 0);
            tarjetaTienda2.Text = "tarjetaTienda2";
            tarjetaTienda2.CheckedChanged += tarjetaTienda2_CheckedChanged;
            // 
            // tarjetaTienda3
            // 
            tarjetaTienda3.BackColor = Color.Transparent;
            tarjetaTienda3.BackgroundImageLayout = ImageLayout.None;
            tarjetaTienda3.ColorBorde = Color.FromArgb(220, 224, 230);
            tarjetaTienda3.ColorCheck = Color.FromArgb(13, 110, 253);
            tarjetaTienda3.Imagen = Properties.Resources.GCM1;
            tarjetaTienda3.Location = new Point(571, 2);
            tarjetaTienda3.MargenImagen = 8;
            tarjetaTienda3.Margin = new Padding(3, 2, 3, 2);
            tarjetaTienda3.MinimumSize = new Size(35, 22);
            tarjetaTienda3.MostrarBorde = false;
            tarjetaTienda3.MostrarSeparador = true;
            tarjetaTienda3.Name = "tarjetaTienda3";
            tarjetaTienda3.Seleccionado = true;
            tarjetaTienda3.Size = new Size(180, 110);
            tarjetaTienda3.TabIndex = 20;
            tarjetaTienda3.TamañoImagen = new Size(0, 0);
            tarjetaTienda3.Text = "tarjetaTienda3";
            tarjetaTienda3.CheckedChanged += tarjetaTienda3_CheckedChanged;
            // 
            // LABEL
            // 
            LABEL.AutoSize = true;
            LABEL.BackColor = Color.Transparent;
            LABEL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL.ForeColor = Color.Blue;
            LABEL.Location = new Point(275, 9);
            LABEL.Name = "LABEL";
            LABEL.Size = new Size(345, 20);
            LABEL.TabIndex = 0;
            LABEL.Text = "TU COMPARADOR DE PRECIOS EN NICARAGUA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(262, 30);
            label1.Name = "label1";
            label1.Size = new Size(469, 41);
            label1.TabIndex = 1;
            label1.Text = "ENCUENTRA EL MEJOR PRECIO ";
            label1.Click += label1_Click_1;
            // 
            // barraBusqueda1
            // 
            barraBusqueda1.Anchor = AnchorStyles.None;
            barraBusqueda1.BackColor = Color.Transparent;
            barraBusqueda1.BackgroundImageLayout = ImageLayout.Stretch;
            barraBusqueda1.ColorBoton = Color.FromArgb(13, 110, 253);
            barraBusqueda1.Cursor = Cursors.IBeam;
            barraBusqueda1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            barraBusqueda1.ImeMode = ImeMode.Off;
            barraBusqueda1.Location = new Point(182, -2);
            barraBusqueda1.Margin = new Padding(3, 2, 3, 2);
            barraBusqueda1.MinimumSize = new Size(175, 30);
            barraBusqueda1.Name = "barraBusqueda1";
            barraBusqueda1.PlaceholderText = "¿Qué producto estás buscando?";
            barraBusqueda1.Size = new Size(924, 30);
            barraBusqueda1.TabIndex = 22;
            barraBusqueda1.BuscarClicked += barraBusqueda1_BuscarClicked_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(276, 63);
            label2.Name = "label2";
            label2.Size = new Size(303, 41);
            label2.TabIndex = 2;
            label2.Text = "EN UN SOLO LUGAR";
            // 
            // panel_Busqueda
            // 
            panel_Busqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_Busqueda.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_07_at_3_21_22_PM;
            panel_Busqueda.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Busqueda.Controls.Add(pictureBox2);
            panel_Busqueda.Controls.Add(panel1);
            panel_Busqueda.Controls.Add(panel6);
            panel_Busqueda.Location = new Point(-3, 0);
            panel_Busqueda.Margin = new Padding(3, 2, 3, 2);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new Size(1271, 143);
            panel_Busqueda.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.LOGO_222;
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(LABEL);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 143);
            panel1.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(40, 106);
            label11.Name = "label11";
            label11.Size = new Size(176, 13);
            label11.TabIndex = 9;
            label11.Text = "---- COMPARA. ELIGE. AHORRA ---";
            label11.Click += label11_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(lbl_busquedas_restantes);
            panel6.Controls.Add(boton_usuario);
            panel6.Controls.Add(botonMenu6);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(833, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(438, 143);
            panel6.TabIndex = 24;
            // 
            // botonMenu6
            // 
            botonMenu6.Anchor = AnchorStyles.None;
            botonMenu6.AutoColorearIconoBlanco = true;
            botonMenu6.AutoEscalarImagen = true;
            botonMenu6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botonMenu6.BackColor = Color.Transparent;
            botonMenu6.BorderRadius = 18;
            botonMenu6.ColorHover = Color.FromArgb(13, 110, 253);
            botonMenu6.ColorTextoNormal = Color.FromArgb(70, 70, 70);
            botonMenu6.EsSeleccionado = false;
            botonMenu6.FlatAppearance.BorderSize = 0;
            botonMenu6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonMenu6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonMenu6.FlatStyle = FlatStyle.Flat;
            botonMenu6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            botonMenu6.ForeColor = Color.FromArgb(70, 70, 70);
            botonMenu6.Image = Properties.Resources.vip;
            botonMenu6.Location = new Point(266, 39);
            botonMenu6.MargenImagenIzquierda = 15;
            botonMenu6.Margin = new Padding(3, 2, 3, 2);
            botonMenu6.Name = "botonMenu6";
            botonMenu6.PorcentajeEscalaImagen = 50;
            botonMenu6.Size = new Size(169, 36);
            botonMenu6.TabIndex = 23;
            botonMenu6.Text = "Premium";
            botonMenu6.TextAlign = ContentAlignment.MiddleRight;
            botonMenu6.UseVisualStyleBackColor = false;
            botonMenu6.Click += botonMenu6_Click_1;
            // 
            // contenedor_categorias_tabla
            // 
            contenedor_categorias_tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contenedor_categorias_tabla.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contenedor_categorias_tabla.BackColor = Color.Transparent;
            contenedor_categorias_tabla.BorderStyle = BorderStyle.Fixed3D;
            contenedor_categorias_tabla.Controls.Add(label_txt_compare);
            contenedor_categorias_tabla.Controls.Add(panel4);
            contenedor_categorias_tabla.Controls.Add(label_producto_busqueda);
            contenedor_categorias_tabla.Controls.Add(panel3);
            contenedor_categorias_tabla.Controls.Add(barraBusqueda1);
            contenedor_categorias_tabla.Location = new Point(-3, 148);
            contenedor_categorias_tabla.Name = "contenedor_categorias_tabla";
            contenedor_categorias_tabla.Size = new Size(1268, 527);
            contenedor_categorias_tabla.TabIndex = 27;
            // 
            // label_txt_compare
            // 
            label_txt_compare.AutoSize = true;
            label_txt_compare.BackColor = Color.Transparent;
            label_txt_compare.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_txt_compare.ForeColor = Color.Indigo;
            label_txt_compare.Location = new Point(103, 163);
            label_txt_compare.Name = "label_txt_compare";
            label_txt_compare.Size = new Size(306, 30);
            label_txt_compare.TabIndex = 25;
            label_txt_compare.Text = "Compare: Los Mejores Precios";
            label_txt_compare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.AutoScroll = true;
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Controls.Add(TABLAPRODUCTOS);
            panel4.Location = new Point(3, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(1258, 324);
            panel4.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.43021F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.56979F));
            tableLayoutPanel1.Controls.Add(lbl_Compare_sicsa, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_Compare_gcm, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox4, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl_Compare_gallo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(464, 324);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.el_gallo_mas_gallo_nuevo;
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 110);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(103, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.LOGO_222;
            pictureBox4.Location = new Point(4, 218);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(103, 93);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // TABLAPRODUCTOS
            // 
            TABLAPRODUCTOS.BackgroundColor = SystemColors.ButtonFace;
            TABLAPRODUCTOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABLAPRODUCTOS.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio, Tienda });
            TABLAPRODUCTOS.Dock = DockStyle.Right;
            TABLAPRODUCTOS.Location = new Point(470, 0);
            TABLAPRODUCTOS.Name = "TABLAPRODUCTOS";
            TABLAPRODUCTOS.RightToLeft = RightToLeft.No;
            TABLAPRODUCTOS.RowHeadersWidth = 51;
            TABLAPRODUCTOS.ScrollBars = ScrollBars.Vertical;
            TABLAPRODUCTOS.Size = new Size(788, 324);
            TABLAPRODUCTOS.TabIndex = 0;
            TABLAPRODUCTOS.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 307;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 306;
            // 
            // Tienda
            // 
            Tienda.HeaderText = "Tienda";
            Tienda.MinimumWidth = 6;
            Tienda.Name = "Tienda";
            Tienda.Width = 307;
            // 
            // label_producto_busqueda
            // 
            label_producto_busqueda.AutoSize = true;
            label_producto_busqueda.BackColor = Color.Transparent;
            label_producto_busqueda.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_producto_busqueda.ForeColor = Color.Indigo;
            label_producto_busqueda.Location = new Point(820, 163);
            label_producto_busqueda.Name = "label_producto_busqueda";
            label_producto_busqueda.Size = new Size(141, 30);
            label_producto_busqueda.TabIndex = 24;
            label_producto_busqueda.Text = "Mas Buscado";
            label_producto_busqueda.TextAlign = ContentAlignment.MiddleCenter;
            label_producto_busqueda.Click += label_producto_busqueda_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(webView21);
            panel3.Controls.Add(tarjetaTienda1);
            panel3.Controls.Add(tarjetaTienda2);
            panel3.Controls.Add(tarjetaTienda3);
            panel3.Location = new Point(13, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(1240, 120);
            panel3.TabIndex = 21;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(877, 48);
            webView21.Margin = new Padding(3, 2, 3, 2);
            webView21.Name = "webView21";
            webView21.Size = new Size(82, 22);
            webView21.TabIndex = 21;
            webView21.ZoomFactor = 1D;
            // 
            // lbl_Compare_gallo
            // 
            lbl_Compare_gallo.AutoSize = true;
            lbl_Compare_gallo.BackColor = Color.Transparent;
            lbl_Compare_gallo.Dock = DockStyle.Fill;
            lbl_Compare_gallo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Compare_gallo.ForeColor = Color.FromArgb(0, 0, 64);
            lbl_Compare_gallo.Location = new Point(113, 0);
            lbl_Compare_gallo.Name = "lbl_Compare_gallo";
            lbl_Compare_gallo.Size = new Size(348, 108);
            lbl_Compare_gallo.TabIndex = 10;
            lbl_Compare_gallo.Text = "Test Producto C$ 550";
            lbl_Compare_gallo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Compare_gcm
            // 
            lbl_Compare_gcm.AutoSize = true;
            lbl_Compare_gcm.BackColor = Color.Transparent;
            lbl_Compare_gcm.Dock = DockStyle.Fill;
            lbl_Compare_gcm.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Compare_gcm.ForeColor = Color.FromArgb(0, 0, 64);
            lbl_Compare_gcm.Location = new Point(113, 108);
            lbl_Compare_gcm.Name = "lbl_Compare_gcm";
            lbl_Compare_gcm.Size = new Size(348, 108);
            lbl_Compare_gcm.TabIndex = 29;
            lbl_Compare_gcm.Text = "Test Producto C$ 850";
            lbl_Compare_gcm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Compare_sicsa
            // 
            lbl_Compare_sicsa.AutoSize = true;
            lbl_Compare_sicsa.BackColor = Color.Transparent;
            lbl_Compare_sicsa.Dock = DockStyle.Fill;
            lbl_Compare_sicsa.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Compare_sicsa.ForeColor = Color.FromArgb(0, 0, 64);
            lbl_Compare_sicsa.Location = new Point(113, 216);
            lbl_Compare_sicsa.Name = "lbl_Compare_sicsa";
            lbl_Compare_sicsa.Size = new Size(348, 108);
            lbl_Compare_sicsa.TabIndex = 30;
            lbl_Compare_sicsa.Text = "Test Producto C$ 1120";
            lbl_Compare_sicsa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_busquedas_restantes
            // 
            lbl_busquedas_restantes.AutoSize = true;
            lbl_busquedas_restantes.BackColor = Color.WhiteSmoke;
            lbl_busquedas_restantes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_busquedas_restantes.ForeColor = Color.BlueViolet;
            lbl_busquedas_restantes.Location = new Point(6, 15);
            lbl_busquedas_restantes.Name = "lbl_busquedas_restantes";
            lbl_busquedas_restantes.Size = new Size(89, 60);
            lbl_busquedas_restantes.TabIndex = 10;
            lbl_busquedas_restantes.Text = "Busquedas \r\nRestantes\r\n (7)";
            lbl_busquedas_restantes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_07_at_12_37_13_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1264, 681);
            Controls.Add(contenedor_categorias_tabla);
            Controls.Add(panel_Busqueda);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Inicio_Load;
            panel_Busqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            contenedor_categorias_tabla.ResumeLayout(false);
            contenedor_categorias_tabla.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)TABLAPRODUCTOS).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BotonMenu boton_usuario;
        private TarjetaTienda tarjetaTienda1;
        private TarjetaTienda tarjetaTienda2;
        private TarjetaTienda tarjetaTienda3;
        private Label LABEL;
        private Label label1;
        private BarraBusqueda barraBusqueda1;
        private Label label2;
        private Panel panel_Busqueda;
        private Panel contenedor_categorias_tabla;
        private Panel panel3;
        private DataGridView TABLAPRODUCTOS;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Tienda;
        private Panel panel4;
        private Label label_producto_busqueda;
        private BotonMenu botonMenu6;
        private Panel panel6;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label11;
        private TarjetaResultadoComparacion tarjetaResultadoComparacion1;
        private PictureBox pictureBox2;
        internal Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_txt_compare;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lbl_busquedas_restantes;
        private Label lbl_Compare_sicsa;
        private Label lbl_Compare_gcm;
        private Label lbl_Compare_gallo;
    }
}