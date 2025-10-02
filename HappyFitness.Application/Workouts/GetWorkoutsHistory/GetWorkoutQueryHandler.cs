using HappyFitness.Application.Dtos;
using HappyFitness.Domain.Abstractions;
using HappyFitness.Domain.Workouts;
using MediatR;

namespace HappyFitness.Application.Workouts.GetWorkoutsHistory
{
    public class GetWorkoutQueryHandler : MediatR.IRequestHandler<GetWorkoutQuery, Result<IEnumerable<WorkoutSession>>>
    {
        private readonly IWorkoutSessionRepository _workoutSessionRepository;

        public GetWorkoutQueryHandler(IWorkoutSessionRepository workoutSessionRepository)
        {
            _workoutSessionRepository = workoutSessionRepository;
        }

        //public async Task<PageResult<WorkoutHistoryDto>> Handle(GetWorkoutQuery request, CancellationToken cancellationToken)
        //{
        //    var workouts = await _workoutSessionRepository.GetByUser(request.UserId, cancellationToken);
        //    //var workouts = await _context.WorkoutSessions
        //    //    .Where(ws => ws.UserId == request.UserId)
        //    //    .OrderByDescending(ws => ws.CreatedDateUtc)
        //    //    .Select(ws => new WorkoutHistoryDto{
        //    //        Id = ws.Id,
        //    //        Name = ws.Name,
        //    //        Date = ws.CreatedDateUtc,
        //    //        PerformedExerciseShortNames = ws.PerformedExercises
        //    //        .OrderBy(pe => pe.CreatedDateUtc)
        //    //        .Select(pe => pe.ExerciseDefinition.ShortName)
        //    //        //.Take(4)
        //    //        .ToList()
        //    //    })
        //    //    .ToListAsync();

        //    return workouts;
        //}

        public async Task<Result<IEnumerable<WorkoutSession>>> Handle(GetWorkoutQuery request, CancellationToken cancellationToken)
        {
            var workouts = await _workoutSessionRepository.GetByUserAsync(request.UserId);

            return Result.Success(workouts);
        }
    }
}
