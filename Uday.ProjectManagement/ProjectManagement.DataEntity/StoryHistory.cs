﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.DataEntity
{
    public class StoryHistory
    {
        public StoryHistory()
        {
            CreatedUserName = string.Empty;
            CreatorDisplayName = string.Empty;
            DateChanged = DateTime.Now;
            NewValue = string.Empty;
            OldValue = string.Empty;
            TriggerLastUpdateChange = false;
        }
             
        public int Id { get; set; }
        public int StoryId { get; set; }
        public string CreatedUserName { get; set; }      
        public string FieldChanged { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateChanged { get; set; }
        public string CreatorDisplayName { get; set; }
        public bool TriggerLastUpdateChange { get; set; }
    }
}
