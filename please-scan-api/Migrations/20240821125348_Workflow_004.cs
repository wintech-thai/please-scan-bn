using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace please_scan_api.Migrations
{
    /// <inheritdoc />
    public partial class Workflow_004 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workflows",
                columns: table => new
                {
                    workflow_id = table.Column<Guid>(type: "uuid", nullable: false),
                    workflow_name = table.Column<string>(type: "text", nullable: true),
                    workflow_desc = table.Column<string>(type: "text", nullable: true),
                    variables = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    org_id = table.Column<string>(type: "text", nullable: true),
                    template_id = table.Column<Guid>(type: "uuid", nullable: true),
                    template_name = table.Column<string>(type: "text", nullable: true),
                    flow_type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflows", x => x.workflow_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workflows_workflow_name",
                table: "Workflows",
                column: "workflow_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workflows");
        }
    }
}
