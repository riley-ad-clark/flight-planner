using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class FlightAngie1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookingDetails");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BookingDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BookingDetails");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookingDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
