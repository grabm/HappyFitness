namespace HappyFitness.Mobile.ViewModels
{
    public class GymViewModel : ContentPage
    {
        public GymViewModel(GymViewModel viewModel)
        {
            BindingContext = viewModel;
        }
    }
}
