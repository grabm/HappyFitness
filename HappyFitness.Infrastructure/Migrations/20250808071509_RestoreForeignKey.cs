using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyFitness.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RestoreForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSessions_User_UserId",
                table: "WorkoutSessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSessions_User_UserId",
                table: "WorkoutSessions"
                );
        }
    }
}
