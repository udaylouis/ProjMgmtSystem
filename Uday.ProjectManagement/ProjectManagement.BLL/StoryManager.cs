using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.DataEntity;

namespace ProjectManagement.BLL
{
    public static class StoryManager
    {

        /// <summary>
        /// Saves the issue
        /// </summary>
        /// <param name="entity">The issue to save.</param>
        /// <returns></returns>
        public static bool SaveOrUpdate(Story entity)
        {

            try
            {
                return true;
            }
          
            catch (Exception ex)
            {               
                return false;
            }
        }
      
        private static void UpdateHistory(IEnumerable<StoryHistory> issueChanges)
        {
           //TODO
        }

        public static List<StoryHistory> GetIssueChanges(Story originalStory, Story storyToCompare)
        {          

            return new List<StoryHistory>();
        }



       
    }
}
