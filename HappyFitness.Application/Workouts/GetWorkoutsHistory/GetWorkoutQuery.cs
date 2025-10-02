using HappyFitness.Domain.Abstractions;
using HappyFitness.Domain.Workouts;
using MediatR;

namespace HappyFitness.Application.Workouts.GetWorkoutsHistory;
public record GetWorkoutQuery(Guid UserId) : IRequest<Result<IEnumerable<WorkoutSession>>>;
