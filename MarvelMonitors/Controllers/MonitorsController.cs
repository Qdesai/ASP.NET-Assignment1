using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarvelMonitors.Data;
using MarvelMonitors.Models;

namespace MarvelMonitors.Controllers
{
    public class MonitorsController : Controller
    {
        private readonly MarvelMonitorsContext _context;

        public MonitorsController(MarvelMonitorsContext context)
        {
            _context = context;
        }

        // GET: Monitors
        public async Task<IActionResult> Index(string id)
        {
            var monitors = from m in _context.Monitor // sql query to get all the results from the database. 
                           select m;

            if (!String.IsNullOrEmpty(id))
            {
                monitors = monitors.Where(s => s.ModelName.Contains(id)); // compares the string with the recordds and gives the records that match.
            }

            return View(await monitors.ToListAsync());
        }

        // GET: Monitors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monitor = await _context.Monitor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monitor == null)
            {
                return NotFound();
            }

            return View(monitor);
        }

        // GET: Monitors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monitors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ModelName,PanelTechnology,Manufacturer,ScreenSize,RefreshRate,Resolution,Features,Price")] Monitor monitor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monitor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monitor);
        }

        // GET: Monitors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monitor = await _context.Monitor.FindAsync(id);
            if (monitor == null)
            {
                return NotFound();
            }
            return View(monitor);
        }

        // POST: Monitors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModelName,PanelTechnology,Manufacturer,ScreenSize,RefreshRate,Resolution,Features,Price")] Monitor monitor)
        {
            if (id != monitor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monitor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonitorExists(monitor.Id))
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
            return View(monitor);
        }

        // GET: Monitors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monitor = await _context.Monitor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monitor == null)
            {
                return NotFound();
            }

            return View(monitor);
        }

        // POST: Monitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monitor = await _context.Monitor.FindAsync(id);
            _context.Monitor.Remove(monitor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonitorExists(int id)
        {
            return _context.Monitor.Any(e => e.Id == id);
        }
    }
}
