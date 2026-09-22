using Microsoft.Extensions.Configuration;

namespace MiTiendaPos.Config
{
    public static class ConfiguracionApp
    {
        private const string Archivo = "appsettings.json";

        public static string ObtenerCadenaConexion(
            string nombre = "MiTiendaPosDb")
        {
            // 1) Carpeta del ejecutable (bin) -> aplicación en ejecución
            // 2) Carpeta actual -> herramientas de migración
            string rutaExe = Path.Combine(AppContext.BaseDirectory, Archivo);
            string rutaBase = File.Exists(rutaExe)
                ? AppContext.BaseDirectory
                : Directory.GetCurrentDirectory();

            IConfigurationRoot configuracion = new ConfigurationBuilder()
                .SetBasePath(rutaBase)
                .AddJsonFile(Archivo, optional: false, reloadOnChange: false)
                .Build();

            return configuracion.GetConnectionString(nombre)
                ?? throw new InvalidOperationException(
                    $"Falta la cadena '{nombre}' en {Archivo}.");
        }
    }
}
