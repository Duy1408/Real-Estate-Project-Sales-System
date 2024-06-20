using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateProjectSaleBusinessObject.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Staff",
                newName: "PersonalEmail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customer",
                newName: "PersonalEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonalEmail",
                table: "Staff",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "PersonalEmail",
                table: "Customer",
                newName: "Email");
        }
    }
}
