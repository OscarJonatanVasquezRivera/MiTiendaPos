using MiTiendaPos.Models;
using MiTiendaPos.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiTiendaPos.Forms
{
    public partial class FrmCategoria : Form
    {
        private readonly CategoriaService _servicio = new();
        private int _idSeleccionado = 0; //Para registro nuevo

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LimpiarFormulario();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = _servicio.Listar(txtBuscar.Text)
                .Select(c => new { c.Id, c.Nombre })
                .ToList();
        }

        private void LimpiarFormulario() 
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            btnEliminar.Enabled = false;
            dgvCategorias.ClearSelection();
            txtNombre.Focus();

        }   
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0) return;
            var respuesta = MessageBox.Show("$ Estas seguro de eliminar la categoría \"{txtNombre}\"?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) return;

            {
                try
                {

        }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvCategorias.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells["Id"].Value);
            Categoria? categoria = _servicio.ObtenerPorId(id);
            if (categoria == null) return;

            _idSeleccionado = categoria.Id;
            txtNombre.Text = categoria.Nombre;
            btnEliminar.Enabled = true;
    }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = new Categoria
                {
                    Id = _idSeleccionado,
                    Nombre = txtNombre.Text
                };
                if (_idSeleccionado == 0)
                    _servicio.Crear(categoria);

                else
                    _servicio.Actualizar(categoria);
                MessageBox.Show("Categoria guardada cone exito,", "MiTIendaPOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "No se pudo guardar",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarCategorias();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    };
}
