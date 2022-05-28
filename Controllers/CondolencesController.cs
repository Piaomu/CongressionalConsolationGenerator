using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CongressionalConsolationGenerator.Data;
using CongressionalConsolationGenerator.Models;
using AutoMapper;

namespace CongressionalConsolationGenerator.Controllers
{
    public class CondolencesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CondolencesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Condolences
        public async Task<IActionResult> Index()
        {
              return _context.Condolence != null ? 
                          View(await _context.Condolence.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Condolence'  is null.");
        }

        // GET: Condolences/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Condolence == null)
            {
                return NotFound();
            }

            var condolence = await _context.Condolence
                .FirstOrDefaultAsync(m => m.Id == id);
            if (condolence == null)
            {
                return NotFound();
            }

            return View(condolence);
        }

        // GET: Condolences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Condolences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SentenceSubject,Verb,Verb2,IsDoubleVerb,Tragedy,Location,State,Date,Year,Sentence2Subject,ThoughtsAndPrayers,Sentence2Object,ResponderAdjective,Heroes")] CondolenceInput condolenceInput)
        {
            Condolence condolence = _mapper.Map<Condolence>(condolenceInput);

            if (ModelState.IsValid)
            {
                _context.Add(condolence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(condolence);
        }

        // GET: Condolences/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Condolence == null)
            {
                return NotFound();
            }

            var condolence = await _context.Condolence.FindAsync(id);
            if (condolence == null)
            {
                return NotFound();
            }
            return View(condolence);
        }

        // POST: Condolences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,SentenceSubject,Verb,Verb2,IsDoubleVerb,Tragedy,Location,State,Date,Year,Sentence2Subject,ThoughtsAndPrayers,Sentence2Object,ResponderAdjective,Heroes")] Condolence condolence)
        {
            if (id != condolence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(condolence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CondolenceExists(condolence.Id))
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
            return View(condolence);
        }

        // GET: Condolences/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Condolence == null)
            {
                return NotFound();
            }

            var condolence = await _context.Condolence
                .FirstOrDefaultAsync(m => m.Id == id);
            if (condolence == null)
            {
                return NotFound();
            }

            return View(condolence);
        }

        // POST: Condolences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Condolence == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Condolence'  is null.");
            }
            var condolence = await _context.Condolence.FindAsync(id);
            if (condolence != null)
            {
                _context.Condolence.Remove(condolence);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CondolenceExists(string id)
        {
          return (_context.Condolence?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
