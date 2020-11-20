using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _323Project2.Data;
using _323Project2.Models;

namespace _323Project2.Controllers
{
    public class DatasetTbsController : Controller
    {
        private readonly DimensionDataProjectDBContext _context;

        public DatasetTbsController(DimensionDataProjectDBContext context)
        {
            _context = context;
        }

        // GET: DatasetTbs
        public async Task<IActionResult> Index()
        {
            return View(await _context.DatasetTb.ToListAsync());
        }

        // GET: DatasetTbs/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datasetTb = await _context.DatasetTb
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (datasetTb == null)
            {
                return NotFound();
            }

            return View(datasetTb);
        }

        // GET: DatasetTbs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DatasetTbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] DatasetTb datasetTb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datasetTb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(datasetTb);
        }

        // GET: DatasetTbs/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datasetTb = await _context.DatasetTb.FindAsync(id);
            if (datasetTb == null)
            {
                return NotFound();
            }
            return View(datasetTb);
        }

        // POST: DatasetTbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] DatasetTb datasetTb)
        {
            if (id != datasetTb.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datasetTb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatasetTbExists(datasetTb.EmployeeNumber))
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
            return View(datasetTb);
        }

        // GET: DatasetTbs/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datasetTb = await _context.DatasetTb
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (datasetTb == null)
            {
                return NotFound();
            }

            return View(datasetTb);
        }

        // POST: DatasetTbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var datasetTb = await _context.DatasetTb.FindAsync(id);
            _context.DatasetTb.Remove(datasetTb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatasetTbExists(short id)
        {
            return _context.DatasetTb.Any(e => e.EmployeeNumber == id);
        }
    }
}
