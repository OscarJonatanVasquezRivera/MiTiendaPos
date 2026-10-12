namespace MiTiendaPos.Forms
{
    partial class FrmVentas
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
            grpEncabezado = new GroupBox();
            lblVenta = new Label();
            cboUsuario = new ComboBox();
            cboCliente = new ComboBox();
            lblUsuario = new Label();
            lblCliente = new Label();
            lblCantidad = new Label();
            cboProducto = new ComboBox();
            lblProducto = new Label();
            grpHistorial = new GroupBox();
            dgvVentas = new DataGridView();
            grpDetalle = new GroupBox();
            lblTotal = new Label();
            nudCantidad = new NumericUpDown();
            dgvDetalle = new DataGridView();
            btnQuitar = new Button();
            btnAgregar = new Button();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpEncabezado.SuspendLayout();
            grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // grpEncabezado
            // 
            grpEncabezado.Controls.Add(lblVenta);
            grpEncabezado.Controls.Add(cboUsuario);
            grpEncabezado.Controls.Add(cboCliente);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Location = new Point(12, 21);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(590, 118);
            grpEncabezado.TabIndex = 0;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = " Encabezado de la venta";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(6, 80);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(98, 20);
            lblVenta.TabIndex = 2;
            lblVenta.Text = "Venta Nueva";
            // 
            // cboUsuario
            // 
            cboUsuario.BackColor = SystemColors.Window;
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(373, 39);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(211, 28);
            cboUsuario.TabIndex = 3;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(69, 39);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(208, 28);
            cboCliente.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(304, 41);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(6, 41);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(335, 38);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(42, 20);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cant:";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(85, 35);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(235, 28);
            cboProducto.TabIndex = 3;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(6, 35);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // grpHistorial
            // 
            grpHistorial.Controls.Add(dgvVentas);
            grpHistorial.Location = new Point(626, 12);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Size = new Size(364, 589);
            grpHistorial.TabIndex = 0;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(29, 37);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(329, 546);
            dgvVentas.TabIndex = 7;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblCantidad);
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Controls.Add(nudCantidad);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnQuitar);
            grpDetalle.Controls.Add(cboProducto);
            grpDetalle.Controls.Add(lblProducto);
            grpDetalle.Controls.Add(btnAgregar);
            grpDetalle.Location = new Point(12, 145);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(590, 391);
            grpDetalle.TabIndex = 1;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de productos";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(419, 326);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(137, 31);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: $0.00";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(386, 35);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(57, 27);
            nudCantidad.TabIndex = 4;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(11, 92);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(564, 219);
            dgvDetalle.TabIndex = 6;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitar.Location = new Point(10, 326);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(110, 29);
            btnQuitar.TabIndex = 5;
            btnQuitar.Text = "Quitar línea";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(466, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(22, 556);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(144, 29);
            btnNueva.TabIndex = 6;
            btnNueva.Text = "Nueva venta";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(235, 556);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar venta";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(443, 556);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar venta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 613);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNueva);
            Controls.Add(grpDetalle);
            Controls.Add(grpHistorial);
            Controls.Add(grpEncabezado);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Ventas";
            Load += FrmVentas_Load;
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEncabezado;
        private GroupBox grpHistorial;
        private Label lblUsuario;
        private Label lblCliente;
        private GroupBox grpDetalle;
        private ComboBox cboCliente;
        private Label lblVenta;
        private ComboBox cboUsuario;
        private Label lblCantidad;
        private ComboBox cboProducto;
        private Label lblProducto;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Button btnQuitar;
        private DataGridView dgvDetalle;
        private DataGridView dgvVentas;
        private Label lblTotal;
        private Button btnNueva;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}