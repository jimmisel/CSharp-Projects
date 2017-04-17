using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TightBodyWildSoul.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsDaily { get; set; }
        public string Notes { get; set; }
        

        public ICollection<ExerciseWorkout> ExerciseWorkout { get; set; }
    }
}
