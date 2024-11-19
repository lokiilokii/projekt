namespace projekt
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {

        }

        public async void OnKineticEnergyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KineticEnergyPage());
        }

        public async void OnWorkDoneClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkDonePage());
        }
    }

}
