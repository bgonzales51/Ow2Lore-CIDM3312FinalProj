using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LoreContext(
                serviceProvider.GetRequiredService<DbContextOptions<LoreContext>>()))
            {
                // Look for any blogs.
                if (context.HeroLore.Any())
                {
                    return; // DB has been seeded
                }
                //Seed Heroes. 35 Heroes
                List<Lore> heroes = new List<Lore> {
                    new Lore {HeroName="Ana", Country="Egypt", HeroAge=60, Gender ='f', Allegiance="Vigilante"},
                    new Lore {HeroName="Ashe", Country="United States", HeroAge=39, Gender='f', Allegiance="Other"},
                    new Lore {HeroName="Baptiste", Country="Haiti", HeroAge=36, Gender='m', Allegiance="Other"},
                    new Lore {HeroName="Bation", Country="Germany", HeroAge=30, Gender='m', Allegiance="Other",},
                    new Lore {HeroName="Brigitte", Country="Sweden", HeroAge=23, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Cassidy", Country="United States", HeroAge=37, Gender='m', Allegiance="Vigilante",},
                    new Lore {HeroName="D.Va", Country="South Korea", HeroAge=19, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Doomfist", Country="Nigeria", HeroAge=45, Gender='m', Allegiance="Talon",},
                    new Lore {HeroName="Echo", Country="Singapore", HeroAge=29, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Genji", Country="Japan", HeroAge=35, Gender='m', Allegiance="Overwatch",},
                    new Lore {HeroName="Hanzo", Country="Japan", HeroAge=38, Gender='m', Allegiance="Vigilante",},
                    new Lore {HeroName="Junker Queen", Country="Australia", HeroAge=35, Gender='f', Allegiance="Junker",},
                    new Lore {HeroName="Junkrat", Country="Australia", HeroAge=25, Gender='m', Allegiance="Junker",},
                    new Lore {HeroName="Kiriko", Country="Japan", HeroAge=20, Gender='f', Allegiance="Vigilante",},
                    new Lore {HeroName="Lucio", Country="Brazil", HeroAge=26, Gender='m', Allegiance="Vigilante",},
                    new Lore {HeroName="Mei", Country="China", HeroAge=31, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Mercy", Country="Switzerland", HeroAge=37, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Moira", Country="Ireland", HeroAge=48, Gender='f', Allegiance="Talon",},
                    new Lore {HeroName="Orisa", Country="Nigeria", HeroAge=1, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Pharah", Country="Egypt", HeroAge=32, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Reaper", Country="United States", HeroAge=58, Gender='m', Allegiance="Talon",},
                    new Lore {HeroName="Reinhardt", Country="Germany", HeroAge=62, Gender='m', Allegiance="Overwatch",},
                    new Lore {HeroName="Roadhog", Country="Australia", HeroAge=48, Gender='m', Allegiance="Junker",},
                    new Lore {HeroName="Sigma", Country="Netherlands", HeroAge=62, Gender='m', Allegiance="Talon",},
                    new Lore {HeroName="Sojourn", Country="Canada", HeroAge=40, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Soldier: 76", Country="United States", HeroAge=55, Gender='m', Allegiance="Vigilante",},
                    new Lore {HeroName="Sombra", Country="Mexico", HeroAge=30, Gender='f', Allegiance="Talon",},
                    new Lore {HeroName="Symmetra", Country="India", HeroAge=28, Gender='f', Allegiance="Other",},
                    new Lore {HeroName="Torbjorn", Country="Sweden", HeroAge=57, Gender='m', Allegiance="Overwatch",},
                    new Lore {HeroName="Tracer", Country="England", HeroAge=26, Gender='f', Allegiance="Overwatch",},
                    new Lore {HeroName="Widowmaker", Country="France", HeroAge=33, Gender='f', Allegiance="Talon",},
                    new Lore {HeroName="Winston", Country="Horizon Lunar Colony", HeroAge=29, Gender='m', Allegiance="Overwatch",},
                    new Lore {HeroName="Wrecking Ball", Country="Horizon Lunar Colony", HeroAge=14, Gender='m', Allegiance="Junker",},
                    new Lore {HeroName="Zarya", Country="Russia", HeroAge=28, Gender='f', Allegiance="Other",},
                    new Lore {HeroName="Zenyatta", Country="Nepal", HeroAge=20, Gender='m', Allegiance="Other",},

                };
                context.AddRange(heroes);

                List<InGame> lobby = new List<InGame> {
                    new InGame {HeroRole="Support", Weapon="Biotic Rifle"},
                    new InGame {HeroRole="Damage", Weapon="The Viper"},
                    new InGame {HeroRole="Support", Weapon="Biotic Launcher"},
                    new InGame {HeroRole="Damage", Weapon="Configurations"},
                    new InGame {HeroRole="Support", Weapon="Rocket Flail"},
                    new InGame {HeroRole="Damage", Weapon="Peacekeeper"},
                    new InGame {HeroRole="Tank", Weapon="Fusion Cannons"},
                    new InGame {HeroRole="Tank", Weapon="Handcannon"},
                    new InGame {HeroRole="Damage", Weapon="Tri-Shot"},
                    new InGame {HeroRole="Damage", Weapon="Shuriken"},
                    new InGame {HeroRole="Damage", Weapon="Storm Bow"},
                    new InGame {HeroRole="Tank", Weapon="Scattergun"},
                    new InGame {HeroRole="Damage", Weapon="Frag Launcher"},
                    new InGame {HeroRole="Support", Weapon="Kunai"},
                    new InGame {HeroRole="Support", Weapon="Sonic Amplifier"},
                    new InGame {HeroRole="Damage", Weapon="Endothermic Blaster"},
                    new InGame {HeroRole="Support", Weapon="Caduceus Blaster"},
                    new InGame {HeroRole="Support", Weapon="Biotic Grasp"},
                    new InGame {HeroRole="Tank", Weapon="Fusion Driver"},
                    new InGame {HeroRole="Damage", Weapon="Rocket Launcher"},
                    new InGame {HeroRole="Damage", Weapon="Hellfire Shotguns"},
                    new InGame {HeroRole="Tank", Weapon="Rocket Hammer"},
                    new InGame {HeroRole="Tank", Weapon="Scrap Gun"},
                    new InGame {HeroRole="Tank", Weapon="Hyperspheres"},
                    new InGame {HeroRole="Damage", Weapon="Railgun"},
                    new InGame {HeroRole="Damage", Weapon="Heavy Pulse Rifle"},
                    new InGame {HeroRole="Damage", Weapon="Machine Pistol"},
                    new InGame {HeroRole="Damage", Weapon="Photon Projector"},
                    new InGame {HeroRole="Damage", Weapon="Rivet Gun"},
                    new InGame {HeroRole="Damage", Weapon="Pulse Pistols"},
                    new InGame {HeroRole="Damage", Weapon="Widow's Kiss"},
                    new InGame {HeroRole="Tank", Weapon="Tesla Cannon"},
                    new InGame {HeroRole="Tank", Weapon="Quad Cannons"},
                    new InGame {HeroRole="Tank", Weapon="Particle Cannons"},
                    new InGame {HeroRole="Support", Weapon="Orb of Destruction"},

                };
                context.AddRange(lobby);
                context.SaveChanges();
            }
        }
    }
}