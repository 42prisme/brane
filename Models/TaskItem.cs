using System;
using System.Collections.Generic;

namespace brane.Models
{
    public class TaskItem
    {
        // public TaskItem(string p_label)
        // {
        // Label = p_label;
        // }

        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }
        
        public List<ExigenceItem> Exigences { get; set; }
        public DateTime Planned_start_date { get; set; }
        public DateTime Real_start_date { get; set; }
        public int Cost { get; set; }     //cost in days
    }
}