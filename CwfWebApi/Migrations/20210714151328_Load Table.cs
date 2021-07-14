using Microsoft.EntityFrameworkCore.Migrations;

namespace CwfWebApi.Migrations
{
    public partial class LoadTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lane = table.Column<string>(maxLength: 30, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    Revenue = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    InvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loads_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loads_InvoiceId",
                table: "Loads",
                column: "InvoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loads");
        }
    }
}
