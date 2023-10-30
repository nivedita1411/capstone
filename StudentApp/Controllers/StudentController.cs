using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;
using System.Data;
using System.Data.SqlClient;
namespace StudentApp.Controllers;

public class StudentController: Controller
{
    public IActionResult List()
    {
        string constr = "User ID=sa;password=examlyMssql@123; server=localhost;Database=MyDatabaseNY;trusted_connection=false;Persist Security Info=False;Encrypt=False";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand command = new SqlCommand ("select * from Student",con);
        con.Open();
        SqlDataReader reader = command.ExecuteReader();
        DataTable stdTable = new DataTable();
        stdTable.Load(reader);
        return View(stdTable);
    }
}