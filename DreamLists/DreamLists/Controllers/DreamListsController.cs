using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DreamLists.Data;
using DreamLists.Models;

namespace DreamLists.Controllers
{
    public class DreamListsController : Controller
    {
        private readonly DreamListsContext _context;

        public DreamListsController(DreamListsContext context)
        {
            _context = context;
        }

        // GET: DreamLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.DreamList.ToListAsync());
        }

        // GET: DreamLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dreamList = await _context.DreamList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dreamList == null)
            {
                return NotFound();
            }

            return View(dreamList);
        }

        // GET: DreamLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DreamLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,AccomplishBy")] DreamList dreamList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dreamList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dreamList);
        }

        // GET: DreamLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dreamList = await _context.DreamList.FindAsync(id);
            if (dreamList == null)
            {
                return NotFound();
            }
            return View(dreamList);
        }

        // POST: DreamLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,AccomplishBy")] DreamList dreamList)
        {
            if (id != dreamList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dreamList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DreamListExists(dreamList.Id))
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
            return View(dreamList);
        }

        // GET: DreamLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dreamList = await _context.DreamList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dreamList == null)
            {
                return NotFound();
            }

            return View(dreamList);
        }

        // POST: DreamLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dreamList = await _context.DreamList.FindAsync(id);
            if (dreamList != null)
            {
                _context.DreamList.Remove(dreamList);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DreamListExists(int id)
        {
            return _context.DreamList.Any(e => e.Id == id);
        }
    }
}
