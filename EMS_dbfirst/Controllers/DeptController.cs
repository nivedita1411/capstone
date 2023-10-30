using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EMS_dbfirst.Models;
public class DeptController : Controller
{
    private readonly EmsdatabaseContext context;
    public DeptController(EmsdatabaseContext _context)
    {
        context= _context;
    }
}


