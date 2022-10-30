using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access_Layer.Migrations
{
    public partial class mig_todolist_squad_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    memberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    memberFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    memberTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    memberImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectProgress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.memberID);
                });

            migrationBuilder.CreateTable(
                name: "ToDoLists",
                columns: table => new
                {
                    jobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jobContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoLists", x => x.jobID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.DropTable(
                name: "ToDoLists");
        }
    }
}
