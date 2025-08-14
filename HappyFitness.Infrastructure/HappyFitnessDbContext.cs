using HappyFitness.Domain.Common;
using HappyFitness.Domain.Meals;
using HappyFitness.Domain.Users;
using HappyFitness.Domain.Workouts;
using Microsoft.EntityFrameworkCore;
using HappyFitness.Application.Interfaces;

namespace HappyFitness.Infrastructure
{
    public class HappyFitnessDbContext : DbContext, IApplicationDbContext
    {
        public HappyFitnessDbContext(DbContextOptions<HappyFitnessDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<PlanExercise> PlanExercises { get; set; }
        public DbSet<WorkoutSession> WorkoutSessions { get; set; }
        public DbSet<PerformedExercise> PerformedExercises { get; set; }
        public DbSet<PerformedSet> PerformedSets { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealEntry> MealEntries { get; set; }

        public DbSet<ExerciseDefinition> ExerciseDefinitions { get; set; }
        public DbSet<FoodProduct> FoodProducts { get; set; }
        public DbSet<BodyPart> BodyParts { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<FoodSource> FoodSources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(user =>
            {
                user.HasOne(u => u.Profile)
                    .WithOne(p => p.User)
                    .HasForeignKey<UserProfile>(p => p.UserId);

                user.HasMany(u => u.WorkoutPlans)
                    .WithOne(wp => wp.User)
                    .HasForeignKey(wp => wp.UserId);

                user.HasMany(u => u.WorkoutSessions)
                    .WithOne(ws => ws.User)
                    .HasForeignKey(ws => ws.UserId);

                user.HasMany(u => u.Meals)
                    .WithOne(m => m.User)
                    .HasForeignKey(m => m.UserId);
            });

            modelBuilder.Entity<WorkoutPlan>(plan =>
            {
                plan.HasMany(p => p.PlanExercises)
                    .WithOne(pe => pe.WorkoutPlan)
                    .HasForeignKey(pe => pe.WorkoutPlanId);
            });

            modelBuilder.Entity<WorkoutSession>(session =>
            {
                session.HasMany(s => s.PerformedExercises)
                    .WithOne(pe => pe.WorkoutSession)
                    .HasForeignKey(pe => pe.WorkoutSessionId);
            });

            modelBuilder.Entity<PerformedExercise>(exercise =>
            {
                exercise.HasMany(e => e.PerformedSets)
                    .WithOne(s => s.PerformedExercise)
                    .HasForeignKey(s => s.PerformedExerciseId);
            });

            modelBuilder.Entity<Meal>(meal =>
            {
                meal.HasMany(m => m.MealEntries)
                    .WithOne(me => me.Meal)
                    .HasForeignKey(me => me.MealId);
            });

            modelBuilder.Entity<PlanExercise>()
                .HasOne(pe => pe.ExerciseDefinition)
                .WithMany() // Empty WithMany as ExerciseDefinition does not have a collection of PlanExercises
                .HasForeignKey(pe => pe.ExerciseDefinitionId);

            modelBuilder.Entity<PerformedExercise>()
                .HasOne(pe => pe.ExerciseDefinition)
                .WithMany() // Empty WithMany as ExerciseDefinition does not have a collection of PerformedExercises
                .HasForeignKey(pe => pe.ExerciseDefinitionId);

            modelBuilder.Entity<MealEntry>()
                .HasOne(me => me.FoodProduct)
                .WithMany() // Empty WithMany as FoodProduct does not have a collection of MealEntries
                .HasForeignKey(me => me.FoodProductId);

            modelBuilder.Entity<Meal>()
                .HasOne(m => m.MealType)
                .WithMany() // Empty WithMany as MealType does not have a collection of Meals
                .HasForeignKey(m => m.MealTypeId);

            modelBuilder.Entity<ExerciseDefinition>()
                .HasOne(ed => ed.BodyPart)
                .WithMany() // Empty WithMany as BodyPart does not have a collection of ExerciseDefinitions
                .HasForeignKey(ed => ed.BodyPartId);

            modelBuilder.Entity<FoodProduct>()
                .HasOne(fp => fp.FoodSource)
                .WithMany() // Empty WithMany as FoodSource does not have a collection of FoodProducts
                .HasForeignKey(fp => fp.FoodSourceId);
        }
    }
}
