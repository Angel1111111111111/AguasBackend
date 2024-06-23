using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LOGIN.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReportForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reporrt",
                schema: "reports",
                table: "report",
                newName: "Report");

            migrationBuilder.RenameColumn(
                name: "Observztion",
                schema: "reports",
                table: "report",
                newName: "Observation");

            migrationBuilder.AddColumn<Guid>(
                name: "state_id",
                schema: "reports",
                table: "report",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_report_state_id",
                schema: "reports",
                table: "report",
                column: "state_id");

            migrationBuilder.AddForeignKey(
                name: "FK_report_state_state_id",
                schema: "reports",
                table: "report",
                column: "state_id",
                principalSchema: "reports",
                principalTable: "state",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_report_state_state_id",
                schema: "reports",
                table: "report");

            migrationBuilder.DropIndex(
                name: "IX_report_state_id",
                schema: "reports",
                table: "report");

            migrationBuilder.DropColumn(
                name: "state_id",
                schema: "reports",
                table: "report");

            migrationBuilder.RenameColumn(
                name: "Report",
                schema: "reports",
                table: "report",
                newName: "Reporrt");

            migrationBuilder.RenameColumn(
                name: "Observation",
                schema: "reports",
                table: "report",
                newName: "Observztion");
        }
    }
}
