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
    public class IndexModel : PageModel
    {
        private readonly Final.Models.LoreContext _context;

        public IndexModel(Final.Models.LoreContext context)
        {
            _context = context;
        }

        public IList<Lore> Lore { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.HeroLore != null)
            {
                Lore = await _context.HeroLore.ToListAsync();
            }
        }
    }
}
