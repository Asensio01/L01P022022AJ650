﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using L01P022022AJ650.Models;

namespace L01P022022AJ650.Controllers
{
    public class departamentosController : Controller
    {
        private readonly sistema_notasDbContext _context;

        public departamentosController(sistema_notasDbContext context)
        {
            _context = context;
        }

        // GET: departamentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Departamentos.ToListAsync());
        }

        // GET: departamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamentos = await _context.Departamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departamentos == null)
            {
                return NotFound();
            }

            return View(departamentos);
        }

        // GET: departamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: departamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Departamento")] departamentos departamentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departamentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departamentos);
        }

        // GET: departamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamentos = await _context.Departamentos.FindAsync(id);
            if (departamentos == null)
            {
                return NotFound();
            }
            return View(departamentos);
        }

        // POST: departamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Departamento")] departamentos departamentos)
        {
            if (id != departamentos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departamentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!departamentosExists(departamentos.Id))
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
            return View(departamentos);
        }

        // GET: departamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamentos = await _context.Departamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departamentos == null)
            {
                return NotFound();
            }

            return View(departamentos);
        }

        // POST: departamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departamentos = await _context.Departamentos.FindAsync(id);
            if (departamentos != null)
            {
                _context.Departamentos.Remove(departamentos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool departamentosExists(int id)
        {
            return _context.Departamentos.Any(e => e.Id == id);
        }
    }
}
