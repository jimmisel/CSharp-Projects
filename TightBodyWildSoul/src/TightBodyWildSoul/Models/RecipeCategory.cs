using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TightBodyWildSoul.Models
{
    public class RecipeCategory
    {
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }
    }
}
