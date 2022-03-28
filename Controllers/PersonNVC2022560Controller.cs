using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVanCuong2022560;

namespace NguyenVanCuong2022560.Controllers
{
    public class PersonNVC2022560Controller : Controller
    {
        private readonly ApplicationDBContext _context;

        public PersonNVC2022560Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: PersonNVC2022560
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNVC2022560.ToListAsync());
        }

        // GET: PersonNVC2022560/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNVC2022560 = await _context.PersonNVC2022560
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personNVC2022560 == null)
            {
                return NotFound();
            }

            return View(personNVC2022560);
        }

        // GET: PersonNVC2022560/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNVC2022560/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,PersonName")] PersonNVC2022560 personNVC2022560)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNVC2022560);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNVC2022560);
        }

        // GET: PersonNVC2022560/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNVC2022560 = await _context.PersonNVC2022560.FindAsync(id);
            if (personNVC2022560 == null)
            {
                return NotFound();
            }
            return View(personNVC2022560);
        }

        // POST: PersonNVC2022560/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,PersonName")] PersonNVC2022560 personNVC2022560)
        {
            if (id != personNVC2022560.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNVC2022560);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNVC2022560Exists(personNVC2022560.PersonID))
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
            return View(personNVC2022560);
        }

        // GET: PersonNVC2022560/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNVC2022560 = await _context.PersonNVC2022560
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personNVC2022560 == null)
            {
                return NotFound();
            }

            return View(personNVC2022560);
        }

        // POST: PersonNVC2022560/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personNVC2022560 = await _context.PersonNVC2022560.FindAsync(id);
            _context.PersonNVC2022560.Remove(personNVC2022560);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNVC2022560Exists(string id)
        {
            return _context.PersonNVC2022560.Any(e => e.PersonID == id);
        }
    }
}
