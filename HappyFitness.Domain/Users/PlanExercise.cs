using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Users
{
    public class PlanExercise : BaseEntity
    {
        /// <summary>
        /// Foreign key to the parent WorkoutPlan.
        /// </summary>
        public Guid WorkoutPlanId { get; set; }

        /// <summary>
        /// Navigation property to the parent WorkoutPlan.
        /// </summary>
        public WorkoutPlan WorkoutPlan { get; set; }

        /// <summary>
        /// Foreign key to the ExerciseDefinition entity.
        /// </summary>
        public Guid ExerciseDefinitionId { get; set; }

        /// <summary>
        /// Navigation property to the related ExerciseDefinition.
        /// </summary>
        public ExerciseDefinition ExerciseDefinition { get; set; }

        /// <summary>
        /// The target number of sets to perform.
        /// </summary>
        public int TargetSets { get; set; }

        /// <summary>
        /// The minumum target repetition
        /// </summary>
        public int TargetRepsMin { get; set; }

        /// <summary>
        /// The maximum target repetition
        /// </summary>
        public int TargetRepsMax { get; set; }
    }
}
