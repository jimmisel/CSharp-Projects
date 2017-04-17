using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TightBodyWildSoul.Models
{
    public class ExerciseWorkout
    {
        public Workout workout { get; set; }
        public int WorkoutId { get; set; }
        public Exercise Exercise { get; set; }
        public int ExerciseId { get; set; }
        public Equipment Equipment { get; set; }
        public int EquipmentId { get; set; }
        public BodyTarget BodyTarget { get; set; }
        public int BodyTargetId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
