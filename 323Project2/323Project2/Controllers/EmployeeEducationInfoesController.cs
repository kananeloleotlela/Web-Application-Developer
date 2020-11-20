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
    public class EmployeeEducationInfoesController : Controller
    {
        private readonly DimensionDataProjectDBContext _context;

        public EmployeeEducationInfoesController(DimensionDataProjectDBContext context)
        {
            _context = context;
        }

        // GET: EmployeeEducationInfoes
        public async Task<IActionResult> Index()
        {
            var dimensionDataProjectDBContext = _context.EmployeeEducationInfo.Include(e => e.EducationCodeNavigation).Include(e => e.EmployeeNumberNavigation);
            return View(await dimensionDataProjectDBContext.ToListAsync());
        }

        // GET: EmployeeEducationInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeEducationInfo = await _context.EmployeeEducationInfo
                .Include(e => e.EducationCodeNavigation)
                .Include(e => e.EmployeeNumberNavigation)
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employeeEducationInfo == null)
            {
                return NotFound();
            }

            return View(employeeEducationInfo);
        }

        // GET: EmployeeEducationInfoes/Create
        public IActionResult Create()
        {
            ViewData["EducationCode"] = new SelectList(_context.EducationField, "EducationCode", "EducationDescription");
            ViewData["EmployeeNumber"] = new SelectList(_context.EmployeeDetail, "EmployeeNumber", "Gender");
            return View();
        }

        // POST: EmployeeEducationInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeNumber,EducationCode,EducationCount")] EmployeeEducationInfo employeeEducationInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeEducationInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EducationCode"] = new SelectList(_context.EducationField, "EducationCode", "EducationDescription", employeeEducationInfo.EducationCode);
            ViewData["EmployeeNumber"] = new SelectList(_context.EmployeeDetail, "EmployeeNumber", "Gender", employeeEducationInfo.EmployeeNumber);
            return View(employeeEducationInfo);
        }

        // GET: EmployeeEducationInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeEducationInfo = await _context.EmployeeEducationInfo.FindAsync(id);
            if (employeeEducationInfo == null)
            {
                return NotFound();
            }
            ViewData["EducationCode"] = new SelectList(_context.EducationField, "EducationCode", "EducationDescription", employeeEducationInfo.EducationCode);
            ViewData["EmployeeNumber"] = new SelectList(_context.EmployeeDetail, "EmployeeNumber", "Gender", employeeEducationInfo.EmployeeNumber);
            return View(employeeEducationInfo);
        }

        // POST: EmployeeEducationInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeNumber,EducationCode,EducationCount")] EmployeeEducationInfo employeeEducationInfo)
        {
            if (id != employeeEducationInfo.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeEducationInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeEducationInfoExists(employeeEducationInfo.EmployeeNumber))
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
            ViewData["EducationCode"] = new SelectList(_context.EducationField, "EducationCode", "EducationDescription", employeeEducationInfo.EducationCode);
            ViewData["EmployeeNumber"] = new SelectList(_context.EmployeeDetail, "EmployeeNumber", "Gender", employeeEducationInfo.EmployeeNumber);
            return View(employeeEducationInfo);
        }

        // GET: EmployeeEducationInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeEducationInfo = await _context.EmployeeEducationInfo
                .Include(e => e.EducationCodeNavigation)
                .Include(e => e.EmployeeNumberNavigation)
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employeeEducationInfo == null)
            {
                return NotFound();
            }

            return View(employeeEducationInfo);
        }

        // POST: EmployeeEducationInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeEducationInfo = await _context.EmployeeEducationInfo.FindAsync(id);
            _context.EmployeeEducationInfo.Remove(employeeEducationInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeEducationInfoExists(int id)
        {
            return _context.EmployeeEducationInfo.Any(e => e.EmployeeNumber == id);
        }
    }
}
