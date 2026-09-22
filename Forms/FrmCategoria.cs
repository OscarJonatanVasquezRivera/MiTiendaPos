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
                .Select(c=> new {c.Id, c.Nombre})
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

        }
    }
}
