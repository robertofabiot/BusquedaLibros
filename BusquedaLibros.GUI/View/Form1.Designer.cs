namespace BusquedaLibros.GUI
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTabBusqueda = new System.Windows.Forms.Button();
            this.btnTabGestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new TabControlSinBordes();
            this.tabGestion = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.RichTextBox();
            this.dtpLibroFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAutores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombreLibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.btnEditarAutor = new System.Windows.Forms.Button();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.tbNombreAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbResultados = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.tabBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnTabBusqueda);
            this.panel1.Controls.Add(this.btnTabGestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 903);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(144)))), ((int)(((byte)(75)))));
            this.btnSalir.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(31, 508);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 55);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BusquedaLibros.GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(49, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnTabBusqueda
            // 
            this.btnTabBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(144)))), ((int)(((byte)(75)))));
            this.btnTabBusqueda.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabBusqueda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTabBusqueda.Location = new System.Drawing.Point(31, 409);
            this.btnTabBusqueda.Name = "btnTabBusqueda";
            this.btnTabBusqueda.Size = new System.Drawing.Size(162, 55);
            this.btnTabBusqueda.TabIndex = 2;
            this.btnTabBusqueda.Text = "Búsqueda";
            this.btnTabBusqueda.UseVisualStyleBackColor = false;
            this.btnTabBusqueda.Click += new System.EventHandler(this.btnTabBusqueda_Click);
            // 
            // btnTabGestion
            // 
            this.btnTabGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(144)))), ((int)(((byte)(75)))));
            this.btnTabGestion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabGestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTabGestion.Location = new System.Drawing.Point(31, 310);
            this.btnTabGestion.Name = "btnTabGestion";
            this.btnTabGestion.Size = new System.Drawing.Size(162, 55);
            this.btnTabGestion.TabIndex = 1;
            this.btnTabGestion.Text = "Gestión";
            this.btnTabGestion.UseVisualStyleBackColor = false;
            this.btnTabGestion.Click += new System.EventHandler(this.btnTabGestion_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gestión de Libros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGestion);
            this.tabControl.Controls.Add(this.tabBusqueda);
            this.tabControl.Location = new System.Drawing.Point(219, -3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1531, 851);
            this.tabControl.TabIndex = 0;
            // 
            // tabGestion
            // 
            this.tabGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.tabGestion.Controls.Add(this.button1);
            this.tabGestion.Controls.Add(this.button2);
            this.tabGestion.Controls.Add(this.button3);
            this.tabGestion.Controls.Add(this.label8);
            this.tabGestion.Controls.Add(this.tbDescripcion);
            this.tabGestion.Controls.Add(this.dtpLibroFecha);
            this.tabGestion.Controls.Add(this.label7);
            this.tabGestion.Controls.Add(this.cbAutores);
            this.tabGestion.Controls.Add(this.label6);
            this.tabGestion.Controls.Add(this.tbNombreLibro);
            this.tabGestion.Controls.Add(this.label5);
            this.tabGestion.Controls.Add(this.dgvLibros);
            this.tabGestion.Controls.Add(this.btnEliminarAutor);
            this.tabGestion.Controls.Add(this.btnEditarAutor);
            this.tabGestion.Controls.Add(this.btnAgregarAutor);
            this.tabGestion.Controls.Add(this.tbNombreAutor);
            this.tabGestion.Controls.Add(this.label4);
            this.tabGestion.Controls.Add(this.dgvAutores);
            this.tabGestion.Controls.Add(this.label3);
            this.tabGestion.Controls.Add(this.label2);
            this.tabGestion.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tabGestion.Location = new System.Drawing.Point(4, 25);
            this.tabGestion.Name = "tabGestion";
            this.tabGestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestion.Size = new System.Drawing.Size(1523, 822);
            this.tabGestion.TabIndex = 0;
            this.tabGestion.Text = "tabGestion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(394, 751);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(221, 751);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 38);
            this.button2.TabIndex = 22;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnEditarLibro_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(55, 751);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 45);
            this.label8.TabIndex = 20;
            this.label8.Text = "Descripción:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(209, 536);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(374, 189);
            this.tbDescripcion.TabIndex = 19;
            this.tbDescripcion.Text = "";
            // 
            // dtpLibroFecha
            // 
            this.dtpLibroFecha.Location = new System.Drawing.Point(207, 469);
            this.dtpLibroFecha.Name = "dtpLibroFecha";
            this.dtpLibroFecha.Size = new System.Drawing.Size(378, 34);
            this.dtpLibroFecha.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 45);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha de salida:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbAutores
            // 
            this.cbAutores.FormattingEnabled = true;
            this.cbAutores.Location = new System.Drawing.Point(209, 409);
            this.cbAutores.Name = "cbAutores";
            this.cbAutores.Size = new System.Drawing.Size(374, 32);
            this.cbAutores.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 45);
            this.label6.TabIndex = 15;
            this.label6.Text = "Autor:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNombreLibro
            // 
            this.tbNombreLibro.Location = new System.Drawing.Point(209, 349);
            this.tbNombreLibro.Name = "tbNombreLibro";
            this.tbNombreLibro.Size = new System.Drawing.Size(376, 34);
            this.tbNombreLibro.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 45);
            this.label5.TabIndex = 13;
            this.label5.Text = "Título del libro:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(639, 349);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(789, 376);
            this.dgvLibros.TabIndex = 12;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);
            // 
            // btnEliminarAutor
            // 
            this.btnEliminarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.btnEliminarAutor.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarAutor.Location = new System.Drawing.Point(357, 146);
            this.btnEliminarAutor.Name = "btnEliminarAutor";
            this.btnEliminarAutor.Size = new System.Drawing.Size(137, 38);
            this.btnEliminarAutor.TabIndex = 11;
            this.btnEliminarAutor.Text = "Eliminar";
            this.btnEliminarAutor.UseVisualStyleBackColor = false;
            this.btnEliminarAutor.Click += new System.EventHandler(this.btnEliminarAutor_Click);
            // 
            // btnEditarAutor
            // 
            this.btnEditarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.btnEditarAutor.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarAutor.Location = new System.Drawing.Point(184, 146);
            this.btnEditarAutor.Name = "btnEditarAutor";
            this.btnEditarAutor.Size = new System.Drawing.Size(137, 38);
            this.btnEditarAutor.TabIndex = 10;
            this.btnEditarAutor.Text = "Editar";
            this.btnEditarAutor.UseVisualStyleBackColor = false;
            this.btnEditarAutor.Click += new System.EventHandler(this.btnEditarAutor_Click);
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.btnAgregarAutor.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarAutor.Location = new System.Drawing.Point(18, 146);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(137, 38);
            this.btnAgregarAutor.TabIndex = 5;
            this.btnAgregarAutor.Text = "Agregar";
            this.btnAgregarAutor.UseVisualStyleBackColor = false;
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click);
            // 
            // tbNombreAutor
            // 
            this.tbNombreAutor.Location = new System.Drawing.Point(198, 94);
            this.tbNombreAutor.Name = "tbNombreAutor";
            this.tbNombreAutor.Size = new System.Drawing.Size(219, 34);
            this.tbNombreAutor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre del autor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAutores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.ColumnHeadersVisible = false;
            this.dgvAutores.Location = new System.Drawing.Point(560, 12);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowHeadersVisible = false;
            this.dgvAutores.RowHeadersWidth = 51;
            this.dgvAutores.RowTemplate.Height = 24;
            this.dgvAutores.Size = new System.Drawing.Size(385, 219);
            this.dgvAutores.TabIndex = 7;
            this.dgvAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Libros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.tabBusqueda.Controls.Add(this.tbResultados);
            this.tabBusqueda.Controls.Add(this.btnBuscar);
            this.tabBusqueda.Controls.Add(this.label10);
            this.tabBusqueda.Controls.Add(this.tbBusqueda);
            this.tabBusqueda.Controls.Add(this.label9);
            this.tabBusqueda.Controls.Add(this.cmTipoBusqueda);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 25);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(1523, 822);
            this.tabBusqueda.TabIndex = 1;
            this.tabBusqueda.Text = "tabBusqueda";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 45);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tipo de búsqueda:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tbBusqueda.Location = new System.Drawing.Point(213, 99);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(374, 34);
            this.tbBusqueda.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 45);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tipo de búsqueda:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmTipoBusqueda
            // 
            this.cmTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTipoBusqueda.Font = new System.Drawing.Font("Gadugi", 12F);
            this.cmTipoBusqueda.FormattingEnabled = true;
            this.cmTipoBusqueda.Items.AddRange(new object[] {
            "Por Nombre de Libro (Lineal)",
            "Por Nombre de Autor (Binaria)",
            "Libros Extremos (Antiguo/Reciente)",
            "En Descripciones (Texto)"});
            this.cmTipoBusqueda.Location = new System.Drawing.Point(209, 39);
            this.cmTipoBusqueda.Name = "cmTipoBusqueda";
            this.cmTipoBusqueda.Size = new System.Drawing.Size(374, 32);
            this.cmTipoBusqueda.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(646, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 38);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // tbResultados
            // 
            this.tbResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.tbResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResultados.Location = new System.Drawing.Point(24, 169);
            this.tbResultados.Name = "tbResultados";
            this.tbResultados.ReadOnly = true;
            this.tbResultados.Size = new System.Drawing.Size(1419, 582);
            this.tbResultados.TabIndex = 22;
            this.tbResultados.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1705, 827);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Búsqueda Libros";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabGestion.ResumeLayout(false);
            this.tabGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.tabBusqueda.ResumeLayout(false);
            this.tabBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControlSinBordes tabControl;
        private System.Windows.Forms.TabPage tabGestion;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTabGestion;
        private System.Windows.Forms.Button btnTabBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.Button btnAgregarAutor;
        private System.Windows.Forms.TextBox tbNombreAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditarAutor;
        private System.Windows.Forms.Button btnEliminarAutor;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.TextBox tbNombreLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAutores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpLibroFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tbDescripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmTipoBusqueda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox tbResultados;
    }
}

