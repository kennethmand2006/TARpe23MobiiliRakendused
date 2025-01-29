using ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Views;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
		InitializeComponent();

		this.BindingContext = new CalculaorPageViewModel();

    }
}