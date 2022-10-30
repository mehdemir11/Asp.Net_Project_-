using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access_Layer.Migrations
{
    public partial class mig_testimonials_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    testimonialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    testimonialClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    testimonialCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    testimonialComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    testimonialImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    testimonialTask = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.testimonialID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
