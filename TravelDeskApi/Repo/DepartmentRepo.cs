using Microsoft.EntityFrameworkCore;
using TravelDeskApi.Context;
using TravelDeskApi.IRepo;
using TravelDeskApi.Models;

namespace TravelDeskApi.Repo
{
    public class DepartmentRepo :IDepartmentRepo
    {
        TravelDbContext _travelDbContext;
        public DepartmentRepo(TravelDbContext travelDbContext)
        {
            _travelDbContext = travelDbContext;
        }

        public Department ADDDepartment(Department department)
        {
            _travelDbContext.Departments.Add(department);
            _travelDbContext.SaveChanges();
            return department;
        }

        //public Department ADDepartment(Department department)
        //{
        //    _travelDbContext.Departments.Add(department);
        //    _travelDbContext.SaveChanges();
        //    return department;
        //}

        //public bool DELETEDepartment(int departmentid)
        //{
        //    Department dpt = GetDepartmentById(departmentid);
        //    if (dpt != null)
        //    {
        //        _travelDbContext.Remove(dpt);
        //        _travelDbContext.SaveChanges();
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        public Department GetDepartmentById(int id)
        {
            var dept = _travelDbContext.Departments.FirstOrDefault(x => x.DepartmentId == id);
            return dept;
        }

        //public List<Department> GetDepartments()
        //{
        //    return _travelDbContext.Departments.ToList();
        //}

        public List<Department> GetDepartments(Department department)
        {
            return _travelDbContext.Departments.ToList();
        }

        //public bool UpdateDepartment(int DepartmentId, Department department)
        //{
        //    Department dpt = GetDepartmentById(DepartmentId);
        //    if (dpt != null)
        //    {
        //        dpt.DepartmentId = department.DepartmentId;
        //        _travelDbContext.SaveChanges();
        //        return true;
        //    }
        //    else
        //        return false;

        //}

        Department IDepartmentRepo.DELETEDepartment(int departmentid)
        {
            Department dpt = GetDepartmentById(departmentid);
            if (dpt != null)
            {
                _travelDbContext.Remove(dpt);
                _travelDbContext.SaveChanges();
                return dpt;
            }
            else
                return dpt = null;
               
        }

        Department IDepartmentRepo.UpdateDepartment(int DepartmentId, Department department)
        {
            Department dpt = GetDepartmentById(DepartmentId);
            if (dpt != null)
            {
                dpt.DepartmentId = department.DepartmentId;
                _travelDbContext.SaveChanges();
                return dpt;
            }
            else
                return dpt = null;
        }
    }
}
