using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Common
{
    public class Enums
    {
        public enum ProjectAccessType
        {
            None = 0,
            Public = 1,
            Private = 2
        }

        public enum StoryVisibility
        {
            Public = 0,
            Private = 1
        }

        public enum TaskVisibility
        {
            Public = 0,
            Private = 1
        }

        public enum Status
        {
            Unassigned = 0,
            Assigned = 1,
            InProgress = 2,
            Completed = 3,
            Closed = 4,
            Canceled = 5,
            OnHold = 6

        }

        public enum Priority
        { 
            Critical = 0,
            High = 1,
            Medium = 2,
            Low = 3
        }
    }
}
