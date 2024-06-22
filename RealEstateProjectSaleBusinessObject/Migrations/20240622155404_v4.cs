using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateProjectSaleBusinessObject.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Properties_PropertiesID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_OpenForSaleDetail_Properties_PropertiesID",
                table: "OpenForSaleDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PromotionDetail_PropertiesType_PropertiesTypeID",
                table: "PromotionDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Booking_BookingID",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Project_ProjectID",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertiesType_PropertyTypeID",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertiesType",
                table: "PropertiesType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.RenameTable(
                name: "PropertiesType",
                newName: "PropertyType");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_PropertyTypeID",
                table: "Property",
                newName: "IX_Property_PropertyTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_ProjectID",
                table: "Property",
                newName: "IX_Property_ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_BookingID",
                table: "Property",
                newName: "IX_Property_BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyType",
                table: "PropertyType",
                column: "PropertyTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "PropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Property_PropertiesID",
                table: "Comment",
                column: "PropertiesID",
                principalTable: "Property",
                principalColumn: "PropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_OpenForSaleDetail_Property_PropertiesID",
                table: "OpenForSaleDetail",
                column: "PropertiesID",
                principalTable: "Property",
                principalColumn: "PropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_PromotionDetail_PropertyType_PropertiesTypeID",
                table: "PromotionDetail",
                column: "PropertiesTypeID",
                principalTable: "PropertyType",
                principalColumn: "PropertyTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Booking_BookingID",
                table: "Property",
                column: "BookingID",
                principalTable: "Booking",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Project_ProjectID",
                table: "Property",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyType_PropertyTypeID",
                table: "Property",
                column: "PropertyTypeID",
                principalTable: "PropertyType",
                principalColumn: "PropertyTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Property_PropertiesID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_OpenForSaleDetail_Property_PropertiesID",
                table: "OpenForSaleDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PromotionDetail_PropertyType_PropertiesTypeID",
                table: "PromotionDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Booking_BookingID",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Project_ProjectID",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyType_PropertyTypeID",
                table: "Property");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyType",
                table: "PropertyType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.RenameTable(
                name: "PropertyType",
                newName: "PropertiesType");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.RenameIndex(
                name: "IX_Property_PropertyTypeID",
                table: "Properties",
                newName: "IX_Properties_PropertyTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Property_ProjectID",
                table: "Properties",
                newName: "IX_Properties_ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Property_BookingID",
                table: "Properties",
                newName: "IX_Properties_BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertiesType",
                table: "PropertiesType",
                column: "PropertyTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "PropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Properties_PropertiesID",
                table: "Comment",
                column: "PropertiesID",
                principalTable: "Properties",
                principalColumn: "PropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_OpenForSaleDetail_Properties_PropertiesID",
                table: "OpenForSaleDetail",
                column: "PropertiesID",
                principalTable: "Properties",
                principalColumn: "PropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_PromotionDetail_PropertiesType_PropertiesTypeID",
                table: "PromotionDetail",
                column: "PropertiesTypeID",
                principalTable: "PropertiesType",
                principalColumn: "PropertyTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Booking_BookingID",
                table: "Properties",
                column: "BookingID",
                principalTable: "Booking",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Project_ProjectID",
                table: "Properties",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertiesType_PropertyTypeID",
                table: "Properties",
                column: "PropertyTypeID",
                principalTable: "PropertiesType",
                principalColumn: "PropertyTypeID");
        }
    }
}
