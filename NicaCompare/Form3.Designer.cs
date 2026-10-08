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
            panel1 = new Panel();
            panel5 = new Panel();
            btn_Usuario_2 = new BotonMenu();
            Menu = new BotonMenu();
            botonMenu1 = new BotonMenu();
            btn_cerar_sesion = new BotonMenu();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            boton_usuario = new BotonMenu();
            tarjetaTienda1 = new TarjetaTienda();
            tarjetaTienda2 = new TarjetaTienda();
            tarjetaTienda3 = new TarjetaTienda();
            LABEL = new Label();
            label1 = new Label();
            barraBusqueda1 = new BarraBusqueda();
            label2 = new Label();
            panel_Busqueda = new Panel();
            panel6 = new Panel();
            botonMenu6 = new BotonMenu();
            contenedor_categorias_tabla = new Panel();
            panel4 = new Panel();
            label_producto_busqueda = new Label();
            panel2 = new Panel();
            TABLAPRODUCTOS = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Tienda = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_Busqueda.SuspendLayout();
            panel6.SuspendLayout();
            contenedor_categorias_tabla.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TABLAPRODUCTOS).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_04_at_1_50_14_PM_upscayl_5x_digital_art_4x;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btn_cerar_sesion);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 681);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(btn_Usuario_2);
            panel5.Controls.Add(Menu);
            panel5.Controls.Add(botonMenu1);
            panel5.Location = new Point(3, 213);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 201);
            panel5.TabIndex = 21;
            // 
            // btn_Usuario_2
            // 
            btn_Usuario_2.AutoColorearIconoBlanco = true;
            btn_Usuario_2.AutoEscalarImagen = true;
            btn_Usuario_2.BackColor = Color.Transparent;
            btn_Usuario_2.BorderRadius = 18;
            btn_Usuario_2.ColorHover = Color.FromArgb(13, 110, 253);
            btn_Usuario_2.ColorTextoNormal = Color.FromArgb(70, 70, 70);
            btn_Usuario_2.Dock = DockStyle.Top;
            btn_Usuario_2.EsSeleccionado = false;
            btn_Usuario_2.FlatAppearance.BorderSize = 0;
            btn_Usuario_2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Usuario_2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Usuario_2.FlatStyle = FlatStyle.Flat;
            btn_Usuario_2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btn_Usuario_2.ForeColor = Color.FromArgb(70, 70, 70);
            btn_Usuario_2.Image = Properties.Resources.usuario;
            btn_Usuario_2.Location = new Point(0, 0);
            btn_Usuario_2.MargenImagenIzquierda = 15;
            btn_Usuario_2.Margin = new Padding(3, 2, 3, 2);
            btn_Usuario_2.Name = "btn_Usuario_2";
            btn_Usuario_2.PorcentajeEscalaImagen = 50;
            btn_Usuario_2.Size = new Size(248, 40);
            btn_Usuario_2.TabIndex = 17;
            btn_Usuario_2.Text = "Perfil de Usuario";
            btn_Usuario_2.TextAlign = ContentAlignment.MiddleLeft;
            btn_Usuario_2.UseVisualStyleBackColor = false;
            btn_Usuario_2.Click += boton_usuario_Click;
            // 
            // Menu
            // 
            Menu.AutoColorearIconoBlanco = true;
            Menu.AutoEscalarImagen = true;
            Menu.BackColor = Color.Transparent;
            Menu.BorderRadius = 18;
            Menu.ColorHover = Color.FromArgb(13, 110, 253);
            Menu.ColorTextoNormal = Color.FromArgb(70, 70, 70);
            Menu.EsSeleccionado = false;
            Menu.FlatAppearance.BorderSize = 0;
            Menu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Menu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Menu.FlatStyle = FlatStyle.Flat;
            Menu.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Menu.ForeColor = Color.FromArgb(70, 70, 70);
            Menu.Image = (Image)resources.GetObject("Menu.Image");
            Menu.Location = new Point(9, 147);
            Menu.MargenImagenIzquierda = 15;
            Menu.Margin = new Padding(3, 2, 3, 2);
            Menu.Name = "Menu";
            Menu.PorcentajeEscalaImagen = 50;
            Menu.Size = new Size(221, 40);
            Menu.TabIndex = 10;
            Menu.Text = "Favorito";
            Menu.TextAlign = ContentAlignment.MiddleLeft;
            Menu.UseVisualStyleBackColor = false;
            Menu.Visible = false;
            Menu.Click += botonMenu1_Click;
            // 
            // botonMenu1
            // 
            botonMenu1.AutoColorearIconoBlanco = true;
            botonMenu1.AutoEscalarImagen = true;
            botonMenu1.BackColor = Color.Transparent;
            botonMenu1.BorderRadius = 18;
            botonMenu1.ColorHover = Color.FromArgb(13, 110, 253);
            botonMenu1.ColorTextoNormal = Color.FromArgb(70, 70, 70);
            botonMenu1.EsSeleccionado = false;
            botonMenu1.FlatAppearance.BorderSize = 0;
            botonMenu1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botonMenu1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botonMenu1.FlatStyle = FlatStyle.Flat;
            botonMenu1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            botonMenu1.ForeColor = Color.FromArgb(70, 70, 70);
            botonMenu1.Image = (Image)resources.GetObject("botonMenu1.Image");
            botonMenu1.Location = new Point(9, 81);
            botonMenu1.MargenImagenIzquierda = 15;
            botonMenu1.Margin = new Padding(3, 2, 3, 2);
            botonMenu1.Name = "botonMenu1";
            botonMenu1.PorcentajeEscalaImagen = 50;
            botonMenu1.Size = new Size(221, 40);
            botonMenu1.TabIndex = 18;
            botonMenu1.Text = "Compara";
            botonMenu1.TextAlign = ContentAlignment.MiddleLeft;
            botonMenu1.UseVisualStyleBackColor = false;
            botonMenu1.Visible = false;
            // 
            // btn_cerar_sesion
            // 
            btn_cerar_sesion.AutoColorearIconoBlanco = true;
            btn_cerar_sesion.AutoEscalarImagen = true;
            btn_cerar_sesion.BackColor = Color.Transparent;
            btn_cerar_sesion.BorderRadius = 18;
            btn_cerar_sesion.ColorHover = Color.FromArgb(13, 110, 253);
            btn_cerar_sesion.ColorTextoNormal = Color.FromArgb(70, 70, 70);
            btn_cerar_sesion.Dock = DockStyle.Bottom;
            btn_cerar_sesion.EsSeleccionado = false;
            btn_cerar_sesion.FlatAppearance.BorderSize = 0;
            btn_cerar_sesion.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_cerar_sesion.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_cerar_sesion.FlatStyle = FlatStyle.Flat;
            btn_cerar_sesion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btn_cerar_sesion.ForeColor = Color.FromArgb(70, 70, 70);
            btn_cerar_sesion.Image = (Image)resources.GetObject("btn_cerar_sesion.Image");
            btn_cerar_sesion.Location = new Point(0, 641);
            btn_cerar_sesion.MargenImagenIzquierda = 15;
            btn_cerar_sesion.Margin = new Padding(3, 2, 3, 2);
            btn_cerar_sesion.Name = "btn_cerar_sesion";
            btn_cerar_sesion.PorcentajeEscalaImagen = 50;
            btn_cerar_sesion.Size = new Size(254, 40);
            btn_cerar_sesion.TabIndex = 19;
            btn_cerar_sesion.Text = "Cerrar sesion";
            btn_cerar_sesion.TextAlign = ContentAlignment.MiddleLeft;
            btn_cerar_sesion.UseVisualStyleBackColor = false;
            btn_cerar_sesion.Click += btn_cerar_sesion_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(46, 83);
            label11.Name = "label11";
            label11.Size = new Size(176, 13);
            label11.TabIndex = 9;
            label11.Text = "---- COMPARA. ELIGE. AHORRA ---";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.LOGO_222;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            boton_usuario.Location = new Point(3, 35);
            boton_usuario.MargenImagenIzquierda = 15;
            boton_usuario.Margin = new Padding(3, 2, 3, 2);
            boton_usuario.Name = "boton_usuario";
            boton_usuario.PorcentajeEscalaImagen = 50;
            boton_usuario.Size = new Size(166, 36);
            boton_usuario.TabIndex = 16;
            boton_usuario.Text = "Inicio de Sesión";
            boton_usuario.TextAlign = ContentAlignment.MiddleLeft;
            boton_usuario.UseVisualStyleBackColor = false;
            boton_usuario.Click += boton_usuario_Click;
            // 
            // tarjetaTienda1
            // 
            tarjetaTienda1.BackColor = Color.Transparent;
            tarjetaTienda1.BackgroundImage = Properties.Resources._2dd8d181507843_Y3JvcCw4MTAsNjMzLDAsMA;
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
            LABEL.Location = new Point(28, 35);
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
            label1.Location = new Point(20, 61);
            label1.Name = "label1";
            label1.Size = new Size(469, 41);
            label1.TabIndex = 1;
            label1.Text = "ENCUENTRA EL MEJOR PRECIO ";
            // 
            // barraBusqueda1
            // 
            barraBusqueda1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            barraBusqueda1.BackColor = Color.Transparent;
            barraBusqueda1.BackgroundImageLayout = ImageLayout.Stretch;
            barraBusqueda1.ColorBoton = Color.FromArgb(13, 110, 253);
            barraBusqueda1.Cursor = Cursors.IBeam;
            barraBusqueda1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            barraBusqueda1.ImeMode = ImeMode.Off;
            barraBusqueda1.Location = new Point(168, 163);
            barraBusqueda1.Margin = new Padding(3, 2, 3, 2);
            barraBusqueda1.MinimumSize = new Size(175, 30);
            barraBusqueda1.Name = "barraBusqueda1";
            barraBusqueda1.PlaceholderText = "¿Qué producto estás buscando?";
            barraBusqueda1.Size = new Size(668, 30);
            barraBusqueda1.TabIndex = 22;
            barraBusqueda1.BuscarClicked += barraBusqueda1_BuscarClicked_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(20, 98);
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
            panel_Busqueda.Controls.Add(panel6);
            panel_Busqueda.Controls.Add(label2);
            panel_Busqueda.Controls.Add(barraBusqueda1);
            panel_Busqueda.Controls.Add(label1);
            panel_Busqueda.Controls.Add(LABEL);
            panel_Busqueda.Location = new Point(253, 0);
            panel_Busqueda.Margin = new Padding(3, 2, 3, 2);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new Size(1015, 208);
            panel_Busqueda.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(boton_usuario);
            panel6.Controls.Add(botonMenu6);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(842, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(173, 208);
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
            botonMenu6.Location = new Point(1, 83);
            botonMenu6.MargenImagenIzquierda = 15;
            botonMenu6.Margin = new Padding(3, 2, 3, 2);
            botonMenu6.Name = "botonMenu6";
            botonMenu6.PorcentajeEscalaImagen = 50;
            botonMenu6.Size = new Size(169, 36);
            botonMenu6.TabIndex = 23;
            botonMenu6.Text = "Premium";
            botonMenu6.TextAlign = ContentAlignment.MiddleLeft;
            botonMenu6.UseVisualStyleBackColor = false;
            botonMenu6.Click += botonMenu6_Click_1;
            // 
            // contenedor_categorias_tabla
            // 
            contenedor_categorias_tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contenedor_categorias_tabla.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contenedor_categorias_tabla.BorderStyle = BorderStyle.Fixed3D;
            contenedor_categorias_tabla.Controls.Add(panel4);
            contenedor_categorias_tabla.Controls.Add(panel3);
            contenedor_categorias_tabla.Location = new Point(259, 213);
            contenedor_categorias_tabla.Name = "contenedor_categorias_tabla";
            contenedor_categorias_tabla.Size = new Size(998, 462);
            contenedor_categorias_tabla.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.AutoScroll = true;
            panel4.Controls.Add(label_producto_busqueda);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(14, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 329);
            panel4.TabIndex = 22;
            // 
            // label_producto_busqueda
            // 
            label_producto_busqueda.AutoSize = true;
            label_producto_busqueda.BackColor = Color.Transparent;
            label_producto_busqueda.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_producto_busqueda.ForeColor = Color.Indigo;
            label_producto_busqueda.Location = new Point(413, 2);
            label_producto_busqueda.Name = "label_producto_busqueda";
            label_producto_busqueda.Size = new Size(141, 30);
            label_producto_busqueda.TabIndex = 24;
            label_producto_busqueda.Text = "Mas Buscado";
            label_producto_busqueda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(TABLAPRODUCTOS);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 291);
            panel2.TabIndex = 0;
            // 
            // TABLAPRODUCTOS
            // 
            TABLAPRODUCTOS.BackgroundColor = SystemColors.ButtonFace;
            TABLAPRODUCTOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABLAPRODUCTOS.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio, Tienda });
            TABLAPRODUCTOS.Dock = DockStyle.Fill;
            TABLAPRODUCTOS.Location = new Point(0, 0);
            TABLAPRODUCTOS.Name = "TABLAPRODUCTOS";
            TABLAPRODUCTOS.RightToLeft = RightToLeft.No;
            TABLAPRODUCTOS.Size = new Size(982, 291);
            TABLAPRODUCTOS.TabIndex = 0;
            TABLAPRODUCTOS.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Producto";
            Nombre.Name = "Nombre";
            Nombre.Width = 307;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 306;
            // 
            // Tienda
            // 
            Tienda.HeaderText = "Tienda";
            Tienda.Name = "Tienda";
            Tienda.Width = 307;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(tarjetaTienda1);
            panel3.Controls.Add(tarjetaTienda2);
            panel3.Controls.Add(tarjetaTienda3);
            panel3.Location = new Point(12, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(984, 120);
            panel3.TabIndex = 21;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            CausesValidation = false;
            ClientSize = new Size(1264, 681);
            Controls.Add(contenedor_categorias_tabla);
            Controls.Add(panel_Busqueda);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Inicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_Busqueda.ResumeLayout(false);
            panel_Busqueda.PerformLayout();
            panel6.ResumeLayout(false);
            contenedor_categorias_tabla.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TABLAPRODUCTOS).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label11;
        private BotonMenu Menu;
        private BotonMenu boton_usuario;
        private TarjetaTienda tarjetaTienda1;
        private TarjetaTienda tarjetaTienda2;
        private TarjetaTienda tarjetaTienda3;
        private Label LABEL;
        private Label label1;
        private BarraBusqueda barraBusqueda1;
        private Label label2;
        private Panel panel_Busqueda;
        private BotonMenu btn_Usuario_2;
        private BotonMenu btn_cerar_sesion;
        private BotonMenu botonMenu1;
        private Panel contenedor_categorias_tabla;
        private Panel panel3;
        private DataGridView TABLAPRODUCTOS;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Tienda;
        private Panel panel4;
        private Label label_producto_busqueda;
        private Panel panel2;
        private BotonMenu botonMenu6;
        private Panel panel5;
        private Panel panel6;
    }
}