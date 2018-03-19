using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using ProjectManagement.DataEntity;

namespace ProjectManagement.DAL
{  
        public abstract partial class DataProvider : ProviderBase
        {           
            public abstract bool SupportsProjectCloning { get; } 
            public abstract string ConnectionString { get; }       


            // Story
            public abstract bool DeleteStory(int StoryId);
            public abstract List<Story> GetStorysByProjectId(int projectId);
            public abstract Story GetStoryById(int StoryId);
            public abstract bool UpdateStory(Story StoryToUpdate);
            public abstract int CreateNewStory(Story StoryToCreate);
            public abstract List<Story> GetStorysByRelevancy(int projectId, string username);
            public abstract List<Story> GetStorysByAssignedUserName(int projectId, string assignedUserName);
            public abstract List<Story> GetStorysByCreatorUserName(int projectId, string creatorUserName);
            public abstract List<Story> GetStorysByOwnerUserName(int projectId, string creatorUserName);
            public abstract List<Story> GetOpenStorys(int projectId);
            public abstract bool UpdateStoryLastUpdated(int StoryId, string lastUpdatedUsername);

            // StoryComments
            public abstract int CreateNewStoryComment(StoryComment newComment);
            public abstract List<StoryComment> GetStoryCommentsByStoryId(int StoryId);
            public abstract bool DeleteStoryCommentById(int commentId);
            public abstract bool UpdateStoryComment(StoryComment StoryCommentToUpdate);
            public abstract StoryComment GetStoryCommentById(int StoryCommentId);
       
            // StoryHistory
            public abstract List<StoryHistory> GetStoryHistoryByStoryId(int StoryId);
            public abstract int CreateNewStoryHistory(StoryHistory newHistory);
           

            // Project
            public abstract int CreateNewProject(Project newProject);
            public abstract bool DeleteProject(int projectId);
            public abstract List<Project> GetAllProjects(bool? activeOnly = true);
            public abstract Project GetProjectById(int projectId);
            public abstract List<Project> GetProjectsByMemberUserName(string username);
            public abstract List<Project> GetProjectsByMemberUserName(string userName, bool activeOnly);
            public abstract bool UpdateProject(Project projectToUpdate);
            public abstract bool AddUserToProject(string userName, int projectId);
            public abstract bool RemoveUserFromProject(string userName, int projectId);
            public abstract int CloneProject(int projectId, string projectName, string creatorUserName = "");
            public abstract Project GetProjectByCode(string projectCode);
            public abstract List<Project> GetPublicProjects();
            public abstract bool IsUserProjectMember(string userName, int projectId);
            public abstract int[] GetProjectRoadmapProgress(int projectId, int milestoneId);
            public abstract List<UserRoles> GetProjectMembersRoles(int projectId);
            public abstract bool DeleteProjectImage(int projectId);         
          

            // Users
            public abstract List<User> GetUsersByProjectId(int projectId);
            public abstract List<User> GetUsersByProjectId(int projectId, bool excludeReadOnlyUsers);
            public abstract string GetUserNameByPasswordResetToken(string token);           

          
        }
    }
