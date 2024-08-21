using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;
using System.Diagnostics.CodeAnalysis;

namespace Its.PleaseScan.Api.Models
{
    [ExcludeFromCodeCoverage]
    [Table("WorkflowTemplates")]
    [Index(nameof(TemplateName), IsUnique = true)]
    public class MWorkflowTemplate
    {
        [Key]
        [Column("workflow_template_id")]
        public Guid? WorkflowTemplateId { get; set; }
    
        [Column("template_version")]
        public string? TemplateVersion { get; set; }

        [Column("template_name")]
        public string? TemplateName { get; set; }

        [Column("template_desc")]
        public string? TemplateDesc { get; set; }

        [Column("variables")]
        public string? Variables { get; set; }

        [Column("created_date")]
        public DateTime? CreatedDate { get; set; }
        
        [Column("flow_type")]
        public string? FlowType { get; set; }

        public MWorkflowTemplate()
        {
            WorkflowTemplateId = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
        }
    }
}
