using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TightBodyWildSoul.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public bool IsPublished { get; set; }
        //public bool IsBodyLocation { get; set; }
        //public bool IsRecipe { get; set; }
        //public bool IsWorkout { get; set; }
        //public bool IsEquipment { get; set; }
        //public bool IsExercise { get; set; }


        public ICollection<ExerciseWorkout> ExerciseWorkout { get; set; }

        public ICollection<RecipeCategory> RecipeCategory { get; set; }
    }
}
