using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Users
{
    public class WorkoutPlan : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public ICollection<PlanExercise> PlanExercises { get; set; } = new List<PlanExercise>();
    }
}
