using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace Ow2Lore_CIDM3312FinalProj.Pages_Characters
{
    public class EditModel : PageModel
    {
        private readonly Final.Models.LoreContext _context;

        public EditModel(Final.Models.LoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lore Lore { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.HeroLore == null)
            {
                return NotFound();
            }

            var lore =  await _context.HeroLore.FirstOrDefaultAsync(m => m.LoreID == id);
            if (lore == null)
            {
                return NotFound();
            }
            Lore = lore;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Lore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoreExists(Lore.LoreID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LoreExists(int id)
        {
          return (_context.HeroLore?.Any(e => e.LoreID == id)).GetValueOrDefault();
        }
    }
}
