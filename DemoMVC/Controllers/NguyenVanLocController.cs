using DemoMvc.Data;
using DemoMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Controllers
{
    public class NguyenVanLocController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NguyenVanLocController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NguyenVanLoc
        public async Task<IActionResult> Index()
        {
            var models = await _context.NguyenVanLoc.ToListAsync();
            return View(models);
        }

        // GET: NguyenVanLoc/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenVanLoc = await _context.NguyenVanLoc
                .FirstOrDefaultAsync(m => m.NguyenVanLocID == id);
            if (nguyenVanLoc == null)
            {
                return NotFound();
            }

            return View(nguyenVanLoc);
        }

        // GET: NguyenVanLoc/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NguyenVanLoc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NguyenVanLocID,FullName,Address")] NguyenVanLoc nguyenVanLoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguyenVanLoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguyenVanLoc);
        }

        // GET: NguyenVanLoc/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenVanLoc = await _context.NguyenVanLoc.FindAsync(id);
            if (nguyenVanLoc == null)
            {
                return NotFound();
            }
            return View(nguyenVanLoc);
        }

        // POST: NguyenVanLoc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NguyenVanLocID,FullName,Address")] NguyenVanLoc nguyenVanLoc)
        {
            if (id != nguyenVanLoc.NguyenVanLocID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguyenVanLoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguyenVanLocExists(nguyenVanLoc.NguyenVanLocID))
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
            return View(nguyenVanLoc);
        }

        // GET: NguyenVanLoc/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguyenVanLoc = await _context.NguyenVanLoc
                .FirstOrDefaultAsync(m => m.NguyenVanLocID == id);
            if (nguyenVanLoc == null)
            {
                return NotFound();
            }

            return View(nguyenVanLoc);
        }

        // POST: NguyenVanLoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nguyenVanLoc = await _context.NguyenVanLoc.FindAsync(id);
            if (nguyenVanLoc != null)
            {
                _context.NguyenVanLoc.Remove(nguyenVanLoc);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguyenVanLocExists(string id)
        {
            return _context.NguyenVanLoc.Any(e => e.NguyenVanLocID == id);
        }

        public override bool Equals(object? obj)
        {
            return obj is NguyenVanLocController controller &&
                   EqualityComparer<ApplicationDbContext>.Default.Equals(_context, controller._context);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_context);
        }
    }
}
