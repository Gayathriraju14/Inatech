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
    public class OrderListController : Controller
    {
        private readonly DeliveryExpressContext _context;

        public OrderListController(DeliveryExpressContext context)
        {
            _context = context;
        }

        // GET: OrderList
        public async Task<IActionResult> Index()
        {
              return _context.OrderList != null ? 
                          View(await _context.OrderList.ToListAsync()) :
                          Problem("Entity set 'DeliveryExpressContext.OrderList'  is null.");
        }

        // GET: OrderList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrderList == null)
            {
                return NotFound();
            }

            var orderList = await _context.OrderList
                .FirstOrDefaultAsync(m => m.OrderTypeId == id);
            if (orderList == null)
            {
                return NotFound();
            }

            return View(orderList);
        }

        // GET: OrderList/Create
        public IActionResult Create()
        {
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

        // POST: OrderList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderTypeId,OrderType,OrderName")] OrderList orderList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderList);
        }

        // GET: OrderList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrderList == null)
            {
                return NotFound();
            }

            var orderList = await _context.OrderList.FindAsync(id);
            if (orderList == null)
            {
                return NotFound();
            }
            return View(orderList);
        }

        // POST: OrderList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderTypeId,OrderType,OrderName")] OrderList orderList)
        {
            if (id != orderList.OrderTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderListExists(orderList.OrderTypeId))
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
            return View(orderList);
        }

        // GET: OrderList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrderList == null)
            {
                return NotFound();
            }

            var orderList = await _context.OrderList
                .FirstOrDefaultAsync(m => m.OrderTypeId == id);
            if (orderList == null)
            {
                return NotFound();
            }

            return View(orderList);
        }

        // POST: OrderList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrderList == null)
            {
                return Problem("Entity set 'DeliveryExpressContext.OrderList'  is null.");
            }
            var orderList = await _context.OrderList.FindAsync(id);
            if (orderList != null)
            {
                _context.OrderList.Remove(orderList);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderListExists(int id)
        {
          return (_context.OrderList?.Any(e => e.OrderTypeId == id)).GetValueOrDefault();
        }
    }
}
