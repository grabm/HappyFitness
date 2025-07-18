using HappyFitness.Domain.Common;
using HappyFitness.Domain.Users;

namespace HappyFitness.Domain.Workouts
{
    public class WorkoutSession : BaseEntity
    {
        /// <summary>
        /// Foreign key to the user who performed the workout.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Navigation property to the parent User.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// The name of the completed workout, e.g., copied from a plan.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A collection of exercises actually performed during this session.
        /// </summary>
        public ICollection<PerformedExercise> PerformedExercises { get; set; } = new List<PerformedExercise>();
    }
}
