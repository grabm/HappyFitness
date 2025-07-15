using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Users
{
    public class PlanExercise : BaseEntity
    {
        /// <summary>
        /// Foreign key to the ExerciseDefinition entity.
        /// </summary>
        public Guid ExcerciseDefinitionId { get; set; }

        /// <summary>
        /// The target number of sets to perform.
        /// </summary>
        public int TargetSets { get; set; }

        public int TargetRepsMin { get; set; }
        public int TargetRepsMax { get; set; }
    }
}
