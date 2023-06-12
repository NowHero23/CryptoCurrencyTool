using CryptoCurrencyTool.Commands;
using CryptoCurrencyTool.Models;
using CryptoCurrencyTool.Services;
using CryptoCurrencyTool.Stores;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoCurrencyTool.ViewModels
{
    public class HistoryViewModel : ViewModelBase
    {
        public static ICommand UpdateHistoryCommand { get; private set; }

        private DateTime _startDate = DateTime.Today.AddMonths(-1);
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _startTime = DateTime.Now;
        public DateTime StartTime
        {
            get => _startTime;
            set
            {
                _startTime = value;
                OnPropertyChanged(nameof(StartTime));
            }
        }

        private DateTime _endDate = DateTime.Today;
        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        private DateTime _endTime = DateTime.Now;
        public DateTime EndTime
        {
            get => _endTime;
            set
            {
                _endTime = value;
                OnPropertyChanged(nameof(EndTime));
            }
        }

        private string _selectedInterval = "d1";
        public string SelectedInterval
        {
            get => _selectedInterval;
            set
            {
                _selectedInterval = value;
                OnPropertyChanged(nameof(SelectedInterval));
            }
        }


        private static SeriesCollection _seriesCollection = new SeriesCollection();
        public SeriesCollection SeriesCollection
        {
            get => _seriesCollection;
            private set
            {
                _seriesCollection = value;
                OnPropertyChanged(nameof(SeriesCollection));
            }
        }
        public static HistoryStore HistoryStore { get; private set; }

        public HistoryViewModel(HistoryStore historyStore, string id)
        {
            if (HistoryStore == null) HistoryStore = historyStore;
            HistoryStore.HistoryChanged += HistoryChangedEventHandler;


            UpdateHistoryCommand = new ActionCommand(() =>
            {
                long start = (long)(StartDate + StartTime.TimeOfDay).ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
                long end = (long)(EndDate + EndTime.TimeOfDay).ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;

                UpdateHistoryDataAsync(id, SelectedInterval, start, end);
            });

            UpdateHistoryCommand.Execute(id);
        }
        public HistoryViewModel() { }
        public override void Dispose()
        {
            HistoryStore.HistoryChanged -= HistoryChangedEventHandler;
            base.Dispose();
        }

        private void HistoryChangedEventHandler()
        {
            var values = new ChartValues<DateTimePoint>();
            if (HistoryStore.History.Data == null) return;
            foreach (var item in HistoryStore.History.Data)
            {
                var time = DateTimeOffset.FromUnixTimeMilliseconds(item.time).DateTime;
                values.Add(new DateTimePoint(time, item.PriceUsd));
            }

            var series = new LineSeries
            {
                Values = values,
                //Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 7,
                LineSmoothness = 0,
                StrokeThickness = 1
            };

            SeriesCollection = new SeriesCollection { series }; 
        }
        
        public static Func<double, string> XFormatter { get; set; } = val => new DateTime((long)val).ToString("dd MMM yyyy HH:MM");

        public async void UpdateHistoryDataAsync(string Id, string interval = "d1", long start = 0, long end = 0)
        {
            History tmp = await ApiService.GetHistoryDataAsync(Id, interval, start, end);

            if (tmp == HistoryStore.History) return;

            HistoryStore.History = tmp;
        }
    }
}
