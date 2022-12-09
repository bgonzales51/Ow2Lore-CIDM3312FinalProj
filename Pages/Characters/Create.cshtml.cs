using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final.Models;

namespace Ow2Lore_CIDM3312FinalProj.Pages_Characters
{
    public class CreateModel : PageModel
    {
        private readonly Final.Models.LoreContext _context;

        public CreateModel(Final.Models.LoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Lore Lore { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.HeroLore == null || Lore == null)
            {
                return Page();
            }

            _context.HeroLore.Add(Lore);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
