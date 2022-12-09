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

        [BindProperty(SupportsGet = true)]
        public string? SearchString {get;set;}

        [BindProperty(SupportsGet = true)]
        public string AgentName {get;set;} = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get;set;} =1;

        public int PageSize {get;set;} =10;

        [BindProperty(SupportsGet = true)]

        public string CurrentSort {get;set;}

        public async Task OnGetAsync()
        {
            if (_context.HeroLore != null)
            {
                var heroes = from p in _context.HeroLore
                    select p;
                if(SearchString != null)
                {
                    heroes = heroes.Where(p=>p.HeroName.Contains(SearchString));
                }
                Lore = await heroes.ToListAsync();
                
                var query = _context.HeroLore.Select(p => p);

                switch (CurrentSort)
                {
                    case "first_asc":
                        query = query.OrderBy(p => p.HeroName);
                        break;
                    case "first_desc":
                        query = query.OrderByDescending(p => p.HeroName);
                        break;
                    case "sec_asc":
                        query = query.OrderBy(p => p.Country);
                        break;
                    case "sec_desc":
                        query = query.OrderByDescending(p => p.Country);
                        break;
                    case "third_asc":
                        query = query.OrderBy(p => p.HeroAge);
                        break;
                    case "third_desc":
                        query = query.OrderByDescending(p => p.HeroAge);
                        break;
                    case "four_asc":
                        query = query.OrderBy(p => p.Allegiance);
                        break;
                    case "four_desc":
                        query = query.OrderByDescending(p => p.Allegiance);
                        break;

                }
                
                Lore = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
        }
    }
}
