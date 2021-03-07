using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace brane.Models
{
    public class JalonItem
    {
        public int Id { get; set; }
        [Required] public string Label { get; set; }

        public DateTime PlannedStartDate { get; set; }
        public DateTime RealEndDate { get; set; }
        
        [Required] public int AssigneeId { get; set; }
        
        [Required] public int ProjectId { get; set; }
    }
}