using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MarvelMonitors.Data;


namespace MarvelMonitors.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MarvelMonitorsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MarvelMonitorsContext>>()))
            {
                if (context.Monitor.Any())
                {
                    return;
                }

                context.Monitor.AddRange(
                    new Monitor
                    {
                        ModelName = "Dell Ultra",
                        PanelTechnology = "IPS",
                        Manufacturer = "Dell",
                        ScreenSize = "27 In",
                        RefreshRate = "165 hz",
                        Resolution = "1440p WQHD",
                        Features = "Mountable",
                        Price = 469.99M,
                        Rating = 5
                    },

                    new Monitor
                    {
                        ModelName = "Dell Ultra",
                        PanelTechnology = "IPS",
                        Manufacturer = "Dell",
                        ScreenSize = "27 In",
                        RefreshRate = "165 hz",
                        Resolution = "1440p WQHD",
                        Features = "Mountable",
                        Price = 469.99M,
                        Rating = 5
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
