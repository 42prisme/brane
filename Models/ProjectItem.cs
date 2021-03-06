using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using brane.Service;

namespace brane.Models
{
    public class ProjectItem
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int AssigneeId { get; set; }
    }
}