using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exam.Models;

namespace Exam.Controllers
{
    public class sinavlarController : Controller
    {
        private readonly MyDbContext _context;

        public sinavlarController(MyDbContext context)
        {
            _context = context;
        }

        // GET: sinavlar
        public async Task<IActionResult> Index()
        {
            return View(await _context.sinavlar.ToListAsync());
        }
        public async Task<IActionResult> sinavgiris(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinavlar = await _context.sinavlar
                .FirstOrDefaultAsync(m => m.sinavid == id);
            if (sinavlar == null)
            {
                return NotFound();
            }

            return View(sinavlar);
        }
        // GET: sinavlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinavlar = await _context.sinavlar
                .FirstOrDefaultAsync(m => m.sinavid == id);
            if (sinavlar == null)
            {
                return NotFound();
            }

            return View(sinavlar);
        }

        // GET: sinavlar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: sinavlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("sinavid,soru1,secenekA,secenekB,secenekC,secenekD,Cevap,soru2,secenek2A,secenek2B,secenek2C,secenek2D,Cevap2,soru3,secenek3A,secenek3B,secenek3C,secenek3D,Cevap3,soru4,secenek4A,secenek4B,secenek4C,secenek4D,Cevap4,baslik,tarih")] sinavlar sinavlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinavlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sinavlar);
        }

        // GET: sinavlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinavlar = await _context.sinavlar.FindAsync(id);
            if (sinavlar == null)
            {
                return NotFound();
            }
            return View(sinavlar);
        }

        // POST: sinavlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("sinavid,soru1,secenekA,secenekB,secenekC,secenekD,Cevap,soru2,secenek2A,secenek2B,secenek2C,secenek2D,Cevap2,soru3,secenek3A,secenek3B,secenek3C,secenek3D,Cevap3,soru4,secenek4A,secenek4B,secenek4C,secenek4D,Cevap4,baslik,tarih")] sinavlar sinavlar)
        {
            if (id != sinavlar.sinavid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinavlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!sinavlarExists(sinavlar.sinavid))
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
            return View(sinavlar);
        }

        // GET: sinavlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinavlar = await _context.sinavlar
                .FirstOrDefaultAsync(m => m.sinavid == id);
            if (sinavlar == null)
            {
                return NotFound();
            }

            return View(sinavlar);
        }

        // POST: sinavlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sinavlar = await _context.sinavlar.FindAsync(id);
            _context.sinavlar.Remove(sinavlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool sinavlarExists(int id)
        {
            return _context.sinavlar.Any(e => e.sinavid == id);
        }
    }
}
