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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label11 = new Label();
            lbl_busquedas_restantes = new Label();
            contenedor_categorias_tabla = new Panel();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label_txt_compare = new Label();
            panel4 = new Panel();
            tablaResultados1 = new TablaResultados();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label_producto_busqueda = new Label();
            panel3 = new Panel();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            panel_Busqueda.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            contenedor_categorias_tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaResultados1).BeginInit();
            panel3.SuspendLayout();
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
            boton_usuario.Location = new Point(298, 12);
            boton_usuario.MargenImagenIzquierda = 15;
            boton_usuario.Name = "boton_usuario";
            boton_usuario.PorcentajeEscalaImagen = 50;
            boton_usuario.Size = new Size(190, 48);
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
            tarjetaTienda1.Location = new Point(409, 3);
            tarjetaTienda1.MargenImagen = 8;
            tarjetaTienda1.MinimumSize = new Size(40, 29);
            tarjetaTienda1.MostrarBorde = false;
            tarjetaTienda1.MostrarSeparador = true;
            tarjetaTienda1.Name = "tarjetaTienda1";
            tarjetaTienda1.Seleccionado = true;
            tarjetaTienda1.Size = new Size(206, 147);
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
            tarjetaTienda2.Location = new Point(632, 3);
            tarjetaTienda2.MargenImagen = 8;
            tarjetaTienda2.MinimumSize = new Size(40, 29);
            tarjetaTienda2.MostrarBorde = false;
            tarjetaTienda2.MostrarSeparador = true;
            tarjetaTienda2.Name = "tarjetaTienda2";
            tarjetaTienda2.Seleccionado = true;
            tarjetaTienda2.Size = new Size(206, 147);
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
            tarjetaTienda3.Location = new Point(869, 3);
            tarjetaTienda3.MargenImagen = 8;
            tarjetaTienda3.MinimumSize = new Size(40, 29);
            tarjetaTienda3.MostrarBorde = false;
            tarjetaTienda3.MostrarSeparador = true;
            tarjetaTienda3.Name = "tarjetaTienda3";
            tarjetaTienda3.Seleccionado = true;
            tarjetaTienda3.Size = new Size(206, 147);
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
            LABEL.Location = new Point(314, 12);
            LABEL.Name = "LABEL";
            LABEL.Size = new Size(419, 25);
            LABEL.TabIndex = 0;
            LABEL.Text = "TU COMPARADOR DE PRECIOS EN NICARAGUA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(299, 40);
            label1.Name = "label1";
            label1.Size = new Size(575, 50);
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
            barraBusqueda1.Location = new Point(282, -2);
            barraBusqueda1.MinimumSize = new Size(200, 40);
            barraBusqueda1.Name = "barraBusqueda1";
            barraBusqueda1.PlaceholderText = "¿Qué producto estás buscando?";
            barraBusqueda1.Size = new Size(1106, 61);
            barraBusqueda1.TabIndex = 22;
            barraBusqueda1.BuscarClicked += barraBusqueda1_BuscarClicked_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(315, 84);
            label2.Name = "label2";
            label2.Size = new Size(373, 50);
            label2.TabIndex = 2;
            label2.Text = "EN UN SOLO LUGAR";
            // 
            // panel_Busqueda
            // 
            panel_Busqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_Busqueda.BackgroundImage = (Image)resources.GetObject("panel_Busqueda.BackgroundImage");
            panel_Busqueda.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Busqueda.Controls.Add(panel6);
            panel_Busqueda.Controls.Add(pictureBox2);
            panel_Busqueda.Controls.Add(panel1);
            panel_Busqueda.Location = new Point(-3, 0);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new Size(1620, 226);
            panel_Busqueda.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(boton_usuario);
            panel6.Controls.Add(botonMenu6);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1119, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(501, 226);
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
            botonMenu6.Location = new Point(99, 12);
            botonMenu6.MargenImagenIzquierda = 15;
            botonMenu6.Name = "botonMenu6";
            botonMenu6.PorcentajeEscalaImagen = 50;
            botonMenu6.Size = new Size(193, 48);
            botonMenu6.TabIndex = 23;
            botonMenu6.Text = "Premium";
            botonMenu6.TextAlign = ContentAlignment.MiddleLeft;
            botonMenu6.UseVisualStyleBackColor = false;
            botonMenu6.Click += botonMenu6_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.LOGO_222;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(290, 136);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 226);
            panel1.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(46, 141);
            label11.Name = "label11";
            label11.Size = new Size(216, 16);
            label11.TabIndex = 9;
            label11.Text = "---- COMPARA. ELIGE. AHORRA ---";
            label11.Click += label11_Click;
            // 
            // lbl_busquedas_restantes
            // 
            lbl_busquedas_restantes.AutoSize = true;
            lbl_busquedas_restantes.BackColor = Color.Transparent;
            lbl_busquedas_restantes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_busquedas_restantes.ForeColor = Color.BlueViolet;
            lbl_busquedas_restantes.Location = new Point(1305, 85);
            lbl_busquedas_restantes.Name = "lbl_busquedas_restantes";
            lbl_busquedas_restantes.Size = new Size(109, 75);
            lbl_busquedas_restantes.TabIndex = 10;
            lbl_busquedas_restantes.Text = "Busquedas \r\nRestantes\r\n (7)";
            lbl_busquedas_restantes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contenedor_categorias_tabla
            // 
            contenedor_categorias_tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contenedor_categorias_tabla.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contenedor_categorias_tabla.BackColor = Color.Transparent;
            contenedor_categorias_tabla.BorderStyle = BorderStyle.Fixed3D;
            contenedor_categorias_tabla.Controls.Add(barraBusqueda1);
            contenedor_categorias_tabla.Controls.Add(webView21);
            contenedor_categorias_tabla.Controls.Add(label_txt_compare);
            contenedor_categorias_tabla.Controls.Add(panel4);
            contenedor_categorias_tabla.Controls.Add(label_producto_busqueda);
            contenedor_categorias_tabla.Controls.Add(panel3);
            contenedor_categorias_tabla.Location = new Point(-3, 197);
            contenedor_categorias_tabla.Margin = new Padding(3, 4, 3, 4);
            contenedor_categorias_tabla.Name = "contenedor_categorias_tabla";
            contenedor_categorias_tabla.Size = new Size(1616, 755);
            contenedor_categorias_tabla.TabIndex = 27;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(1431, 255);
            webView21.Name = "webView21";
            webView21.Size = new Size(94, 29);
            webView21.TabIndex = 21;
            webView21.ZoomFactor = 1D;
            // 
            // label_txt_compare
            // 
            label_txt_compare.AutoSize = true;
            label_txt_compare.BackColor = Color.Transparent;
            label_txt_compare.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_txt_compare.ForeColor = Color.Indigo;
            label_txt_compare.Location = new Point(117, 247);
            label_txt_compare.Name = "label_txt_compare";
            label_txt_compare.Size = new Size(389, 37);
            label_txt_compare.TabIndex = 25;
            label_txt_compare.Text = "Compare los Mejores Precios";
            label_txt_compare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.AutoScroll = true;
            panel4.Controls.Add(tablaResultados1);
            panel4.Location = new Point(87, 288);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1438, 432);
            panel4.TabIndex = 22;
            // 
            // tablaResultados1
            // 
            tablaResultados1.AllowUserToAddRows = false;
            tablaResultados1.AllowUserToDeleteRows = false;
            tablaResultados1.AllowUserToResizeColumns = false;
            tablaResultados1.AllowUserToResizeRows = false;
            tablaResultados1.BackgroundColor = Color.White;
            tablaResultados1.BorderStyle = BorderStyle.None;
            tablaResultados1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaResultados1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle7.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            tablaResultados1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            tablaResultados1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaResultados1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            tablaResultados1.DefaultCellStyle = dataGridViewCellStyle8;
            tablaResultados1.EnableHeadersVisualStyles = false;
            tablaResultados1.GridColor = Color.FromArgb(226, 232, 240);
            tablaResultados1.Location = new Point(39, 3);
            tablaResultados1.MultiSelect = false;
            tablaResultados1.Name = "tablaResultados1";
            tablaResultados1.ReadOnly = true;
            tablaResultados1.RightToLeft = RightToLeft.No;
            tablaResultados1.RowHeadersVisible = false;
            tablaResultados1.RowHeadersWidth = 51;
            tablaResultados1.RowTemplate.Height = 72;
            tablaResultados1.ScrollBars = ScrollBars.Vertical;
            tablaResultados1.Size = new Size(1408, 418);
            tablaResultados1.TabIndex = 3;
            tablaResultados1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Precio";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tienda";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn3.Width = 210;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Disponibilidad";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn4.Width = 170;
            // 
            // label_producto_busqueda
            // 
            label_producto_busqueda.AutoSize = true;
            label_producto_busqueda.BackColor = Color.Transparent;
            label_producto_busqueda.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_producto_busqueda.ForeColor = Color.Indigo;
            label_producto_busqueda.Location = new Point(942, 235);
            label_producto_busqueda.Name = "label_producto_busqueda";
            label_producto_busqueda.Size = new Size(184, 37);
            label_producto_busqueda.TabIndex = 24;
            label_producto_busqueda.Text = "Mas Buscado";
            label_producto_busqueda.TextAlign = ContentAlignment.MiddleCenter;
            label_producto_busqueda.Click += label_producto_busqueda_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lbl_busquedas_restantes);
            panel3.Controls.Add(tarjetaTienda1);
            panel3.Controls.Add(tarjetaTienda2);
            panel3.Controls.Add(tarjetaTienda3);
            panel3.Location = new Point(99, 71);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1417, 160);
            panel3.TabIndex = 21;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewImageColumn1.HeaderText = "Foto";
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.MinimumWidth = 6;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Width = 90;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewImageColumn2.HeaderText = "Foto";
            dataGridViewImageColumn2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn2.MinimumWidth = 6;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.ReadOnly = true;
            dataGridViewImageColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn17.HeaderText = "Nombre";
            dataGridViewTextBoxColumn17.MinimumWidth = 6;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Tienda";
            dataGridViewTextBoxColumn18.MinimumWidth = 6;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            dataGridViewTextBoxColumn18.Width = 220;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.HeaderText = "Precio";
            dataGridViewTextBoxColumn19.MinimumWidth = 6;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.Width = 170;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.HeaderText = "Disponibilidad";
            dataGridViewTextBoxColumn20.MinimumWidth = 6;
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            dataGridViewTextBoxColumn20.Width = 170;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn10.FillWeight = 40F;
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 170;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn12.FillWeight = 30F;
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.FillWeight = 40F;
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 170;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.FillWeight = 30F;
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_07_at_12_37_13_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1612, 962);
            Controls.Add(contenedor_categorias_tabla);
            Controls.Add(panel_Busqueda);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Inicio_Load;
            panel_Busqueda.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contenedor_categorias_tabla.ResumeLayout(false);
            contenedor_categorias_tabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaResultados1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Label label_producto_busqueda;
        private BotonMenu botonMenu6;
        private Panel panel6;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label11;
        private PictureBox pictureBox2;
        internal Panel panel1;
        private Label label_txt_compare;
        private Label lbl_busquedas_restantes;
        private Panel panel4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private TablaResultados tablaResultados1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}