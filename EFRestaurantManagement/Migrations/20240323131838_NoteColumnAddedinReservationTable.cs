﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFRestaurantManagement.Migrations
{
    /// <inheritdoc />
    public partial class NoteColumnAddedinReservationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Reservations");
        }
    }
}
