using HappyFitness.Domain.Workouts;

namespace HappyFitness.Application.Workouts.Interfaces
{
    public interface IWorkoutHistoryReadRepository
    {
        Task<IEnumerable<WorkoutSession>> SearchAsync();
    }
}
