using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusTicket.Data.Migrations
{
    public partial class FirstTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatCount = table.Column<int>(type: "int", nullable: false),
                    SeatCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActivePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginLocationId = table.Column<int>(type: "int", nullable: true),
                    DestinationLocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Route_Location_DestinationLocationId",
                        column: x => x.DestinationLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Route_Location_OriginLocationId",
                        column: x => x.OriginLocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    PassangerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PassangerSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Route_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Route",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_User_CreateUserId",
                        column: x => x.CreateUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Place" },
                values: new object[,]
                {
                    { 1, "İzmir" },
                    { 2, "İstanbul" },
                    { 3, "Ankara" }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Admin" },
                    { 3, "Driver" }
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "Id", "ActivePrice", "AdditionRate", "CreateTime", "CreateUserId", "DestinationLocationId", "OriginLocationId", "Price", "SeatCapacity", "SeatCount", "UpdateTime", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, 1m, 1m, new DateTime(2021, 4, 19, 10, 47, 45, 87, DateTimeKind.Local).AddTicks(983), 2, 2, 1, 100m, 20, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 12m, 2m, new DateTime(2021, 4, 19, 10, 47, 45, 88, DateTimeKind.Local).AddTicks(6454), 1, 1, 2, 33m, 20, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 13m, 3m, new DateTime(2021, 4, 19, 10, 47, 45, 88, DateTimeKind.Local).AddTicks(6484), 3, 3, 3, 44m, 20, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname", "UserTypeId" },
                values: new object[,]
                {
                    { 1, "1@mail", "ali", "123", "kalem", 1 },
                    { 2, "2@mail", "mehmet", "123", "patates", 1 },
                    { 3, "3@mail", "ahmet", "123", "kağıt", 2 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "CreateTime", "CreateUserId", "IsActive", "PassangerName", "PassangerSurname", "Price", "RouteId", "SeatNumber", "UpdateTime", "UpdateUserId" },
                values: new object[] { 1, new DateTime(2021, 4, 19, 10, 47, 45, 90, DateTimeKind.Local).AddTicks(76), 1, true, "ali", "kalem", 100m, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "CreateTime", "CreateUserId", "IsActive", "PassangerName", "PassangerSurname", "Price", "RouteId", "SeatNumber", "UpdateTime", "UpdateUserId" },
                values: new object[] { 2, new DateTime(2021, 4, 19, 10, 47, 45, 90, DateTimeKind.Local).AddTicks(1626), 2, true, "mehmet", "patates", 33m, 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "CreateTime", "CreateUserId", "IsActive", "PassangerName", "PassangerSurname", "Price", "RouteId", "SeatNumber", "UpdateTime", "UpdateUserId" },
                values: new object[] { 3, new DateTime(2021, 4, 19, 10, 47, 45, 90, DateTimeKind.Local).AddTicks(1639), 3, true, "ahmet", "kağıt", 44m, 3, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Route_DestinationLocationId",
                table: "Route",
                column: "DestinationLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_OriginLocationId",
                table: "Route",
                column: "OriginLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CreateUserId",
                table: "Ticket",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_RouteId",
                table: "Ticket",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeId",
                table: "User",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
