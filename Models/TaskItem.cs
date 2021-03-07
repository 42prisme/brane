using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace brane.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required] public string Label { get; set; }
        [Required] public string Description { get; set; }

        [Required] public int AssigneeId { get; set; }

        [Required] public int ExigencesId { get; set; }

        [Required] public int JalonId { get; set; }

        [AllowNull] public DateTime Planned_start_date { get; set; }
        [AllowNull] public DateTime Real_start_date { get; set; }
        
        [Required] public int Cost { get; set; }     //cost in days
    }
}