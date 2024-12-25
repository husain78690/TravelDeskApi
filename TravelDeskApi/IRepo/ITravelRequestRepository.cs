using TravelDeskApi.Models;
using TravelDeskApi.ViewModels;

namespace TravelDeskApi.IRepo
{
    public interface ITravelRequestRepository
    {
        List<TravelRequest> GetTravelRequest();

        TravelRequest GetTravelRequestById(int id);
        TravelRequest ADDTravelRequest(TravelRequest travelRequest);
        TravelRequest UpdateTravelRequest(int Id, TravelRequest travelRequest);
        TravelRequest DELETEDTravelRequest(int trvalId);
        
    }
    public interface IDepartmentRepo
    {
        List<Department> GetDepartments();
        Department GetDepartmentById(int id);
        Department ADDDepartment(Department department);
        Department UpdateDepartment(int DepartmentId, Department department);
        Department DELETEDepartment(int departmentid);
            

    }
    public interface IProjectsRepo
    {
        List<Project> GetProjects();
        Project GetProjectsByid(int id);
        Project AddProject(Project project);
        Project UpdateProjects(int Id, Project project);
        Project DELETEProject(int id);



    }
    public interface IAuthenticateRepository
    {
        User AuthenticateUser(LoginViewModel loginViewModel);
    }

}
