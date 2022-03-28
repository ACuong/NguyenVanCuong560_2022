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
    public class NVC0560Controller : Controller
    {
        private readonly ApplicationDBContext _context;
        StringProcessNVC2022560 StringProcess = new StringProcessNVC2022560(); 


        public NVC0560Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: NVC0560
        public async Task<IActionResult> Index()
        {
            return View(await _context.NVC0560.ToListAsync());
        }

        // GET: NVC0560/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVC0560 = await _context.NVC0560
                .FirstOrDefaultAsync(m => m.NVCID == id);
            if (nVC0560 == null)
            {
                return NotFound();
            }

            return View(nVC0560);
        }

        // GET: NVC0560/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NVC0560/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NVCID,NVCName,NVCGender")] NVC0560 nVC0560)
        {
            nVC0560.NVCID = StringProcess.UpperToLower(nVC0560.NVCID);
            nVC0560.NVCName = StringProcess.UpperToLower(nVC0560.NVCName);
            if (ModelState.IsValid)
            {
                _context.Add(nVC0560);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nVC0560);
        }

        // GET: NVC0560/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVC0560 = await _context.NVC0560.FindAsync(id);
            if (nVC0560 == null)
            {
                return NotFound();
            }
            return View(nVC0560);
        }

        // POST: NVC0560/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NVCID,NVCName,NVCGender")] NVC0560 nVC0560)
        {
            nVC0560.NVCID = StringProcess.UpperToLower(nVC0560.NVCID);
            nVC0560.NVCName = StringProcess.UpperToLower(nVC0560.NVCName);
            if (id != nVC0560.NVCID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nVC0560);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVC0560Exists(nVC0560.NVCID))
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
            return View(nVC0560);
        }

        // GET: NVC0560/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVC0560 = await _context.NVC0560
                .FirstOrDefaultAsync(m => m.NVCID == id);
            if (nVC0560 == null)
            {
                return NotFound();
            }

            return View(nVC0560);
        }

        // POST: NVC0560/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nVC0560 = await _context.NVC0560.FindAsync(id);
            _context.NVC0560.Remove(nVC0560);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NVC0560Exists(string id)
        {
            return _context.NVC0560.Any(e => e.NVCID == id);
        }
    }
}
