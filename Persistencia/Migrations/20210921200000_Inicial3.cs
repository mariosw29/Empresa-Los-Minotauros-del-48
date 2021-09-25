using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_proveedors",
                table: "proveedors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productos",
                table: "productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personas",
                table: "personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empresas",
                table: "empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empleados",
                table: "empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cargos",
                table: "cargos");

            migrationBuilder.RenameTable(
                name: "proveedors",
                newName: "Proveedors");

            migrationBuilder.RenameTable(
                name: "productos",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "personas",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "empresas",
                newName: "Empresas");

            migrationBuilder.RenameTable(
                name: "empleados",
                newName: "Empleados");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "cargos",
                newName: "Cargos");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empleados",
                newName: "Directivo");

            migrationBuilder.RenameColumn(
                name: "Codigo_Empleado",
                table: "Empleados",
                newName: "Salario");

            migrationBuilder.RenameColumn(
                name: "nivel",
                table: "Cargos",
                newName: "Nivel");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodEmpleado",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedors",
                table: "Proveedors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedors",
                table: "Proveedors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cargos",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "CodEmpleado",
                table: "Empleados");

            migrationBuilder.RenameTable(
                name: "Proveedors",
                newName: "proveedors");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "productos");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "personas");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "empresas");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "empleados");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "clientes");

            migrationBuilder.RenameTable(
                name: "Cargos",
                newName: "cargos");

            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "empleados",
                newName: "Codigo_Empleado");

            migrationBuilder.RenameColumn(
                name: "Directivo",
                table: "empleados",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Nivel",
                table: "cargos",
                newName: "nivel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_proveedors",
                table: "proveedors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productos",
                table: "productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personas",
                table: "personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empresas",
                table: "empresas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empleados",
                table: "empleados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cargos",
                table: "cargos",
                column: "Id");
        }
    }
}
