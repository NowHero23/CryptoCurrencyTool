using CryptoCurrencyTool.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoCurrencyTool.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public ICommand ApplySettingsCommand { get; private set; }

        private string _selectedLanguage;
        public string SelectedLanguage
        {
            get => _selectedLanguage;
            set
            {
                _selectedLanguage = value;
                OnPropertyChanged("Language");

            }
        }

        private List<string> _languages;
        public List<string> Languages
        {
            get => _languages;
            set
            {
                _languages = value;
                OnPropertyChanged("Languages");

            }
        }

        public SettingsViewModel()
        {
            ApplySettingsCommand = new ActionCommand(ApplySettings);
            _selectedLanguage = Properties.Settings.Default.languageCode;
            _languages = new List<string>();
            Languages.Add("en-US");
            Languages.Add("uk-UA");
        }

        private void ApplySettings()
        {
            Properties.Settings.Default.languageCode = SelectedLanguage;

            Properties.Settings.Default.Save();

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(SelectedLanguage);
            OnPropertyChanged("SelectedLanguage");
        }
    }
}
