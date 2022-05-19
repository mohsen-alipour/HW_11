using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_11.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Producer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_Adderss = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_Seller",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Adderss = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Seller", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_Factor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    ProducerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Factor", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Factor__Producer_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "_Producer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Factor__Seller_SellerID",
                        column: x => x.SellerID,
                        principalTable: "_Seller",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Factor_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX__Factor_CustomerID",
                table: "_Factor",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX__Factor_ProducerID",
                table: "_Factor",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX__Factor_SellerID",
                table: "_Factor",
                column: "SellerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Factor");

            migrationBuilder.DropTable(
                name: "_Producer");

            migrationBuilder.DropTable(
                name: "_Seller");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
