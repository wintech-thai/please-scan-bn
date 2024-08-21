using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;
using System.Diagnostics.CodeAnalysis;

namespace Its.PleaseScan.Api.Models
{
    [ExcludeFromCodeCoverage]
    [Table("Workflows")]
    [Index(nameof(WorkflowName), IsUnique = true)]
    public class MWorkFlow
    {
        [Key]
        [Column("workflow_id")]
        public Guid? WorkflowId { get; set; }

        [Column("workflow_name")]
        public string? WorkflowName { get; set; }

        [Column("workflow_desc")]
        public string? WorkflowDesc { get; set; }
    
        [Column("variables")]
        public string? Variables { get; set; }

        [Column("created_date")]
        public DateTime? CreatedDate { get; set; }
    
        [Column("org_id")]
        public string? OrgId { get; set; }

        // Begin fields from WorkflowTemplates
        [ForeignKey(nameof(MWorkflowTemplate))]
        [Column("template_id")]
        public Guid? TemplateId { get; set; }

        [Column("template_name")]
        public string? TemplateName { get; set; }

        [Column("flow_type")]
        public string? FlowType { get; set; }
        // End fields from WorkflowTemplates

        public MWorkFlow()
        {
            WorkflowId = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
        }
    }
}
