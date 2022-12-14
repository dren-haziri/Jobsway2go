using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobsway2go.Infrastructure.Migrations
{
    public partial class AddCollectionDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Jobs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collections_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CollectionId",
                table: "Posts",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CollectionId",
                table: "Jobs",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_UserId",
                table: "Collections",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Collections_CollectionId",
                table: "Jobs",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Collections_CollectionId",
                table: "Posts",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Collections_CollectionId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Collections_CollectionId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CollectionId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CollectionId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Jobs");
        }
    }
}
