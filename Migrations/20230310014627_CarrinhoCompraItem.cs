using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceMVC.Migrations
{
    /// <inheritdoc />
    public partial class CarrinhoCompraItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LancheID = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItens_Lanches_LancheID",
                        column: x => x.LancheID,
                        principalTable: "Lanches",
                        principalColumn: "LancheID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItens_LancheID",
                table: "CarrinhoCompraItens",
                column: "LancheID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoCompraItens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches");

            migrationBuilder.DropColumn(
                name: "LancheID",
                table: "Lanches");

            migrationBuilder.RenameColumn(
                name: "LancheId",
                table: "Lanches",
                newName: "LancheID");

            migrationBuilder.AlterColumn<int>(
                name: "LancheID",
                table: "Lanches",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches",
                column: "LancheID");
        }
    }
}
