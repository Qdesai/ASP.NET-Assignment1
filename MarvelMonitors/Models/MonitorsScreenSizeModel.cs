using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarvelMonitors.Models
{
    public class MonitorsScreenSizeModel
    {
        public List<Monitor> Monito { get; set; }
        public SelectList ScreenSizes { get; set; }
        public string MonitorScreenSize { get; set; }
        public string SearchString { get; set; }
    }
}
