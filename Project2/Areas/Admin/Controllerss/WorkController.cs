using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PagedList;
using Project2.Data;
using Project2.Models;
using X.PagedList;
using System.Web;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http.Extensions;

namespace Project2.Areas.Admin.Controllerss
{
    [Authorize]
    [Area("Admin")]
    public class WorkController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ViewResult Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            
            ViewBag.CurrentSort = sortOrder;
            ViewBag.CurrentFilter = currentFilter;
            ViewBag.CurrentPage = pageNumber;
            ViewBag.EmployeeSort = String.IsNullOrEmpty(sortOrder) ? "EmployeeNumber" : "";

            string Cookievalue;
            Cookievalue =Request.Cookies["Index"];


            var PersonID = (_context.Users.Where(x=>x.Email == User.Identity.Name).Select(x => x.Id));
            var person = PersonID.ToList()[0];

            

            var ISAdmin = _context.UserRoles.Where(x =>x.UserId == person).Select(x=>x.RoleId);
            ViewBag.Admin = JsonConvert.SerializeObject(ISAdmin);

            var employees = from s in _context.Employee
                           select s;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurreFilter = searchString;



            var roles = from f in _context.UserRoles
                        select f;

            if(roles != null)
            {
                ViewBag.role = roles.Where(f => f.UserId == User.Identity.Name);
            }
            else
            {
                ViewBag.role = "User";
            }




            if (searchString != null)
            {
                employees = employees.Where(s => s.EmployeeNumber ==(Int32.Parse(searchString)));
            }


            switch (sortOrder)
            {
                case "EmployeeNumber":
                    employees = employees.OrderBy(s => s.EmployeeNumber);
                    break;
                case "Years at Company":
                    employees = employees.OrderBy(s => s.YearsAtCompany);
                    break;
                case "Current Role":
                    employees = employees.OrderByDescending(s => s.YearsInCurrentRole);
                    break;
                default:
                    employees = employees.OrderBy(s => s.DailyRate);
                    break;
            }
            int pageSize = 10;
            int page = (pageNumber ?? 1);
            return View(employees.ToPagedList(page, pageSize));
        }



        public ViewResult Info(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {

            ViewBag.CurrentSort = sortOrder;
            ViewBag.CurrentFilter = currentFilter;
            ViewBag.CurrentPage = pageNumber;
            ViewBag.EmployeeSort = String.IsNullOrEmpty(sortOrder) ? "EmployeeNumber" : "";

            string Cookievalue;
            Cookievalue = Request.Cookies["Info"];


            var employees = from s in _context.Employee
                            select s;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurreFilter = searchString;




            if (searchString != null)
            {
                employees = employees.Where(s => s.EmployeeNumber == (Int32.Parse(searchString)));
            }


            switch (sortOrder)
            {
                case "EmployeeNumber":
                    employees = employees.OrderBy(s => s.EmployeeNumber);
                    break;
                case "Years at Company":
                    employees = employees.OrderBy(s => s.YearsAtCompany);
                    break;
                case "Current Role":
                    employees = employees.OrderByDescending(s => s.YearsInCurrentRole);
                    break;
                default:
                    employees = employees.OrderBy(s => s.DailyRate);
                    break;
            }
            int pageSize = 10;
            int page = (pageNumber ?? 1);
            return View(employees.ToPagedList(page, pageSize));
        }




        // GET: Admin/Work/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employee == null)
            {
                return NotFound();
            }
            var PersonID = (_context.Users.Where(x => x.Email == User.Identity.Name).Select(x => x.Id));
            var person = PersonID.ToList()[0];



            var ISAdmin = _context.UserRoles.Where(x => x.UserId == person).Select(x => x.RoleId);
            ViewBag.Admin = JsonConvert.SerializeObject(ISAdmin);
            return View(employee);
        }

        // GET: Admin/Work/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Work/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            var PersonID = (_context.Users.Where(x => x.Email == User.Identity.Name).Select(x => x.Id));
            var person = PersonID.ToList()[0];



            var ISAdmin = _context.UserRoles.Where(x => x.UserId == person).Select(x => x.RoleId);
            ViewBag.Admin = JsonConvert.SerializeObject(ISAdmin);

            return View(employee);
        }

        // GET: Admin/Work/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            var PersonID = (_context.Users.Where(x => x.Email == User.Identity.Name).Select(x => x.Id));
            var person = PersonID.ToList()[0];



            var ISAdmin = _context.UserRoles.Where(x => x.UserId == person).Select(x => x.RoleId);
            ViewBag.Admin = JsonConvert.SerializeObject(ISAdmin);
            return View(employee);
        }

        // POST: Admin/Work/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Employee employee)
        {
            if (id != employee.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            var PersonID = (_context.Users.Where(x => x.Email == User.Identity.Name).Select(x => x.Id));
            var person = PersonID.ToList()[0];



            var ISAdmin = _context.UserRoles.Where(x => x.UserId == person).Select(x => x.RoleId);
            ViewBag.Admin = JsonConvert.SerializeObject(ISAdmin);
            return View(employee);
        }

        // GET: Admin/Work/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employee == null)
            {
                return NotFound();
            }
            var PersonID = (_context.Users.Where(x => x.Email == User.Identity.Name).Select(x => x.Id));
            var person = PersonID.ToList()[0];



            var ISAdmin = _context.UserRoles.Where(x => x.UserId == person).Select(x => x.RoleId);
            ViewBag.Admin = JsonConvert.SerializeObject(ISAdmin);
            return View(employee);
        }

        // POST: Admin/Work/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();

            var PersonID = (_context.Users.Where(x => x.Email == User.Identity.Name).Select(x => x.Id));
            var person = PersonID.ToList()[0];



            var ISAdmin = _context.UserRoles.Where(x => x.UserId == person).Select(x => x.RoleId);
            ViewBag.Admin = JsonConvert.SerializeObject(ISAdmin);

            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeNumber == id);
        }

    }
}
