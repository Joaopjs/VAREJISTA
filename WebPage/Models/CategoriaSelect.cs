using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage.Models
{
    public class CategoriaSelect
    {
        public string Type { get; set; }

        public IEnumerable<SelectListItem> TypeList
        {
            get
            {
                return new List<SelectListItem>
        {
            new SelectListItem { Text = "Football", Value = "Football"},
            new SelectListItem { Text = "Rugby", Value = "Rugby"},
            new SelectListItem { Text = "Horse Racing", Value = "Horse Racing"}
        };
            }
        }
    }
}
