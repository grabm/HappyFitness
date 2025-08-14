using HappyFitness.Application.Dtos;
using MediatR;

namespace HappyFitness.Application.Workouts.Queries
{
    public class GetWorkoutHistoryQuery : IRequest<List<WorkoutHistoryDto>>
    {
        public Guid UserId { get; set; }
    }
}
