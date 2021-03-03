using System.Collections.Generic;
using brane.Service;

namespace brane.Models
{
    public class ProjectItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Assignee { get; set; }

        public List<JalonItem> Jalons;
    }
}