
namespace projekt;

public partial class KineticEnergyPage : ContentPage
{
	public KineticEnergyPage()
	{

	}
    public void OnButtonClicked(object sender, EventArgs e)
    {
try
        {
            double mass = Convert.ToDouble(Mass.Text);
            double velocity = Convert.ToDouble(Velocity.Text);

            double kineticEnergy = 0.5 * mass * Math.Pow(velocity, 2);

            Result.Text = $"Kinetic Energy: {kineticEnergy} Joules";
        }
        catch (Exception ex)
        {
            Result.Text = "Please enter valid numbers!";
        }
   }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
