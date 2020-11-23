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
    public class EducationFieldsController : Controller
    {
        private readonly DimensionDataProjectDBContext _context;

        public EducationFieldsController(DimensionDataProjectDBContext context)
        {
            _context = context;
        }

        // GET: EducationFields
        public async Task<IActionResult> Index()
        {
            return View(await _context.EducationField.ToListAsync());
        }

        // GET: EducationFields/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var educationField = await _context.EducationField
                .FirstOrDefaultAsync(m => m.EducationCode == id);
            if (educationField == null)
            {
                return NotFound();
            }

            return View(educationField);
        }

        // GET: EducationFields/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EducationFields/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EducationCode,EducationDescription")] EducationField educationField)
        {
            if (ModelState.IsValid)
            {
                _context.Add(educationField);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(educationField);
        }

        // GET: EducationFields/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var educationField = await _context.EducationField.FindAsync(id);
            if (educationField == null)
            {
                return NotFound();
            }
            return View(educationField);
        }

        // POST: EducationFields/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EducationCode,EducationDescription")] EducationField educationField)
        {
            if (id != educationField.EducationCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(educationField);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EducationFieldExists(educationField.EducationCode))
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
            return View(educationField);
        }

        // GET: EducationFields/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var educationField = await _context.EducationField
                .FirstOrDefaultAsync(m => m.EducationCode == id);
            if (educationField == null)
            {
                return NotFound();
            }

            return View(educationField);
        }

        // POST: EducationFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var educationField = await _context.EducationField.FindAsync(id);
            _context.EducationField.Remove(educationField);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EducationFieldExists(int id)
        {
            return _context.EducationField.Any(e => e.EducationCode == id);
        }
    }
}
