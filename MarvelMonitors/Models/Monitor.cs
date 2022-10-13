using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarvelMonitors.Models
{
    public class Monitor
    {
        public int Id { get; set; }

        [Display(Name = "Model Name")]      // Added this so that it the Title of the field is not shown as pascal casing (crunched)
        public string ModelName { get; set; }

        [Display(Name = "Panel Technology")]
        public string PanelTechnology { get; set; }

        public string Manufacturer { get; set; }

        [Display(Name = "Screen Size")]
        public string ScreenSize { get; set; }

        [Display(Name = "Refresh Rate")]
        public string RefreshRate { get; set; }

        public string Resolution { get; set; }
        public string Features { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

    }
}
