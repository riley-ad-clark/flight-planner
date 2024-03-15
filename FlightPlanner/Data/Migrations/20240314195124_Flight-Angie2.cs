using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class FlightAngie2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BookingDetails",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BookingDetails",
                newName: "UserId");
        }
    }
}
