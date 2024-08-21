using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace please_scan_api.Migrations
{
    /// <inheritdoc />
    public partial class Workflow_003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "flow_type",
                table: "WorkflowTemplates",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "flow_type",
                table: "WorkflowTemplates");
        }
    }
}
