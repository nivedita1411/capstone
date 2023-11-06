using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmpApi.Models
{
    public class DepartmentRepository: IDept
    {
        EmsdatabaseContext context = new EmsdatabaseContext();
        public void AddDept(Department d)
        {
            context.Departments.Add(d);
            context.SaveChanges();
        }

        public void DeleteDept(int id)
        {
            Department d = context.Departments.Find(id);
            context.Departments.Remove(d);
            context.SaveChanges();

        }

        public void EditDept(Department d)
        {
            Department dept = context.Departments.Find(d.Id);
            dept.DeptName = d.DeptName;
            dept.Location = d.Location;
            context.SaveChanges();
        }

        public Department FindDept(int id)
        {
            var data = context.Departments.Find(id);
            return data;
        }

        public List<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }
    }
}