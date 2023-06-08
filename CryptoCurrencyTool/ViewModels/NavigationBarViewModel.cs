using CryptoCurrencyTool.Commands;
using CryptoCurrencyTool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoCurrencyTool.ViewModels
{
    public class NavigationBarViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateConvertorCommand { get; }
        public ICommand NavigateSettingsCommand { get; }

        public NavigationBarViewModel(
            NavigationService<HomeViewModel> homeNavigationService,
            NavigationService<ConvertorViewModel> convertorNavigationService) {

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
            NavigateConvertorCommand = new NavigateCommand<ConvertorViewModel>(convertorNavigationService);
        }


        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
