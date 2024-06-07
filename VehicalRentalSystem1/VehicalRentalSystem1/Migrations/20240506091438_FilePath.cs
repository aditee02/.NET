using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicalRentalSystem1.Migrations
{
    /// <inheritdoc />
    public partial class FilePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "dbo",
                columns: table => new
                {
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone_No = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Goverment_Doc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GovermentDoc_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResetToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                schema: "dbo",
                columns: table => new
                {
                    Booking_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vehical_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rental_Start_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Rental_End_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Total_Rental_Cost = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Insurance_Option = table.Column<bool>(type: "bit", nullable: false),
                    Pickup_Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Drop_Off_Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Additional_Charges = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Booking_Id);
                    table.ForeignKey(
                        name: "FK_Booking_User",
                        column: x => x.User_Id,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                schema: "dbo",
                columns: table => new
                {
                    Chat_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SUser_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RUser_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Conversation_Start_Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    Messege_Context = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_1", x => x.Chat_Id);
                    table.ForeignKey(
                        name: "FK_Chat_User",
                        column: x => x.SUser_Id,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "User_Id");
                    table.ForeignKey(
                        name: "FK_Chat_User1",
                        column: x => x.RUser_Id,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehical",
                schema: "dbo",
                columns: table => new
                {
                    Vehical_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    License_No = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Availability_Status = table.Column<bool>(type: "bit", nullable: false),
                    Rental_rate_Per_Hour = table.Column<int>(type: "int", nullable: false),
                    Insurance_Available = table.Column<bool>(type: "bit", nullable: false),
                    Insurance_Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehical_1", x => x.Vehical_Id);
                    table.ForeignKey(
                        name: "FK_Vehical_User",
                        column: x => x.User_Id,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "Damage",
                schema: "dbo",
                columns: table => new
                {
                    Damage_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Booking_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description_Of_Damage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Damage_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Insurance_Coverage = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Total_damage_Cost = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damage_1", x => x.Damage_Id);
                    table.ForeignKey(
                        name: "FK_Damage_Booking",
                        column: x => x.Booking_Id,
                        principalSchema: "dbo",
                        principalTable: "Booking",
                        principalColumn: "Booking_Id");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "dbo",
                columns: table => new
                {
                    Payment_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Booking_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Damage_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total_Payment = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_1", x => x.Payment_Id);
                    table.ForeignKey(
                        name: "FK_Payment_Booking",
                        column: x => x.Booking_Id,
                        principalSchema: "dbo",
                        principalTable: "Booking",
                        principalColumn: "Booking_Id");
                    table.ForeignKey(
                        name: "FK_Payment_User",
                        column: x => x.User_Id,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "Rental_Transaction",
                schema: "dbo",
                columns: table => new
                {
                    Transaction_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Payment_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Transaction_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Payment_Method = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Proof_Of_Payment = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental_Transaction_1", x => x.Transaction_Id);
                    table.ForeignKey(
                        name: "FK_Rental_Transaction_Payment",
                        column: x => x.Payment_Id,
                        principalSchema: "dbo",
                        principalTable: "Payment",
                        principalColumn: "Payment_Id");
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                schema: "dbo",
                columns: table => new
                {
                    Feedback_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Transaction_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Feedback_Id);
                    table.ForeignKey(
                        name: "FK_Feedback_Rental_Transaction",
                        column: x => x.Transaction_Id,
                        principalSchema: "dbo",
                        principalTable: "Rental_Transaction",
                        principalColumn: "Transaction_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_User_Id",
                schema: "dbo",
                table: "Booking",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_RUser_Id",
                schema: "dbo",
                table: "Chat",
                column: "RUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_SUser_Id",
                schema: "dbo",
                table: "Chat",
                column: "SUser_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Damage_Booking_Id",
                schema: "dbo",
                table: "Damage",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_Transaction_Id",
                schema: "dbo",
                table: "Feedback",
                column: "Transaction_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Booking_Id",
                schema: "dbo",
                table: "Payment",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_User_Id",
                schema: "dbo",
                table: "Payment",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_Transaction_Payment_Id",
                schema: "dbo",
                table: "Rental_Transaction",
                column: "Payment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehical_User_Id",
                schema: "dbo",
                table: "Vehical",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chat",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Damage",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Feedback",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Vehical",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Rental_Transaction",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Booking",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User",
                schema: "dbo");
        }
    }
}
