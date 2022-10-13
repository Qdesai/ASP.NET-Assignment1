using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MarvelMonitors.Models
{
    public class Monitor
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string PanelTechnology { get; set; }
        public string Manufacturer { get; set; }
        public string ScreenSize { get; set; }
        public string RefreshRate { get; set; }
        public string Resolution { get; set; }
        public string Features { get; set; }
        public decimal Price { get; set; }

    }
}
