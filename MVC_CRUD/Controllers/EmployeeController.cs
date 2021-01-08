using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var displayData = _db.EmployeeDetails.ToList();
            return View(displayData);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmpDetails emp)
        {
            if(ModelState.IsValid)
            {
                _db.Add(emp);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }

            var getEmpDetails = await _db.EmployeeDetails.FindAsync(id);
            return View(getEmpDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmpDetails emp)
        {
            if(ModelState.IsValid)
            {
                _db.Update(emp);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getEmpDetails = await _db.EmployeeDetails.FindAsync(id);
            return View(getEmpDetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getEmpDetails = await _db.EmployeeDetails.FindAsync(id);
            return View(getEmpDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getEmpDetails = await _db.EmployeeDetails.FindAsync(id);
            _db.EmployeeDetails.Remove(getEmpDetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
