using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CLDV6211_IceTask.Data;
using System;
using System.Linq;

namespace CLDV6211_IceTask.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CLDV6211_IceTaskContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CLDV6211_IceTaskContext>>()))
        {
            
            if (context.Music.Any())
            {
                return;   // DB has been seeded
            }
            context.Music.AddRange(
                new Music
                {
                    Title = "Dream On",
                    Genre = "Blues Rock",
                    Album = "Aerosmith",
                    Artist = "Aerosmith",
                    Price = 7.99M
                },
                new Music
                {
                    Title = "Make It",
                    Genre = "Blues Rock",
                    Album = "Aerosmith",
                    Artist = "Aerosmith",
                    Price = 6.99M
                },
                new Music
                {
                    Title = "Somebody",
                    Genre = "Blues Rock",
                    Album = "Aerosmith",
                    Artist = "Aerosmith",
                    Price = 6.99M
                },
                new Music
                {
                    Title = "Busy Child",
                    Genre = "Industrial Metal",
                    Album = "Vegas",
                    Artist = "The Crystal Method",
                    Price = 8.99M
                },
                new Music
                {
                    Title = "Trip Like I Do",
                    Genre = "Industrial Metal",
                    Album = "Vegas",
                    Artist = "The Crystal Method",
                    Price = 8.99M
                },

                new Music
                {
                    Title = "Over It",
                    Genre = "Breakbeat",
                    Album = "The Crystal Method",
                    Artist = "The Crystal Method",
                    Price = 10.99M
                }
            );
            context.SaveChanges();
        }
    }
}
