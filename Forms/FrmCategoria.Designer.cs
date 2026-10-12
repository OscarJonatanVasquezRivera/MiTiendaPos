namespace MiTiendaPos.Forms
{
    partial class FrmCategoria
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
            txtBuscar = new TextBox();
            lblFiltro = new Label();
            dgvCategorias = new DataGridView();
            grpDatos = new GroupBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(150, 40);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(417, 27);
            txtBuscar.TabIndex = 0;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(39, 40);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(55, 20);
            lblFiltro.TabIndex = 1;
            lblFiltro.Text = "Buscar:";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(12, 92);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(398, 319);
            dgvCategorias.TabIndex = 2;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnEliminar);
            grpDatos.Controls.Add(btnGuardar);
            grpDatos.Controls.Add(btnNuevo);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Location = new Point(434, 92);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(354, 319);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "\"Datos de la categoría\"";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(41, 245);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(256, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(41, 182);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(256, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(41, 121);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(256, 29);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpDatos);
            Controls.Add(dgvCategorias);
            Controls.Add(lblFiltro);
            Controls.Add(txtBuscar);
            Name = "FrmCategoria";
            Text = "Mantenimiento Categoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Label lblFiltro;
        private DataGridView dgvCategorias;
        private GroupBox grpDatos;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
    }
}