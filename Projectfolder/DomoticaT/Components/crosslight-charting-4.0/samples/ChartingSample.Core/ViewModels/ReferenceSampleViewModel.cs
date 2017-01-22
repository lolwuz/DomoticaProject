using ChartingSample.Core;
using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class ReferenceSampleViewModel : ViewModelBase
    {
        #region Fields

        private int _totalUser;
        private int _totalDownload;
        private int _totalUpload;
        private int _totalCrashes;
        private DataManager _dataManager = DataManager.Instance;

        #endregion

        #region Properties

        public Chart Chart2 { get; set; }

        public Chart Chart3 { get; set; }

        public Chart Chart4 { get; set; }

        public Chart Chart { get; set; }

        public DelegateCommand ShowPresenterCommand { get; set; }

        public int TotalUser
        {
            get
            {
                return _totalUser;
            }
            set
            {
                if(value!=_totalUser)
                {
                    _totalUser = value;
                    this.OnPropertyChanged("TotalUser");
                }
            }
        }

        public int TotalDownload
        {
            get
            {
                return _totalDownload;
            }
            set
            {
                if (value != _totalDownload)
                {
                    _totalDownload = value;
                    this.OnPropertyChanged("TotalDownload");
                }
            }
        }

        public int TotalUpload
        {
            get
            {
                return _totalUpload;
            }
            set
            {
                if (value != _totalUpload)
                {
                    _totalUpload = value;
                    this.OnPropertyChanged("TotalUpload");
                }
            }
        }

        public int TotalCrashes
        {
            get
            {
                return _totalCrashes;
            }
            set
            {
                if (value != _totalCrashes)
                {
                    _totalCrashes = value;
                    this.OnPropertyChanged("TotalCrashes");
                }
            }
        }

        #endregion

        #region Constructors

        public ReferenceSampleViewModel()
        {
            this.ShowPresenterCommand = new DelegateCommand(this.ExecuteShowPresenter);
            this.GenerateData();
        }

        #endregion

        #region Methods

        private void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Change Data",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangeData();
                                          else if (resultIndex == 1)
                                              this.ResetSeries();

                                      });
        }

        private void ResetSeries()
        {
            this.TotalUser = 2087;
            this.TotalDownload = 1509;
            this.TotalUpload = 958;
            this.TotalCrashes = 135;

            Series series;
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            series = new AreaSeries();
            series.Title = "User";
            series.IsDataPointVisible = false;
            series.PaletteResources = new PaletteResources(new SolidColor(Color.FromArgb(255, 88, 114, 253)));
            series.Items = _dataManager.GetWebsiteStatisticDataBasedOnDescriptionAndDate("User", new DateTime(2015, 1, 1), new DateTime(2015, 1, 5));
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;

            seriesSource = new ObservableCollection<Series>();

            series = new AreaSeries();
            series.Title = "Download";
            series.IsDataPointVisible = false;
            series.PaletteResources = new PaletteResources(new SolidColor(Color.FromArgb(255, 5, 226, 117)));
            series.Items = _dataManager.GetWebsiteStatisticDataBasedOnDescriptionAndDate("Download", new DateTime(2015, 1, 1), new DateTime(2015, 1, 5));
            seriesSource.Add(series);

            this.Chart2.Series = seriesSource;

            seriesSource = new ObservableCollection<Series>();

            series = new AreaSeries();
            series.Title = "Upload";
            series.IsDataPointVisible = false;
            series.PaletteResources = new PaletteResources(new SolidColor(Color.FromArgb(255, 217, 39, 255)));
            series.Items = _dataManager.GetWebsiteStatisticDataBasedOnDescriptionAndDate("Upload", new DateTime(2015, 1, 1), new DateTime(2015, 1, 5));
            seriesSource.Add(series);

            this.Chart3.Series = seriesSource;

            seriesSource = new ObservableCollection<Series>();

            series = new AreaSeries();
            series.Title = "Crashes";
            series.IsDataPointVisible = false;
            series.PaletteResources = new PaletteResources(new SolidColor(Color.FromArgb(255, 0, 176, 254)));
            series.Items = _dataManager.GetWebsiteStatisticDataBasedOnDescriptionAndDate("Crashes", new DateTime(2015, 1, 1), new DateTime(2015, 1, 5));
            seriesSource.Add(series);

            this.Chart4.Series = seriesSource;
        }

        private void ChangeData()
        {
            int totalUser = 0;
            int totalDownload = 0;
            int totalUpload = 0;
            int totalCrashes = 0;

            Random random = new Random();
            foreach (Series seriesData in this.Chart.Series)
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    dataPoint.IndependentValue = random.Next(100, 500);
                    totalUser += (int)dataPoint.IndependentValue;
                }
            }
            this.TotalUser = totalUser;
            this.Chart.RefreshDataPoint();

            foreach (Series seriesData in this.Chart2.Series)
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    dataPoint.IndependentValue = random.Next(250, 400);
                    totalDownload += (int)dataPoint.IndependentValue;
                }
            }
            this.TotalDownload = totalDownload;
            this.Chart2.RefreshDataPoint();

            foreach (Series seriesData in this.Chart3.Series)
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    dataPoint.IndependentValue = random.Next(100, 500);
                    totalUpload += (int)dataPoint.IndependentValue;
                }
            }
            this.TotalUpload = totalUpload;
            this.Chart3.RefreshDataPoint();

            foreach (Series seriesData in this.Chart4.Series)
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    dataPoint.IndependentValue = random.Next(100, 500);
                    totalCrashes += (int)dataPoint.IndependentValue;
                }
            }
            this.TotalCrashes = totalCrashes;
            this.Chart4.RefreshDataPoint();
        }

        private void GenerateData()
        {
            this.TotalUser = 2087;
            this.TotalDownload = 1509;
            this.TotalUpload = 958;
            this.TotalCrashes = 135;

            Series series;
            //Chart 1
            this.Chart = new Chart();

            series = new AreaSeries();
            series.Title = "User";
            series.IsDataPointVisible = false;
            series.PaletteResources = new PaletteResources(new SolidColor(Color.FromArgb(255, 88, 114, 253)));
            series.Items = _dataManager.GetWebsiteStatisticDataBasedOnDescriptionAndDate("User", new DateTime(2015, 1, 1), new DateTime(2015, 1, 5));
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>(o => { o.IsOriginVisible = false; o.TextWidth = 25; });
            DateTimeAxis dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>(o => { o.IsVisible = false; });

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;

            // Chart2
            this.Chart2 = new Chart();

            series = new AreaSeries();
            series.Title = "Download";
            series.IsDataPointVisible = false;
            series.PaletteResources = new PaletteResources(new SolidColor(Color.FromArgb(255, 5, 226, 117)));
            series.Items = _dataManager.GetWebsiteStatisticDataBasedOnDescriptionAndDate("Download", new DateTime(2015, 1, 1), new DateTime(2015, 1, 5));
            this.Chart2.Series.Add(series);

            independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>(o => { o.IsOriginVisible = false; o.TextWidth = 25; });
            dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>(o => { o.IsVisible = false; });

            this.Chart2.IndependentAxis = independentAxis;
            this.Chart2.DependentAxis = dependentAxis;

            // Chart3
            this.Chart3 = new Chart();

            series = new AreaSeries();
            series.Title = "Upload";
            series.IsDataPointVisible = false;
            series.PaletteResources = new PaletteResources(new SolidColor(Color.FromArgb(255, 217, 39, 255)));
            series.Items = _dataManager.GetWebsiteStatisticDataBasedOnDescriptionAndDate("Upload", new DateTime(2015, 1, 1), new DateTime(2015, 1, 5));
            this.Chart3.Series.Add(series);

            independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>(o => { o.IsOriginVisible = false; o.TextWidth = 25; });
            dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>(o => { o.IsVisible = false; });

            this.Chart3.IndependentAxis = independentAxis;
            this.Chart3.DependentAxis = dependentAxis;

            // Chart4
            this.Chart4 = new Chart();

            series = new AreaSeries();
            series.Title = "Crashes";
            series.IsDataPointVisible = false;
            series.PaletteResources = new PaletteResources(new SolidColor(Color.FromArgb(255, 0, 176, 254)));
            series.Items = _dataManager.GetWebsiteStatisticDataBasedOnDescriptionAndDate("Crashes", new DateTime(2015, 1, 1), new DateTime(2015, 1, 5));
            this.Chart4.Series.Add(series);

            independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>(o => { o.IsOriginVisible = false; o.TextWidth = 25; });
            dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>(o => { o.DateFormat = "dd/MM"; });

            this.Chart4.IndependentAxis = independentAxis;
            this.Chart4.DependentAxis = dependentAxis;

            this.Chart.Title.Visibility = Visibility.Collapsed;
            this.Chart2.Title.Visibility = Visibility.Collapsed;
            this.Chart3.Title.Visibility = Visibility.Collapsed;
            this.Chart4.Title.Visibility = Visibility.Collapsed;

            this.Chart.Legend.Visibility = Visibility.Collapsed;
            this.Chart2.Legend.Visibility = Visibility.Collapsed;
            this.Chart3.Legend.Visibility = Visibility.Collapsed;
            this.Chart4.Legend.Visibility = Visibility.Collapsed;

            this.Chart.Margin = new Thickness(0, 0, 0, 0);
            this.Chart2.Margin = new Thickness(0, 0, 0, 0);
            this.Chart3.Margin = new Thickness(0, 0, 0, 0);
            this.Chart4.Margin = new Thickness(0, 0, 0, 0);
        }

        #endregion
    }
}