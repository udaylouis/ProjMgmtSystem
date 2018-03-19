using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Common;

namespace ProjectManagement.DataEntity
{
    public class Story
    {
        public Story()
        {
            StoryDescription = string.Empty;
            StoryName = string.Empty;
            CreatorUserName = string.Empty;
            CreatorDisplayName = string.Empty;
            AssignedTo = string.Empty;
            AssignedToDisplayName = string.Empty;
            Tasks = new List<Task>();
        }
        public int StoryId { get; set; }

        public string StoryName { get; set; }

        public string StoryDescription { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatorUserName { get; set; }

        public string CreatorDisplayName { get; set; }

        public string AssignedTo { get; set; }

        public string AssignedToDisplayName { get; set; }

        public List<Task> Tasks { get; set; }

        public Enums.Status StoryStatus { get; set; }

        public string TStoryLastModifiedBy { get; set; }

        public DateTime StoryLastModifiedDate { get; set; }
    }
}
