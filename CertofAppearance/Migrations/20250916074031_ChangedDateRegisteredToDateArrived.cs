using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertofAppearance.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDateRegisteredToDateArrived : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateRegistered",
                table: "Clients",
                newName: "DateArrived");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateArrived",
                table: "Clients",
                newName: "DateRegistered");
        }
    }
}
