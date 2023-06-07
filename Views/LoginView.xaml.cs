using CSProject2023L2.ViewModels;

namespace CSProject2023L2.Views;

public partial class LoginView : ContentPage
{
	public LoginView(LoginViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}