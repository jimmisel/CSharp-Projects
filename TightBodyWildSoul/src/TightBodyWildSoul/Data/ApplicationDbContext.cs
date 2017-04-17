using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TightBodyWildSoul.Models;

namespace TightBodyWildSoul.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Exercise> Exercises { get; set; }
        DbSet<Workout> Workouts { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<RecipeCategory> RecipeCategories { get; set; }
        DbSet<BodyTarget> BodyTargets { get; set; }
        DbSet<ExerciseWorkout> ExerciseWorkouts { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Equipment> Equipments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<RecipeCategory>().HasKey(r => new { r.RecipeId, r.CategoryId});
            builder.Entity<ExerciseWorkout>().HasKey(e => new { e.BodyTargetId, e.CategoryId, e.EquipmentId, e.ExerciseId });
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
