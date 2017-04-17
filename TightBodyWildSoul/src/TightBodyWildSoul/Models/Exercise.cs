using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TightBodyWildSoul.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string Video { get; set; }
        public string Type { get; set; }
        public int NumberOfReps { get; set; }

        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<Category>  Category{ get; set; }

    }
}
