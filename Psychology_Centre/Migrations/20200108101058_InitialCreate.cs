using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Psychology_Centre.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Midname = table.Column<string>(nullable: true),
                    IsSpecial = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumberFirst = table.Column<string>(maxLength: 11, nullable: true),
                    PhoneNumberSecond = table.Column<string>(maxLength: 11, nullable: true),
                    PhoneNumberUnformat = table.Column<string>(nullable: true),
                    PhoneNumberOther = table.Column<string>(nullable: true),
                    IdFacebook = table.Column<string>(nullable: true),
                    ComfyCallTime = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    FamilyStatus = table.Column<string>(nullable: true),
                    IsHaveChildren = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    FieldOfActivity = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Metro = table.Column<string>(nullable: true),
                    SelectionFactors = table.Column<string>(nullable: true),
                    Activity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
