namespace HappyFitness.Domain.Workouts
{
    public interface IWorkoutSessionRepository
    {
        Task<IEnumerable<WorkoutSession>> GetByUserAsync(Guid userId, CancellationToken cancellationToken = default); 
    }
}
