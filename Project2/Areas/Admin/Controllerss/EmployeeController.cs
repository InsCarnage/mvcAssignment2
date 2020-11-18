using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SQLitePCL;
using Project2.Models;
using System.Collections.Specialized;
using System.Web;
using System.Web.Mvc;

namespace Project2.Areas.Admin.Controllerss
{
    [Area("Admin")]
    public class EmployeeController : Microsoft.AspNetCore.Mvc.Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Job()
        {
            return View();
        }


    }
}

