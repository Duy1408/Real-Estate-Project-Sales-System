using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateProjectSaleBusinessObject.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OpeningForSale",
                columns: table => new
                {
                    OpeningForSaleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescriptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deposittime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepositMoney = table.Column<double>(type: "float", nullable: false),
                    RevervationMoney = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningForSale", x => x.OpeningForSaleID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    PaymentTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.PaymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "PropertiesType",
                columns: table => new
                {
                    PropertiesTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertiesType", x => x.PropertiesTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Salespolicy",
                columns: table => new
                {
                    SalesPolicyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpressTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeopleApplied = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPolicyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salespolicy", x => x.SalesPolicyID);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Account_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "PaymentProcess",
                columns: table => new
                {
                    PaymentProcessID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Paymentperiod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentRate = table.Column<int>(type: "int", nullable: false),
                    SalesPolicyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProcess", x => x.PaymentProcessID);
                    table.ForeignKey(
                        name: "FK_PaymentProcess_Salespolicy_SalesPolicyID",
                        column: x => x.SalesPolicyID,
                        principalTable: "Salespolicy",
                        principalColumn: "SalesPolicyID");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommericalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfProject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commune = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseNo = table.Column<int>(type: "int", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampusArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceofIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SalesPolicyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Project_Salespolicy_SalesPolicyID",
                        column: x => x.SalesPolicyID,
                        principalTable: "Salespolicy",
                        principalColumn: "SalesPolicyID");
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    PromotionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PromotionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SalesPolicyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.PromotionID);
                    table.ForeignKey(
                        name: "FK_Promotion_Salespolicy_SalesPolicyID",
                        column: x => x.SalesPolicyID,
                        principalTable: "Salespolicy",
                        principalColumn: "SalesPolicyID");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Taxcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customer_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagesignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placeoforigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfresidence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateRange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Taxcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankNumber = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staff_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentProcessDetail",
                columns: table => new
                {
                    PaymentProcessDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeriodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<double>(type: "float", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Maintenancecosts = table.Column<double>(type: "float", nullable: false),
                    Paymentprocessname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentProcessID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProcessDetail", x => x.PaymentProcessDetailID);
                    table.ForeignKey(
                        name: "FK_PaymentProcessDetail_PaymentProcess_PaymentProcessID",
                        column: x => x.PaymentProcessID,
                        principalTable: "PaymentProcess",
                        principalColumn: "PaymentProcessID");
                });

            migrationBuilder.CreateTable(
                name: "PromotionDetail",
                columns: table => new
                {
                    PromotionDetaiID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PromotionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPercent = table.Column<double>(type: "float", nullable: false),
                    DiscountAmount = table.Column<double>(type: "float", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    PromotionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertiesTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetail", x => x.PromotionDetaiID);
                    table.ForeignKey(
                        name: "FK_PromotionDetail_Promotion_PromotionID",
                        column: x => x.PromotionID,
                        principalTable: "Promotion",
                        principalColumn: "PromotionID");
                    table.ForeignKey(
                        name: "FK_PromotionDetail_PropertiesType_PropertiesTypeID",
                        column: x => x.PropertiesTypeID,
                        principalTable: "PropertiesType",
                        principalColumn: "PropertiesTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dateofsignature = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentProcessID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpeningForSaleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Booking_OpeningForSale_OpeningForSaleID",
                        column: x => x.OpeningForSaleID,
                        principalTable: "OpeningForSale",
                        principalColumn: "OpeningForSaleID");
                    table.ForeignKey(
                        name: "FK_Booking_PaymentProcess_PaymentProcessID",
                        column: x => x.PaymentProcessID,
                        principalTable: "PaymentProcess",
                        principalColumn: "PaymentProcessID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID");
                    table.ForeignKey(
                        name: "FK_Booking_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID");
                });

            migrationBuilder.CreateTable(
                name: "BookingPayment",
                columns: table => new
                {
                    BookingPaymentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deposittoholdproject = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PaymentTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingPayment", x => x.BookingPaymentID);
                    table.ForeignKey(
                        name: "FK_BookingPayment_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID");
                    table.ForeignKey(
                        name: "FK_BookingPayment_PaymentType_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentType",
                        principalColumn: "PaymentTypeID");
                });

            migrationBuilder.CreateTable(
                name: "BookingPaymentProcessDetail",
                columns: table => new
                {
                    BookingPaymentProcessDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Paymentprogress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paymentduedate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customervaluepaid = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingPaymentProcessDetail", x => x.BookingPaymentProcessDetailID);
                    table.ForeignKey(
                        name: "FK_BookingPaymentProcessDetail_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID");
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContractID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateSigned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedStAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContractID);
                    table.ForeignKey(
                        name: "FK_Contact_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertiesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    SizeArea = table.Column<double>(type: "float", nullable: false),
                    BedRoom = table.Column<int>(type: "int", nullable: false),
                    BathRoom = table.Column<int>(type: "int", nullable: false),
                    LivingRoom = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    View = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertiesTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertiesID);
                    table.ForeignKey(
                        name: "FK_Properties_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID");
                    table.ForeignKey(
                        name: "FK_Properties_PropertiesType_PropertiesTypeID",
                        column: x => x.PropertiesTypeID,
                        principalTable: "PropertiesType",
                        principalColumn: "PropertiesTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PropertiesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Comment_Properties_PropertiesID",
                        column: x => x.PropertiesID,
                        principalTable: "Properties",
                        principalColumn: "PropertiesID");
                });

            migrationBuilder.CreateTable(
                name: "OpenForSaleDetail",
                columns: table => new
                {
                    OpenForSaleDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    TypeRoom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    OpeningForSaleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertiesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenForSaleDetail", x => x.OpenForSaleDetailID);
                    table.ForeignKey(
                        name: "FK_OpenForSaleDetail_OpeningForSale_OpeningForSaleID",
                        column: x => x.OpeningForSaleID,
                        principalTable: "OpeningForSale",
                        principalColumn: "OpeningForSaleID");
                    table.ForeignKey(
                        name: "FK_OpenForSaleDetail_Properties_PropertiesID",
                        column: x => x.PropertiesID,
                        principalTable: "Properties",
                        principalColumn: "PropertiesID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_RoleID",
                table: "Account",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerID",
                table: "Booking",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_OpeningForSaleID",
                table: "Booking",
                column: "OpeningForSaleID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_PaymentProcessID",
                table: "Booking",
                column: "PaymentProcessID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ProjectID",
                table: "Booking",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_StaffID",
                table: "Booking",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingPayment_BookingID",
                table: "BookingPayment",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingPayment_PaymentTypeID",
                table: "BookingPayment",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingPaymentProcessDetail_BookingID",
                table: "BookingPaymentProcessDetail",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CustomerID",
                table: "Comment",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PropertiesID",
                table: "Comment",
                column: "PropertiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_BookingID",
                table: "Contact",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AccountID",
                table: "Customer",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_OpenForSaleDetail_OpeningForSaleID",
                table: "OpenForSaleDetail",
                column: "OpeningForSaleID");

            migrationBuilder.CreateIndex(
                name: "IX_OpenForSaleDetail_PropertiesID",
                table: "OpenForSaleDetail",
                column: "PropertiesID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProcess_SalesPolicyID",
                table: "PaymentProcess",
                column: "SalesPolicyID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProcessDetail_PaymentProcessID",
                table: "PaymentProcessDetail",
                column: "PaymentProcessID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_SalesPolicyID",
                table: "Project",
                column: "SalesPolicyID");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_SalesPolicyID",
                table: "Promotion",
                column: "SalesPolicyID");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetail_PromotionID",
                table: "PromotionDetail",
                column: "PromotionID");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetail_PropertiesTypeID",
                table: "PromotionDetail",
                column: "PropertiesTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_BookingID",
                table: "Properties",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ProjectID",
                table: "Properties",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertiesTypeID",
                table: "Properties",
                column: "PropertiesTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_AccountID",
                table: "Staff",
                column: "AccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingPayment");

            migrationBuilder.DropTable(
                name: "BookingPaymentProcessDetail");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "OpenForSaleDetail");

            migrationBuilder.DropTable(
                name: "PaymentProcessDetail");

            migrationBuilder.DropTable(
                name: "PromotionDetail");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "PropertiesType");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "OpeningForSale");

            migrationBuilder.DropTable(
                name: "PaymentProcess");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Salespolicy");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
