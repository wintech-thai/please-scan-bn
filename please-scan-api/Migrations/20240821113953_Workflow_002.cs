using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace please_scan_api.Migrations
{
    /// <inheritdoc />
    public partial class Workflow_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkflowTemplates",
                columns: table => new
                {
                    workflow_template_id = table.Column<Guid>(type: "uuid", nullable: false),
                    template_version = table.Column<string>(type: "text", nullable: true),
                    template_name = table.Column<string>(type: "text", nullable: true),
                    template_desc = table.Column<string>(type: "text", nullable: true),
                    variables = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowTemplates", x => x.workflow_template_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowTemplates_template_name",
                table: "WorkflowTemplates",
                column: "template_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkflowTemplates");
        }
    }
}
