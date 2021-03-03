using System;
using System.Collections.Generic;

namespace brane.Models
{
    public class JalonItem
    {
        // public JalonItem(string plabel, DateTime pplannedStartDate, DateTime pRealEndDate) 
        // {
        //     this.Label = plabel;
        //     this.PlannedStartDate = pplannedStartDate;
        //     this.RealEndDate = pRealEndDate;
        // }
        public int Id { get; set; }

        public string Label { get; set; }

        public DateTime PlannedStartDate { get; set; }

        public User Assignee { get; set; }

        public DateTime RealEndDate { get; set; }

        public List<TaskItem> Tasks { get; set; }

        // public void add_task(TaskItem pTaskItem)
        // {
        //     m_tasks.Add(pTaskItem);
        // }
    }
}