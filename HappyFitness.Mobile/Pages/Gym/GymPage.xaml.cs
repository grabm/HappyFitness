using HappyFitness.Mobile.ViewModels;

namespace HappyFitness.Mobile.Pages.Gym;

public partial class GymPage : ContentPage
{
	public GymPage(GymViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // R?cznie wywo?ujemy komend? z ViewModelu
        if (BindingContext is GymViewModel vm && vm.LoadHistoryCommand.CanExecute(null))
        {
            vm.LoadHistoryCommand.Execute(null);
        }
    }
}