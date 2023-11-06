using System.Collections.Generic;

namespace EmpApi.Models
{
    public interface IDept
    {
        List<Department> GetDepartments();
        Department FindDepartment(int id);
        void AddDept(Department d);
        void EditDept (Department d);
        void DeleteDept(int id);
    }
}