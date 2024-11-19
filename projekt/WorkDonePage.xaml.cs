namespace projekt;

public partial class WorkDonePage : ContentPage
{
	public WorkDonePage()
	{

	}
    public void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            double force = Convert.ToDouble(Force.Text);
            double distance = Convert.ToDouble(Distance.Text);

            double workDone = force * distance;

            WorkDone.Text = $"Work Done: {workDone} Joules";
        }
        catch (Exception ex)
        {
            WorkDone.Text = "Please enter valid numbers!";
        }
    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}