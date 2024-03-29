﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BelagricolaMVC.Data;
using BelagricolaMVC.Models;
using System.Diagnostics;

namespace BelagricolaMVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly BelagricolaMVCContext _context;

        public ClientesController(BelagricolaMVCContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cliente.ToListAsync());
        }
       

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View(new Cliente());
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,RG,CPF,Nascimento,Obs")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { errorMessage = "Id do cliente não fornecido." });
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return RedirectToAction(nameof(Error), new { errorMessage = "Id do cliente não encontrado." });
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,RG,CPF,Nascimento,Obs")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return RedirectToAction(nameof(Error), new { errorMessage = "Id do cliente não encontrado." });
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    if (!ClienteExists(cliente.Id))
                    {
                        return RedirectToAction(nameof(Error), new { errorMessage = "O cliente não existe." });
                    }
                    else
                    {
                        return RedirectToAction(nameof(Error), new { errorMessage = "Erro ao salvar cliente. Id: "+ cliente.Id + Environment.NewLine + e.Message});
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { errorMessage = "Id não fornecido." });
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return RedirectToAction(nameof(Error), new { errorMessage = "Cliente inexistente." });
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente != null)
            {
                _context.Cliente.Remove(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Error), new { errorMessage = "Cliente inexistente. ID: " + id });
            }
            
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.Id == id);
        }

        public List<Cliente> FindAll()
        {
            return _context.Cliente.OrderBy(x => x.Nome).ToList();
        }

        public Cliente FindById(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var cliente = _context.Cliente.FirstOrDefault(m => m.Id == id);
            if (cliente == null)
            {
                return null;
            }
            return cliente;
        }

        public IActionResult Error (string errorMessage)
        {
            var viewModel = new ErrorViewModel
            {
                ErrorMessage = errorMessage,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier //pega o código da requisição            
            };
            return View(viewModel);
        }
    }
}
