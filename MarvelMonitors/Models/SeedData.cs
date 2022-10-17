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
                        ModelName = "LG UltraGear",
                        PanelTechnology = "VA",
                        Manufacturer = "LG",
                        ScreenSize = "23.8\"",
                        RefreshRate = "165 Hz",
                        Resolution = "1080p HD",
                        Features = "Mountable",
                        Price = 189.99M,
                        Rating = 3
                    },

                    new Monitor
                    {
                        ModelName = "SAMSUNG M7",
                        PanelTechnology = "VA",
                        Manufacturer = "SAMSUNG",
                        ScreenSize = "32\"",
                        RefreshRate = "60 Hz",
                        Resolution = "4K ULTRA HD",
                        Features = "Mountable",
                        Price = 499.99M,
                        Rating = 4
                    },

                    new Monitor
                    {
                        ModelName = "APPLE STUDIO DISPLAY",
                        PanelTechnology = "VA",
                        Manufacturer = "LG",
                        ScreenSize = "27\"",
                        RefreshRate = "60 Hz",
                        Resolution = "5K",
                        Features = "Tilt Adjustment",
                        Price = 1999.99M,
                        Rating = 5
                    },

                    new Monitor
                    {
                        ModelName = "SAMSUNG ODYSSEY G5",
                        PanelTechnology = "VA",
                        Manufacturer = "SAMSUNG",
                        ScreenSize = "34\"",
                        RefreshRate = "165 Hz",
                        Resolution = "1440p WQHD",
                        Features = "Curved",
                        Price = 549.99M,
                        Rating = 5
                    },

                    new Monitor
                    {
                        ModelName = "LG ULTRA",
                        PanelTechnology = "IPS",
                        Manufacturer = "LG",
                        ScreenSize = "27\"",
                        RefreshRate = "60 Hz",
                        Resolution = "4K ULTRA HD",
                        Features = "Mountable",
                        Price = 379.99M,
                        Rating = 3
                    },

                    new Monitor
                    {
                        ModelName = "PHILIPS UHD",
                        PanelTechnology = "IPS",
                        Manufacturer = "TPV",
                        ScreenSize = "27\"",
                        RefreshRate = "60 Hz",
                        Resolution = "4K",
                        Features = "Tilt Adjustment",
                        Price = 489.99M,
                        Rating = 2
                    },

                    new Monitor
                    {
                        ModelName = "ASUS ProArt",
                        PanelTechnology = "IPS",
                        Manufacturer = "ACER",
                        ScreenSize = "32\"",
                        RefreshRate = "60 Hz",
                        Resolution = "4K ULTRA HD",
                        Features = "Tilt Adjustment",
                        Price = 849.99M,
                        Rating = 5
                    },

                    new Monitor
                    {
                        ModelName = "ViewSonic",
                        PanelTechnology = "MVA",
                        Manufacturer = "ViewSonic",
                        ScreenSize = "32\"",
                        RefreshRate = "60 Hz",
                        Resolution = "4K UHD",
                        Features = "Tilt Adjustment",
                        Price = 430.99M,
                        Rating = 4
                    },

                    new Monitor
                    {
                        ModelName = "ACER ROG SWIFT",
                        PanelTechnology = "OLED",
                        Manufacturer = "ACER",
                        ScreenSize = "42.5\"",
                        RefreshRate = "138 Hz",
                        Resolution = "4K ULTRA HD",
                        Features = "Curved",
                        Price = 1899.99M,
                        Rating = 5
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
