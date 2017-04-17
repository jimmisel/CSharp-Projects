using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TightBodyWildSoul.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        //These are her to be able to show a user how to use them 
        public string Image { get; set; }
        public string Video { get; set; }


        public ICollection<ExerciseWorkout> ExerciseWorkout { get; set; }
    }
}
