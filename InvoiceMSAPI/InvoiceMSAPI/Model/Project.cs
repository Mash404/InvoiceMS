using System.ComponentModel.DataAnnotations;

namespace InvoiceMSAPI.Model
{
    public class Project
    {
        [Key] public int projectId { get; set; }
        
        public string projectName { get; set; } = string.Empty;

        public string projectDescription { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        public string projectCost { get; set; } = string.Empty;

    }
}
