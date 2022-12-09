using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace Ow2Lore_CIDM3312FinalProj.Pages_Characters
{
    public class DeleteModel : PageModel
    {
        private readonly Final.Models.LoreContext _context;

        public DeleteModel(Final.Models.LoreContext context)
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

            var lore = await _context.HeroLore.FirstOrDefaultAsync(m => m.LoreID == id);

            if (lore == null)
            {
                return NotFound();
            }
            else 
            {
                Lore = lore;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.HeroLore == null)
            {
                return NotFound();
            }
            var lore = await _context.HeroLore.FindAsync(id);

            if (lore != null)
            {
                Lore = lore;
                _context.HeroLore.Remove(Lore);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
