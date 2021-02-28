using System.Collections.Generic;
using brane.Models;
using Microsoft.Extensions.Logging;

namespace brane.Service
{
    public class ProjectService : IProjectService
    {
        // private readonly ILogger<ProjectService> _logger;
        private List<ProjectItem> prl;


        public ProjectService() //ILogger<ProjectService> logger
        {
            // _logger = logger;
        }

        public ProjectItem GetOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProjectItem> GetIn()
        {
            throw new System.NotImplementedException();
        }

        public List<ProjectItem> GetAll()
        {
            // _logger.Log(LogLevel.Warning,"add project Item Man");
            prl = new List<ProjectItem>();
            prl.Add(new ProjectItem("un"));
            prl.Add(new ProjectItem("deux"));
            prl.Add(new ProjectItem("trois"));
            return this.prl;
        }

        public void Add(ProjectItem item)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(ProjectItem item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}