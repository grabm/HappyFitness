using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Workouts
{
    public class PerformedExercise : BaseEntity
    {
        /// <summary>
        /// Foreign key to the ExerciseDefinition entity.
        /// </summary>
        public Guid ExcerciseDefinitionId { get; set; }

        /// <summary>
        /// Navigation property to the related ExerciseDefinition.
        /// </summary>
        public ExerciseDefinition ExerciseDefinition { get; set; }

        /// <summary>
        /// A collection of sets actually performed for this exercise.
        /// </summary>
        public ICollection<PerformedSet> PerformedSets { get; set; }
    }
}
