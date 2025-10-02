using HappyFitness.Domain.Workouts;
using Microsoft.EntityFrameworkCore;

namespace HappyFitness.Infrastructure.Repositories
{
    public class WorkoutSessionRepository : IWorkoutSessionRepository
    {
        private readonly HappyFitnessDbContext _happyFitnessDbContext;
        public async Task<IEnumerable<WorkoutSession>> GetByUserAsync(Guid userId, CancellationToken cancellationToken = default)
        {

            var dbPath = _happyFitnessDbContext.Database.GetDbConnection().DataSource; // podglądnij w debuggerze
            var countAll = await _happyFitnessDbContext.Set<WorkoutSession>().CountAsync(cancellationToken);
            var countUser = await _happyFitnessDbContext.Set<WorkoutSession>().CountAsync(ws => ws.UserId == userId, cancellationToken);
            var result = await _happyFitnessDbContext.Set<WorkoutSession>().Where(u => u.UserId == userId).ToListAsync();
        
            return result;
        }
    }
}
