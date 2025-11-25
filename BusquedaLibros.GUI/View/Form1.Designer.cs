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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTabBusqueda = new System.Windows.Forms.Button();
            this.btnTabGestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new TabControlSinBordes();
            this.tbGestion = new System.Windows.Forms.TabPage();
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.btnEditarAutor = new System.Windows.Forms.Button();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.tbNombreAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tbGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(216, 620);
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
            this.tabControl.Controls.Add(this.tbGestion);
            this.tabControl.Controls.Add(this.tbBusqueda);
            this.tabControl.Location = new System.Drawing.Point(219, -3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(891, 607);
            this.tabControl.TabIndex = 0;
            // 
            // tbGestion
            // 
            this.tbGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.tbGestion.Controls.Add(this.btnEliminarAutor);
            this.tbGestion.Controls.Add(this.btnEditarAutor);
            this.tbGestion.Controls.Add(this.btnAgregarAutor);
            this.tbGestion.Controls.Add(this.tbNombreAutor);
            this.tbGestion.Controls.Add(this.label4);
            this.tbGestion.Controls.Add(this.dgvAutores);
            this.tbGestion.Controls.Add(this.label3);
            this.tbGestion.Controls.Add(this.label2);
            this.tbGestion.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tbGestion.Location = new System.Drawing.Point(4, 25);
            this.tbGestion.Name = "tbGestion";
            this.tbGestion.Padding = new System.Windows.Forms.Padding(3);
            this.tbGestion.Size = new System.Drawing.Size(883, 578);
            this.tbGestion.TabIndex = 0;
            this.tbGestion.Text = "tbGestion";
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
            this.dgvAutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.ColumnHeadersVisible = false;
            this.dgvAutores.Location = new System.Drawing.Point(560, 12);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowHeadersVisible = false;
            this.dgvAutores.RowHeadersWidth = 51;
            this.dgvAutores.RowTemplate.Height = 24;
            this.dgvAutores.Size = new System.Drawing.Size(147, 219);
            this.dgvAutores.TabIndex = 7;
            this.dgvAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Libros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.tbBusqueda.Location = new System.Drawing.Point(4, 25);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tbBusqueda.Size = new System.Drawing.Size(883, 578);
            this.tbBusqueda.TabIndex = 1;
            this.tbBusqueda.Text = "tbBusqueda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1111, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Búsqueda Libros";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tbGestion.ResumeLayout(false);
            this.tbGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControlSinBordes tabControl;
        private System.Windows.Forms.TabPage tbGestion;
        private System.Windows.Forms.TabPage tbBusqueda;
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
    }
}

