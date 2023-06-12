using CryptoCurrencyTool.Services;
using CryptoCurrencyTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.Commands
{
    public class ParameterNavigeteCommand<TParameter, TViewModel> : CommandBase
         where TViewModel : ViewModelBase
    {
        private readonly ParameterNavigationService<TParameter, TViewModel> _navigationService;

        public ParameterNavigeteCommand(ParameterNavigationService<TParameter, TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate((TParameter)parameter);
        }
    }
}