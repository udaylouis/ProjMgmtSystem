using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Common;

namespace ProjectManagement.DataEntity
{
    public class Project
    {
        public Project()
        {
            ProjectDescription = string.Empty;
            ProjectName = string.Empty;
            AccessType = Enums.ProjectAccessType.None;
            CreatorUserName = string.Empty;
            CreatorDisplayName = string.Empty;
            Stories = new List<Story>();
        }
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string ProjectDescription { get; set; }

        public DateTime DateCreated { get; set; }

        public Guid ManagerId { get; set; }

        public string CreatorUserName { get; set; }

        public string CreatorDisplayName { get; set; }

        public Enums.ProjectAccessType AccessType { get; set; }

        public Enums.Status ProjectStatus { get; set; }

        public List<Story> Stories { get; set; }


    }
}
