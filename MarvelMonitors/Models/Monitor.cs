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


        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), StringLength(60, MinimumLength = 3), Required]
        [Display(Name = "Model Name")]      // Added this so that it the Title of the field is not shown as pascal casing (crunched)
        public string ModelName { get; set; }


        [Display(Name = "Panel Technology"), Required]
        public string PanelTechnology { get; set; }


        [StringLength(60, MinimumLength = 3), Required] // only allow min string length 3 and max 60
        public string Manufacturer { get; set; }

        [StringLength(5, MinimumLength = 3), Required] // only allow min string length 3 and max 5
        [Display(Name = "Screen Size")]
        public string ScreenSize { get; set; }


        [StringLength(5, MinimumLength = 3), Required] // only allow min string length 3 and max 5
        [Display(Name = "Refresh Rate")]
        public string RefreshRate { get; set; }


        [StringLength(7, MinimumLength = 3), Required] // only allow min string length 3 and max 5
        public string Resolution { get; set; }

        
        [Required]
        public string Features { get; set; }


        [Range(1, 10000), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        
        [RegularExpression(@"[0-5]")]
        public decimal Rating { get; set; }
    }
}
