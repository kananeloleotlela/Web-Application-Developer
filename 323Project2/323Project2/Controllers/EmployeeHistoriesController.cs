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
    public class EmployeeHistoriesController : Controller
    {
        private readonly DimensionDataProjectDBContext _context;

        public EmployeeHistoriesController(DimensionDataProjectDBContext context)
        {
            _context = context;
        }

        // GET: EmployeeHistories
        public async Task<IActionResult> Index()
        {
            var dimensionDataProjectDBContext = _context.EmployeeHistory.Include(e => e.EmployeeNumberNavigation);
            return View(await dimensionDataProjectDBContext.ToListAsync());
        }

        // GET: EmployeeHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeHistory = await _context.EmployeeHistory
                .Include(e => e.EmployeeNumberNavigation)
                .FirstOrDefaultAsync(m => m.EmployeeHistoryId == id);
            if (employeeHistory == null)
            {
                return NotFound();
            }

            return View(employeeHistory);
        }

        // GET: EmployeeHistories/Create
        public IActionResult Create()
        {
            ViewData["EmployeeNumber"] = new SelectList(_context.EmployeeDetail, "EmployeeNumber", "Gender");
            return View();
        }

        // POST: EmployeeHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeHistoryId,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager,EnvironmentSatisfaction,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,PerformanceRating,PercentSalaryHike,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,Attrition,BusinessTravel,DailyRate,EmployeeNumber")] EmployeeHistory employeeHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeNumber"] = new SelectList(_context.EmployeeDetail, "EmployeeNumber", "Gender", employeeHistory.EmployeeNumber);
            return View(employeeHistory);
        }

        // GET: EmployeeHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeHistory = await _context.EmployeeHistory.FindAsync(id);
            if (employeeHistory == null)
            {
                return NotFound();
            }
            ViewData["EmployeeNumber"] = new SelectList(_context.EmployeeDetail, "EmployeeNumber", "Gender", employeeHistory.EmployeeNumber);
            return View(employeeHistory);
        }

        // POST: EmployeeHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeHistoryId,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager,EnvironmentSatisfaction,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,PerformanceRating,PercentSalaryHike,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,Attrition,BusinessTravel,DailyRate,EmployeeNumber")] EmployeeHistory employeeHistory)
        {
            if (id != employeeHistory.EmployeeHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeHistoryExists(employeeHistory.EmployeeHistoryId))
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
            ViewData["EmployeeNumber"] = new SelectList(_context.EmployeeDetail, "EmployeeNumber", "Gender", employeeHistory.EmployeeNumber);
            return View(employeeHistory);
        }

        // GET: EmployeeHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeHistory = await _context.EmployeeHistory
                .Include(e => e.EmployeeNumberNavigation)
                .FirstOrDefaultAsync(m => m.EmployeeHistoryId == id);
            if (employeeHistory == null)
            {
                return NotFound();
            }

            return View(employeeHistory);
        }

        // POST: EmployeeHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeHistory = await _context.EmployeeHistory.FindAsync(id);
            _context.EmployeeHistory.Remove(employeeHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeHistoryExists(int id)
        {
            return _context.EmployeeHistory.Any(e => e.EmployeeHistoryId == id);
        }
    }
}
