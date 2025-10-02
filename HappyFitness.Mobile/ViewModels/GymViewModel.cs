using CommunityToolkit.Mvvm.Input;
using HappyFitness.Application.Dtos;
using HappyFitness.Application.Workouts.GetWorkoutsHistory;
using HappyFitness.Application.Workouts.Queries;
using MediatR;
using System.Collections.ObjectModel;

namespace HappyFitness.Mobile.ViewModels
{
    public partial class GymViewModel 
    {
        private readonly IMediator _mediator;
        public ObservableCollection<WorkoutHistoryDto> PastWorkouts { get; } = new();
        public GymViewModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        [RelayCommand]
        private async Task LoadHistoryAsync()
        {
            // TODO: Replace with the actual logged-in user's ID
            var userId = new Guid("5f506621-3e89-4b41-aec0-353a8b0bd488");
            var query = new GetWorkoutQuery(userId);
            var result = await _mediator.Send(query);

            PastWorkouts.Clear();

            //if (result != null)
            //{
            //    foreach (var workout in result.Value)
            //    {
            //        PastWorkouts.Add(workout);
            //    }
            //}
        }
    }
}
