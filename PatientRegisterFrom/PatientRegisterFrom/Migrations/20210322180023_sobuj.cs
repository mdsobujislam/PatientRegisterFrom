using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientRegisterFrom.Migrations
{
    public partial class sobuj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    visitDate = table.Column<DateTime>(type: "date", nullable: false),
                    firstName = table.Column<string>(nullable: false),
                    surName = table.Column<string>(maxLength: 10, nullable: false),
                    bloodGroup = table.Column<string>(nullable: false),
                    bodyWeight = table.Column<string>(nullable: true),
                    age = table.Column<string>(nullable: false),
                    homeAddress = table.Column<string>(maxLength: 200, nullable: false),
                    sex = table.Column<string>(nullable: false),
                    workAddress = table.Column<string>(maxLength: 200, nullable: false),
                    maritalStatus = table.Column<string>(nullable: false),
                    kinName = table.Column<string>(maxLength: 50, nullable: false),
                    kinPhoneNo = table.Column<string>(maxLength: 11, nullable: false),
                    kinAddress = table.Column<string>(maxLength: 200, nullable: false),
                    disability = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registers");
        }
    }
}
