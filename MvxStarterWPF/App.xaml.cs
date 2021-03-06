using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace MvxStarterWPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : MvxApplication
	{
		protected override void RegisterSetup()
		{
			this.RegisterSetupType<MvxWpfSetup<MvxStarter.Core.App>>();
		}
	}
}
