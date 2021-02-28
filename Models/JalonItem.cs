using System;
using System.Collections.Generic;

namespace brane.Models
{
    public class JalonItem
    {
        public JalonItem(string p_label, DateTime p_planned_start_date) 
        {
            this.m_label = p_label;
            this.m_planned_start_date = p_planned_start_date;
        }
        public string m_label { get; set; }

        public DateTime m_planned_start_date { get; set; }

        public User m_assignee { get; set; }

        public DateTime m_real_end_date { get; set; }

        public List<TaskItem> m_tasks { get; set; }

        public void add_task(TaskItem pTaskItem)
        {
            m_tasks.Add(pTaskItem);
        }
    }
}