using HappyFitness.Application.Dtos;
using HappyFitness.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HappyFitness.Application.Workouts.Queries
{
    public class GetWorkoutHistoryQueryHandler : IRequestHandler<GetWorkoutHistoryQuery, List<WorkoutHistoryDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetWorkoutHistoryQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<WorkoutHistoryDto>> Handle(GetWorkoutHistoryQuery request, CancellationToken cancellationToken)
        {
            var workouts = await _context.WorkoutSessions
                .Where(ws => ws.UserId == request.UserId)
                .OrderByDescending(ws => ws.CreatedDateUtc)
                .Select(ws => new WorkoutHistoryDto{
                    Id = ws.Id,
                    Name = ws.Name,
                    Date = ws.CreatedDateUtc,
                    PerformedExcerciseShortNames = ws.PerformedExercises
                    .OrderBy(pe => pe.CreatedDateUtc)
                    .Select(pe => pe.ExerciseDefinition.ShortName)
                    //.Take(4)
                    .ToList()
                })
                .ToListAsync();

            return workouts;
        }
    }
}
