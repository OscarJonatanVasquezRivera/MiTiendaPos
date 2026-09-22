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
            grpHistorial = new GroupBox();
            grpDetalle = new GroupBox();
            lblCliente = new Label();
            lblUsuario = new Label();
            comboBox1 = new ComboBox();
            grpEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // grpEncabezado
            // 
            grpEncabezado.Controls.Add(comboBox1);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Location = new Point(12, 21);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(432, 205);
            grpEncabezado.TabIndex = 0;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = " Encabezado de la venta";
            // 
            // grpHistorial
            // 
            grpHistorial.Location = new Point(626, 12);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Size = new Size(364, 589);
            grpHistorial.TabIndex = 0;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de Ventas";
            // 
            // grpDetalle
            // 
            grpDetalle.Location = new Point(12, 232);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(439, 289);
            grpDetalle.TabIndex = 1;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de productos";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(44, 44);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(57, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(341, 44);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 613);
            Controls.Add(grpDetalle);
            Controls.Add(grpHistorial);
            Controls.Add(grpEncabezado);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Ventas";
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEncabezado;
        private GroupBox grpHistorial;
        private Label lblUsuario;
        private Label lblCliente;
        private GroupBox grpDetalle;
        private ComboBox comboBox1;
    }
}