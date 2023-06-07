using CSProject2023L2.Services;
using CSProject2023L2.Services.Contract;
using CSProject2023L2.ViewModels;
using CSProject2023L2.Views;

namespace CSProject2023L2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		ILoginService login = new LoginService(new HttpClient());

        MainPage = new LoginView(new LoginViewModel(login));
	}
}
