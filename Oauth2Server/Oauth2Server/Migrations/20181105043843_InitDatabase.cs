using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oauth2Server.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisteredClient",
                columns: table => new
                {
                    ClientId = table.Column<string>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    ClientDomain = table.Column<string>(nullable: true),
                    ClientIcon = table.Column<string>(nullable: true),
                    RedirectUrl = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAd = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredClient", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisteredClient");
        }
    }
}
