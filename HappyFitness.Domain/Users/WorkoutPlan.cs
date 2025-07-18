using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Users
{
    public class WorkoutPlan : BaseEntity
    {
        /// <summary>
        /// Foreign key to the User entity.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Navigation property to the parent User.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// The name of the workout plan, e.g., "Workout A: Push".
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A collection of exercises included in this plan.
        /// </summary>
        public ICollection<PlanExercise> PlanExercises { get; set; } = new List<PlanExercise>();
    }
}
