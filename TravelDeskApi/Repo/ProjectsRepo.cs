using TravelDeskApi.Context;
using TravelDeskApi.IRepo;
using TravelDeskApi.Models;

namespace TravelDeskApi.Repo
{
    public class ProjectsRepo :IProjectsRepo
    {
        TravelDbContext _travelDbContext;
        public ProjectsRepo(TravelDbContext travelDbContext)
        {
            _travelDbContext = travelDbContext;
        }
        public Project AddProject(Project project)
        {
            _travelDbContext.Projects.Add(project);
            _travelDbContext.SaveChanges();
            return project;
        }

        public List<Project> GetProjects()
        {
           return _travelDbContext.Projects.ToList();
            
        }

        public Project GetProjectsByid(int id)
        {
            var project = _travelDbContext.Projects.FirstOrDefault(x => x.ProjectId == id);
            return project;
        }

        //public Project UpdateProjects(int Id,Project project)
        //{
        //    Project pgt = GetProjectsByid(Id);
        //    if (pgt != null)
        //    {
        //        pgt.ProjectId = Id;
        //        _travelDbContext.SaveChanges();
        //        return pgt;
        //    }
        //    else
        //        return pgt = null;
        //}

        public Project UpdateProjects(int Id,Project project)
        {
            Project pgt = GetProjectsByid(Id);
            if (pgt != null)
            {
                pgt.ProjectId = Id;
                _travelDbContext.SaveChanges();
                return pgt;
            }
            else
                return pgt = null;
        }
        public Project DELETEProject(int id) 
         {
            Project dpt = GetProjectsByid(id);
            if (dpt != null)
            {
                _travelDbContext.Remove(dpt);
                _travelDbContext.SaveChanges();
                return dpt;
            }
            else
                return dpt = null;

        }
    }
}
