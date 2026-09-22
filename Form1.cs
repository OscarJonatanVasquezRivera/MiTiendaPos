using Microsoft.EntityFrameworkCore;
using MiTiendaPos.Data;
namespace MiTiendaPos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using var contexto = new MiTiendaPosContext();

                bool conecta = contexto.Database.CanConnect();
                int categorias = contexto.Categorias.Count();
                int usuarios = contexto.Usuarios.Count();
                int pendientes = contexto.Database.GetPendingMigrations().Count();

                MessageBox.Show(
                    $"Conexión a MiTiendaPosDb: {(conecta ? "OK" : "FALLÓ")}\n" +
                    $"Categorías registradas: {categorias}\n" +
                    $"Usuarios registrados: {usuarios}\n" +
                    $"Migraciones pendientes: {pendientes}",
                    "MiTiendaPos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   // <- al salir del bloque try se ejecuta Dispose() del contexto
                // El manejo de excepciones se profundiza en la Unidad 4
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "MiTiendaPos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
