using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiTiendaPos.Migrations
{
    /// <inheritdoc />
    public partial class DatosPrueba2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Correo", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, null, "Consumidor final", null },
                    { 2, null, "María López", "70000000" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[,]
                {
                    { 1, true, 1, "Agua", 15.00m, 0 },
                    { 2, true, 2, "Arroz", 45.00m, 0 },
                    { 3, true, 3, "Detergente", 30.00m, 0 },
                    { 4, true, 1, "Refresco", 20.00m, 0 },
                    { 5, true, 2, "Frijoles", 50.00m, 0 },
                    { 6, true, 3, "Jabón", 25.00m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NombreUsuario", "Rol" },
                values: new object[] { 2, "Cajero1", "Cajero" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
