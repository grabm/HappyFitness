using CommunityToolkit.Mvvm.Input;
using HappyFitness.Application.Dtos;
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
            var userId = new Guid("f6f5a5c5-7212-46a2-b673-0d321d6e80f1"); // Using the ID from our test data script
            var query = new GetWorkoutHistoryQuery { UserId = userId };
            var result = await _mediator.Send(query);

            PastWorkouts.Clear();

            if (result != null)
            {
                foreach (var workout in result)
                {
                    PastWorkouts.Add(workout);
                }
            }
        }
    }
}
