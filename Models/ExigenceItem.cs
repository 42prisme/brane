using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace brane.Models
{
    public class ExigenceItem
    {
        enum Exigence_Type {
            BDD,
            IHM,
            PERF
        }

        public int Id { get; set; }
        [Required] public string Label { get; set; }
        
        [Required] public int ProjectId { get; set; }
        [NotMapped] public ProjectItem Project { get; set; }
    }
}