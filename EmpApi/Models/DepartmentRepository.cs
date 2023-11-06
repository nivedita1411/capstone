using System.Collections.Generic;
using System.Linq;

namespace EmpApi.Models
{
    public class DepartmentRepository:IDept
    {
        EmsdatabaseContext context = new EmsdatabaseContext();
        public void AddDept(Department d)
        {
            context.Departments.Add(d);
            context.SaveChanges();
        }

        public void DeleteDept(int id)
        {
            
        }
    }
}