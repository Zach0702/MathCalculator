using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsPractice.Models
{
    public class PersonalViewForm
    {
        public List<string> FavoriteMovie { get; set; }
        public string HomeTown { get; set; }
        public int NumberOfPets { get; set; }
        public string FavoriteFood { get; set; }

        public SelectList MovieList { get; set; } = new SelectList(new List<string>
        {
            "Pulp Fiction",
            "The Departed"
        });

        public List<SelectListItem> Movies { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem("Movie","PulpFiction"),
            new SelectListItem("Movies","The Departed")
        };
    }

    
}
