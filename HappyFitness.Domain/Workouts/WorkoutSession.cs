using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Workouts
{
    public class WorkoutSession : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }
    }
}
