using System.Diagnostics.CodeAnalysis;
using Its.PleaseScan.Api.Models;

namespace Its.PleaseScan.Api.ModelsViews
{
    [ExcludeFromCodeCoverage]
    public class MVOrganization
    {
        public string? Status { get; set; }
        public string? Description { get; set; }
        public MOrganization? Organization { get; set; }
    }
}
