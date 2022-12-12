using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhongHienCoop.Migrations
{
    /// <inheritdoc />
    public partial class Innittial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    accid = table.Column<int>(name: "acc_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acclogname = table.Column<string>(name: "acc_log_name", type: "nvarchar(max)", nullable: false),
                    accpass = table.Column<int>(name: "acc_pass", type: "int", nullable: false),
                    accname = table.Column<int>(name: "acc_name", type: "int", nullable: false),
                    accaddress = table.Column<string>(name: "acc_address", type: "nvarchar(max)", nullable: false),
                    acctel = table.Column<int>(name: "acc_tel", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.accid);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    agentid = table.Column<int>(name: "agent_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    agentname = table.Column<string>(name: "agent_name", type: "nvarchar(max)", nullable: false),
                    agentpass = table.Column<string>(name: "agent_pass", type: "nvarchar(max)", nullable: false),
                    agenttel = table.Column<int>(name: "agent_tel", type: "int", nullable: false),
                    agentaddress = table.Column<string>(name: "agent_address", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.agentid);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productid = table.Column<int>(name: "product_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productname = table.Column<string>(name: "product_name", type: "nvarchar(max)", nullable: false),
                    price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productinfo = table.Column<string>(name: "product_info", type: "nvarchar(max)", nullable: false),
                    productimg = table.Column<string>(name: "product_img", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
