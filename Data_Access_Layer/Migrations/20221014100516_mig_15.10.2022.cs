using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access_Layer.Migrations
{
    public partial class mig_15102022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMessages");

            migrationBuilder.DropTable(
                name: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    userImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userNickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userSecName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "UserMessages",
                columns: table => new
                {
                    messageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    messageContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    messageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessages", x => x.messageID);
                    table.ForeignKey(
                        name: "FK_UserMessages_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_userID",
                table: "UserMessages",
                column: "userID");
        }
    }
}
