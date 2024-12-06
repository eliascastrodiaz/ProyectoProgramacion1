namespace Almacén_Virtual_Proyect
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbcalmacen = new TabControl();
            tpRegistro = new TabPage();
            buttonSalir = new Button();
            txtMarca = new TextBox();
            label5 = new Label();
            txtIDproducto = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtCantidad = new TextBox();
            lblExistencia = new Label();
            txtProducto = new TextBox();
            lblProducto = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            btnNuevo = new Button();
            pictureBox1 = new PictureBox();
            btnRegistro = new Button();
            tpAlmacen = new TabPage();
            tsBoorartodo = new ToolStrip();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbBorrar = new ToolStripButton();
            tsBorrartodo = new ToolStripButton();
            dgvProducAlmacenados = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            imageList1 = new ImageList(components);
            label4 = new Label();
            txtBuscar = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            tpConsulta = new TabPage();
            rbMayores = new RadioButton();
            btnConsulta = new Button();
            txtConsultao = new TextBox();
            rbMenores = new RadioButton();
            dgvConsculta = new DataGridView();
            lblProductosComparacion = new Label();
            label8 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            epAdvertencia = new ErrorProvider(components);
            tbcalmacen.SuspendLayout();
            tpRegistro.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tpAlmacen.SuspendLayout();
            tsBoorartodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducAlmacenados).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsculta).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epAdvertencia).BeginInit();
            SuspendLayout();
            // 
            // tbcalmacen
            // 
            tbcalmacen.Controls.Add(tpRegistro);
            tbcalmacen.Controls.Add(tpAlmacen);
            tbcalmacen.Controls.Add(tpConsulta);
            tbcalmacen.Location = new Point(28, 12);
            tbcalmacen.Name = "tbcalmacen";
            tbcalmacen.SelectedIndex = 0;
            tbcalmacen.Size = new Size(1243, 594);
            tbcalmacen.TabIndex = 1;
            // 
            // tpRegistro
            // 
            tpRegistro.BackColor = Color.Silver;
            tpRegistro.Controls.Add(buttonSalir);
            tpRegistro.Controls.Add(txtMarca);
            tpRegistro.Controls.Add(label5);
            tpRegistro.Controls.Add(txtIDproducto);
            tpRegistro.Controls.Add(label2);
            tpRegistro.Controls.Add(txtPrecio);
            tpRegistro.Controls.Add(lblPrecio);
            tpRegistro.Controls.Add(txtCantidad);
            tpRegistro.Controls.Add(lblExistencia);
            tpRegistro.Controls.Add(txtProducto);
            tpRegistro.Controls.Add(lblProducto);
            tpRegistro.Controls.Add(panel2);
            tpRegistro.Controls.Add(panel3);
            tpRegistro.Location = new Point(4, 24);
            tpRegistro.Name = "tpRegistro";
            tpRegistro.Padding = new Padding(3);
            tpRegistro.Size = new Size(1235, 566);
            tpRegistro.TabIndex = 0;
            tpRegistro.Text = "Registro";
            tpRegistro.Click += tpRegistro_Click_2;
            // 
            // buttonSalir
            // 
            buttonSalir.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalir.Location = new Point(526, 379);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(85, 32);
            buttonSalir.TabIndex = 24;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // txtMarca
            // 
            txtMarca.Enabled = false;
            txtMarca.Location = new Point(306, 340);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(82, 23);
            txtMarca.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(306, 318);
            label5.Name = "label5";
            label5.Size = new Size(62, 22);
            label5.TabIndex = 22;
            label5.Text = "Marca";
            // 
            // txtIDproducto
            // 
            txtIDproducto.Enabled = false;
            txtIDproducto.Location = new Point(306, 269);
            txtIDproducto.Name = "txtIDproducto";
            txtIDproducto.Size = new Size(210, 23);
            txtIDproducto.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(306, 247);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 17;
            label2.Text = "ID producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(669, 269);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 23);
            txtPrecio.TabIndex = 16;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.Location = new Point(669, 247);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(121, 22);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "precio unidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(669, 207);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(102, 23);
            txtCantidad.TabIndex = 14;
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblExistencia.Location = new Point(669, 185);
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(94, 22);
            lblExistencia.TabIndex = 13;
            lblExistencia.Text = "Existencia";
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Location = new Point(306, 206);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(256, 23);
            txtProducto.TabIndex = 12;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblProducto.Location = new Point(306, 184);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(81, 22);
            lblProducto.TabIndex = 11;
            lblProducto.Text = "Producto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1229, 138);
            panel2.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(216, 138);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(242, 39);
            label1.Name = "label1";
            label1.Size = new Size(495, 55);
            label1.TabIndex = 0;
            label1.Text = "Registro de productos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(btnNuevo);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnRegistro);
            panel3.Location = new Point(0, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 431);
            panel3.TabIndex = 21;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = Color.DimGray;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(6, 88);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.DimGray;
            btnNuevo.FlatAppearance.BorderColor = Color.Red;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnNuevo.Location = new Point(0, 88);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(78, 0, 0, 0);
            btnNuevo.Size = new Size(219, 66);
            btnNuevo.TabIndex = 21;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.DimGray;
            btnRegistro.Dock = DockStyle.Top;
            btnRegistro.Enabled = false;
            btnRegistro.FlatAppearance.BorderColor = Color.Red;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistro.Location = new Point(0, 0);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Padding = new Padding(78, 0, 0, 0);
            btnRegistro.Size = new Size(219, 66);
            btnRegistro.TabIndex = 20;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // tpAlmacen
            // 
            tpAlmacen.BackColor = Color.Silver;
            tpAlmacen.Controls.Add(tsBoorartodo);
            tpAlmacen.Controls.Add(dgvProducAlmacenados);
            tpAlmacen.Controls.Add(btnBuscar);
            tpAlmacen.Controls.Add(label4);
            tpAlmacen.Controls.Add(txtBuscar);
            tpAlmacen.Controls.Add(panel1);
            tpAlmacen.Location = new Point(4, 24);
            tpAlmacen.Name = "tpAlmacen";
            tpAlmacen.Padding = new Padding(3);
            tpAlmacen.Size = new Size(1235, 566);
            tpAlmacen.TabIndex = 1;
            tpAlmacen.Text = "Almacén";
            // 
            // tsBoorartodo
            // 
            tsBoorartodo.ImageScalingSize = new Size(20, 20);
            tsBoorartodo.Items.AddRange(new ToolStripItem[] { tsbEditar, toolStripSeparator1, tsbBorrar, tsBorrartodo });
            tsBoorartodo.Location = new Point(3, 141);
            tsBoorartodo.Name = "tsBoorartodo";
            tsBoorartodo.RenderMode = ToolStripRenderMode.Professional;
            tsBoorartodo.Size = new Size(1229, 27);
            tsBoorartodo.TabIndex = 11;
            tsBoorartodo.Text = "toolStrip1";
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(24, 24);
            tsbEditar.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tsbBorrar
            // 
            tsbBorrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(24, 24);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsBorrartodo
            // 
            tsBorrartodo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBorrartodo.Image = (Image)resources.GetObject("tsBorrartodo.Image");
            tsBorrartodo.ImageTransparentColor = Color.Magenta;
            tsBorrartodo.Name = "tsBorrartodo";
            tsBorrartodo.Size = new Size(24, 24);
            tsBorrartodo.Text = "Borrar todo";
            tsBorrartodo.Click += tsBorrartodo_Click;
            // 
            // dgvProducAlmacenados
            // 
            dgvProducAlmacenados.AllowUserToAddRows = false;
            dgvProducAlmacenados.AllowUserToResizeColumns = false;
            dgvProducAlmacenados.AllowUserToResizeRows = false;
            dgvProducAlmacenados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducAlmacenados.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column1, Column4, Column5 });
            dgvProducAlmacenados.Location = new Point(94, 258);
            dgvProducAlmacenados.Name = "dgvProducAlmacenados";
            dgvProducAlmacenados.RowHeadersWidth = 51;
            dgvProducAlmacenados.RowTemplate.Height = 25;
            dgvProducAlmacenados.Size = new Size(756, 262);
            dgvProducAlmacenados.TabIndex = 10;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre del producto";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio Unidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Existencia";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Marca";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // btnBuscar
            // 
            btnBuscar.ImageKey = "buscar.png";
            btnBuscar.ImageList = imageList1;
            btnBuscar.Location = new Point(638, 214);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(31, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "buscar.png");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 218);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 13;
            label4.Text = "Buscar producto:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(263, 214);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(369, 23);
            txtBuscar.TabIndex = 12;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1229, 138);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(413, 38);
            label3.Name = "label3";
            label3.Size = new Size(211, 55);
            label3.TabIndex = 0;
            label3.Text = "Almacén";
            // 
            // tpConsulta
            // 
            tpConsulta.BackColor = Color.Silver;
            tpConsulta.Controls.Add(rbMayores);
            tpConsulta.Controls.Add(btnConsulta);
            tpConsulta.Controls.Add(txtConsultao);
            tpConsulta.Controls.Add(rbMenores);
            tpConsulta.Controls.Add(dgvConsculta);
            tpConsulta.Controls.Add(lblProductosComparacion);
            tpConsulta.Controls.Add(label8);
            tpConsulta.Controls.Add(label7);
            tpConsulta.Controls.Add(panel4);
            tpConsulta.Location = new Point(4, 24);
            tpConsulta.Name = "tpConsulta";
            tpConsulta.Padding = new Padding(3);
            tpConsulta.Size = new Size(1235, 566);
            tpConsulta.TabIndex = 2;
            tpConsulta.Text = "Consulta";
            // 
            // rbMayores
            // 
            rbMayores.AutoSize = true;
            rbMayores.Location = new Point(689, 366);
            rbMayores.Name = "rbMayores";
            rbMayores.Size = new Size(79, 19);
            rbMayores.TabIndex = 17;
            rbMayores.TabStop = true;
            rbMayores.Text = "Mayores a";
            rbMayores.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(689, 437);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(94, 28);
            btnConsulta.TabIndex = 16;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // txtConsultao
            // 
            txtConsultao.Location = new Point(689, 259);
            txtConsultao.Name = "txtConsultao";
            txtConsultao.Size = new Size(100, 23);
            txtConsultao.TabIndex = 15;
            // 
            // rbMenores
            // 
            rbMenores.AutoSize = true;
            rbMenores.Location = new Point(689, 330);
            rbMenores.Name = "rbMenores";
            rbMenores.Size = new Size(80, 19);
            rbMenores.TabIndex = 14;
            rbMenores.TabStop = true;
            rbMenores.Text = "Menores a";
            rbMenores.UseVisualStyleBackColor = true;
            // 
            // dgvConsculta
            // 
            dgvConsculta.AllowUserToAddRows = false;
            dgvConsculta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsculta.Location = new Point(40, 261);
            dgvConsculta.Name = "dgvConsculta";
            dgvConsculta.RowHeadersWidth = 51;
            dgvConsculta.RowTemplate.Height = 25;
            dgvConsculta.Size = new Size(620, 253);
            dgvConsculta.TabIndex = 13;
            // 
            // lblProductosComparacion
            // 
            lblProductosComparacion.AutoSize = true;
            lblProductosComparacion.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductosComparacion.Location = new Point(227, 198);
            lblProductosComparacion.Name = "lblProductosComparacion";
            lblProductosComparacion.Size = new Size(209, 19);
            lblProductosComparacion.TabIndex = 12;
            lblProductosComparacion.Text = "Productos de comparación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 237);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 262);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1229, 138);
            panel4.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 138);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(413, 38);
            label6.Name = "label6";
            label6.Size = new Size(211, 55);
            label6.TabIndex = 0;
            label6.Text = "Almacén";
            // 
            // epAdvertencia
            // 
            epAdvertencia.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 609);
            Controls.Add(tbcalmacen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Almacén Virtual";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            tbcalmacen.ResumeLayout(false);
            tpRegistro.ResumeLayout(false);
            tpRegistro.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tpAlmacen.ResumeLayout(false);
            tpAlmacen.PerformLayout();
            tsBoorartodo.ResumeLayout(false);
            tsBoorartodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducAlmacenados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tpConsulta.ResumeLayout(false);
            tpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsculta).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)epAdvertencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcalmacen;
        private TabPage tpRegistro;
        private TextBox txtMarca;
        private Label label5;
        private TextBox txtIDproducto;
        private Label label2;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtCantidad;
        private Label lblExistencia;
        private TextBox txtProducto;
        private Label lblProducto;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Button btnNuevo;
        private PictureBox pictureBox1;
        private Button btnRegistro;
        private TabPage tpAlmacen;
        private ToolStrip tsBoorartodo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private DataGridView dgvProducAlmacenados;
        private Button btnBuscar;
        private Label label4;
        private TextBox txtBuscar;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private ImageList imageList1;
        private ToolStripButton tsBorrartodo;
        private ErrorProvider epAdvertencia;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TabPage tpConsulta;
        private Label lblProductosComparacion;
        private Label label8;
        private Label label7;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label6;
        private RadioButton rbMenores;
        private DataGridView dgvConsculta;
        private Button btnConsulta;
        private TextBox txtConsultao;
        private RadioButton rbMayores;
        private Button buttonSalir;
    }
}