using System.Collections.Generic;
using brane.Service;

namespace brane.Models
{
    public class ProjectItem
    {
        public ProjectItem(string p_label)
        {
            m_name = p_label;
        }

        public int m_id { get; set; }
        public string m_name { get; set; }
        public User m_assignee { get; set; }

        public List<JalonItem> m_jalons;
    }
}