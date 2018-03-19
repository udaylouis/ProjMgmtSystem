using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Common;


namespace ProjectManagement.DataEntity
{
    public class Task
    {
        public Task()
        {
            TaskDescription = string.Empty;
            TaskName = string.Empty;
            CreatorUserName = string.Empty;
            CreatorDisplayName = string.Empty;
            AssignedTo = string.Empty;
            AssignedToDisplayName = string.Empty;
        }
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public string TaskDescription { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatorUserName { get; set; }

        public string CreatorDisplayName { get; set; }

        public string AssignedTo { get; set; }

        public string AssignedToDisplayName { get; set; }

        public Enums.Status TaskStatus { get; set; }

        public string TaskLastModifiedBy { get; set; }

        public DateTime TaskLastModifiedDate { get; set; }
    }
}
