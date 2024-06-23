using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LOGIN.Migrations
{
    /// <inheritdoc />
    public partial class updateUserIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordResetToken",
                schema: "Security",
                table: "users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordResetTokenExpires",
                schema: "Security",
                table: "users",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                schema: "Security",
                table: "users");

            migrationBuilder.DropColumn(
                name: "PasswordResetTokenExpires",
                schema: "Security",
                table: "users");
        }
    }
}
