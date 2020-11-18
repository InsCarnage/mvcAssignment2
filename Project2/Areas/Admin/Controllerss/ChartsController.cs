using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;
using Newtonsoft.Json;
using Project2.Data;

namespace Project2.Areas.Admin.Controllerss
{
    [Authorize]
    [Area("Admin")]
    public class ChartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChartsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            #region Doughnut chart
            var y = new List<int>();
            var lables = _context.Employee.Select(x=>x.EducationField).Distinct().ToList();
            foreach (var item in lables)
            {
                y.Add(_context.Employee.Where(x => x.EducationField == item).Count());
            }
            ViewBag.lables = JsonConvert.SerializeObject(lables);
            ViewBag.Data = JsonConvert.SerializeObject(y);
            #endregion

            #region bar chart
            var l = new List<int>();
            var lbl = _context.Employee.Select(x => x.JobRole).Distinct().ToList();
            foreach (var item in lbl)
            {
                l.Add(_context.Employee.Where(x => x.JobRole == item).Count());
            }
            ViewBag.lbl = JsonConvert.SerializeObject(lbl);
            ViewBag.Total = JsonConvert.SerializeObject(l);
            #endregion

            #region scatter chart

            //income = monthlyIncome
            var income = _context.Employee.Select(x => x.MonthlyIncome).ToList();
            //level = Job Level
            var level = _context.Employee.Select(x => x.JobLevel).Distinct().ToList();
            level.Sort();
            var list = _context.Employee.Select(x => x.JobLevel).ToList();
            ViewBag.list = JsonConvert.SerializeObject(list);
            ViewBag.Income = JsonConvert.SerializeObject(income);
            ViewBag.Level = JsonConvert.SerializeObject(level);

            #endregion

            #region Radar
            var radarx = _context.Employee.Select(x=>x.JobRole).Distinct().ToList();
            var p = new List<double>();
            foreach (var item in radarx)
            {
                p.Add(_context.Employee.Where(x => x.JobRole == item).Select(x => x.MonthlyRate).Average());
            }
            ViewBag.radarx = JsonConvert.SerializeObject(radarx);
            ViewBag.Department = JsonConvert.SerializeObject(p);
            #endregion

            return View();

        }
    }
}
