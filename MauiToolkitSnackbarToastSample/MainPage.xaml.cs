using CommunityToolkit.Maui.Alerts;

namespace MauiToolkitSnackbarToastSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		string message;

		if (count == 1)
            message = $"Clicked {count} time";
		else
            message = $"Clicked {count} times";

		SemanticScreenReader.Announce(message);

		CounterBtn.Text = message;

		//var toast = Toast.Make(message, CommunityToolkit.Maui.Core.ToastDuration.Long, 30);
		//toast.Show();

		var snackbar = Snackbar.Make(message, () => DisplayAlert("Did you subscribe", "to my channel yet?", "OK"), "YES!",
			TimeSpan.FromSeconds(10), new CommunityToolkit.Maui.Core.SnackbarOptions
			{
				BackgroundColor = Colors.Red,
				TextColor = Colors.White,
			}, dotnetbotimage);

		snackbar.Show();
	}
}

