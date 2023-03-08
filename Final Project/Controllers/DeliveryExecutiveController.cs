using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeliveryExpress.Models;

namespace DeliveryExpress.Controllers
{
    public class DeliveryExecutiveController : Controller
    {
        private readonly DeliveryExpressContext _context;

        public DeliveryExecutiveController(DeliveryExpressContext context)
        {
            _context = context;
        }

        // GET: DeliveryExecutive
        public async Task<IActionResult> Index()
        {
            var deliveryExpressContext = _context.DeliveryExecutive.Include(d => d.OrderList);
            return View(await deliveryExpressContext.ToListAsync());
        }

        // GET: DeliveryExecutive/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DeliveryExecutive == null)
            {
                return NotFound();
            }

            var deliveryExecutive = await _context.DeliveryExecutive
                .Include(d => d.OrderList)
                .FirstOrDefaultAsync(m => m.ExecutiveId == id);
            if (deliveryExecutive == null)
            {
                return NotFound();
            }

            return View(deliveryExecutive);
        }

        // GET: DeliveryExecutive/Create
        public IActionResult Create()
        {
            ViewData["OrderTypeId"] = new SelectList(_context.OrderList, "OrderTypeId", "OrderTypeId");
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult ServiceGuidance()
        {
            return View();
        }

        public IActionResult Tips()
        {

            return View();
        }

        // POST: DeliveryExecutive/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExecutiveId,ExecutiveName,Age,OrderTypeId,PhnNo")] DeliveryExecutive deliveryExecutive)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryExecutive);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderTypeId"] = new SelectList(_context.OrderList, "OrderTypeId", "OrderTypeId", deliveryExecutive.OrderTypeId);
            return View(deliveryExecutive);
        }

        // GET: DeliveryExecutive/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DeliveryExecutive == null)
            {
                return NotFound();
            }

            var deliveryExecutive = await _context.DeliveryExecutive.FindAsync(id);
            if (deliveryExecutive == null)
            {
                return NotFound();
            }
            ViewData["OrderTypeId"] = new SelectList(_context.OrderList, "OrderTypeId", "OrderTypeId", deliveryExecutive.OrderTypeId);
            return View(deliveryExecutive);
        }

        // POST: DeliveryExecutive/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExecutiveId,ExecutiveName,Age,OrderTypeId,PhnNo")] DeliveryExecutive deliveryExecutive)
        {
            if (id != deliveryExecutive.ExecutiveId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryExecutive);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryExecutiveExists(deliveryExecutive.ExecutiveId))
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
            ViewData["OrderTypeId"] = new SelectList(_context.OrderList, "OrderTypeId", "OrderTypeId", deliveryExecutive.OrderTypeId);
            return View(deliveryExecutive);
        }

        // GET: DeliveryExecutive/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DeliveryExecutive == null)
            {
                return NotFound();
            }

            var deliveryExecutive = await _context.DeliveryExecutive
                .Include(d => d.OrderList)
                .FirstOrDefaultAsync(m => m.ExecutiveId == id);
            if (deliveryExecutive == null)
            {
                return NotFound();
            }

            return View(deliveryExecutive);
        }

        // POST: DeliveryExecutive/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DeliveryExecutive == null)
            {
                return Problem("Entity set 'DeliveryExpressContext.DeliveryExecutive'  is null.");
            }
            var deliveryExecutive = await _context.DeliveryExecutive.FindAsync(id);
            if (deliveryExecutive != null)
            {
                _context.DeliveryExecutive.Remove(deliveryExecutive);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryExecutiveExists(int id)
        {
          return (_context.DeliveryExecutive?.Any(e => e.ExecutiveId == id)).GetValueOrDefault();
        }
    }
}
