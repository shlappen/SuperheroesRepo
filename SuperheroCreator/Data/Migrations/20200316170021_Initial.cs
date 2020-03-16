using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroCreator.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "superheroes",
                columns: table => new
                {
                    SuperheroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AlterEgo = table.Column<string>(nullable: true),
                    PrimarySuperAbility = table.Column<string>(nullable: true),
                    SecondarySuperAbility = table.Column<string>(nullable: true),
                    Catchphrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superheroes", x => x.SuperheroId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "superheroes");
        }
    }
}
