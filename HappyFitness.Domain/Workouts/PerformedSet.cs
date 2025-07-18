using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Workouts
{
    public class PerformedSet : BaseEntity
    {
        /// <summary>
        /// Foreign key to the parent PerformedExercise.
        /// </summary>
        public Guid PerformedExerciseId { get; set; }

        /// <summary>
        /// Navigation property to the parent PerformedExercise.
        /// </summary>
        public PerformedExercise PerformedExercise { get; set; }
        /// <summary>
        /// The number of the set within the exercise (e.g., 1, 2, 3).
        /// </summary>
        public int SetNumber { get; set; }

        /// <summary>
        /// The weight used in kilograms.
        /// </summary>
        public float WeightInKgs { get; set; }

        /// <summary>
        /// The actual number of repetitions performed.
        /// </summary>
        public int Reps { get; set; }
    }
}
