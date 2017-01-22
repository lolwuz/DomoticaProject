using ChartingSample.Core;
using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ChartingSample.ViewModels
{
    public class ReferenceSample2ViewModel : ViewModelBase
    {
        #region Fields

        private int _totalDownTime;
        private DataManager _dataManager = DataManager.Instance;

        #endregion

        #region Properties

        public int TotalDownTime
        {
            get
            {
                return _totalDownTime;
            }
            set
            {
                if (value != _totalDownTime)
                {
                    _totalDownTime = value;
                    this.OnPropertyChanged("TotalDownTime");
                }
            }
        }

        public Chart Chart2 { get; set; }

        public Chart Chart3 { get; set; }

        public Chart Chart { get; set; }

        public DelegateCommand ShowPresenterCommand { get; set; }

        #endregion

        #region Constructors

        public ReferenceSample2ViewModel()
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
            this.TotalDownTime = 640;

            Series series;
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            series = new ColumnSeries();
            series.Title = "Maintenance";
            series.Items = _dataManager.GetDownTimeDataBasedOnCauses("Maintenance");
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Title = "Server Failure";
            series.Items = _dataManager.GetDownTimeDataBasedOnCauses("Server Failure");
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Title = "Network Failure";
            series.Items = _dataManager.GetDownTimeDataBasedOnCauses("Network Failure");
            seriesSource.Add(series);

            series = new LineSeries();
            series.Title = "Total DownTime (Minutes)";
            series.DataAnnotations.Add(new DataAnnotation("Need Attention", 150, "April", Colors.Red));
            series.Items = _dataManager.GetMonthlyTotalDownTimeData();
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;

            seriesSource = new ObservableCollection<Series>();
            series = new DoughnutSeries();
            series.Title = "Causes";
            series.IsDataLabelVisible = true;
            ((DoughnutSeries)series).TextFormat = "{PercentageIndependentValue}";
            series.Items = _dataManager.GetTotalDownTimeData();
            seriesSource.Add(series);

            this.Chart2.Series = seriesSource;

            seriesSource = new ObservableCollection<Series>();
            series = new BarSeries();
            series.StyleSelector = new StyleSelectors();
            series.Title = "DownTime Period";
            series.Items = _dataManager.GetPeriodicDownTimeData();
            seriesSource.Add(series);

            this.Chart3.Series = seriesSource;
        }

        private void ChangeData()
        {
            int totalDownTime = 0;
            int totalJanuary = 0;
            int totalFebruary = 0;
            int totalMarch = 0;
            int totalApril = 0;
            int totalMei = 0;
            Random random = new Random();
            foreach (LineSeries seriesData in this.Chart.Series.OfType<LineSeries>())
            {
                if(seriesData.DataAnnotations.Count>0)
                    seriesData.DataAnnotations.Clear();
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    dataPoint.IndependentValue = random.Next(100, 500);
                    if (dataPoint.DependentValue.Equals("January"))
                        totalJanuary += (int)dataPoint.IndependentValue;
                    if (dataPoint.DependentValue.Equals("February"))
                        totalFebruary += (int)dataPoint.IndependentValue;
                    if (dataPoint.DependentValue.Equals("March"))
                        totalMarch += (int)dataPoint.IndependentValue;
                    if (dataPoint.DependentValue.Equals("April"))
                        totalApril += (int)dataPoint.IndependentValue;
                    if (dataPoint.DependentValue.Equals("Mei"))
                        totalMei += (int)dataPoint.IndependentValue;
                    totalDownTime += (int)dataPoint.IndependentValue;
                }
            }

            foreach (ColumnSeries seriesData in this.Chart.Series.OfType<ColumnSeries>())
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    if (dataPoint.DependentValue.Equals("January"))
                    {
                        if (seriesData.Title.Equals("Maintenance"))
                            dataPoint.IndependentValue = 0.3 * totalJanuary;
                        if (seriesData.Title.Equals("Server Failure"))
                            dataPoint.IndependentValue = 0.25 * totalJanuary;
                        if (seriesData.Title.Equals("Network Failure"))
                            dataPoint.IndependentValue = 0.45 * totalJanuary;
                    }
                    if (dataPoint.DependentValue.Equals("February"))
                    {
                        if (seriesData.Title.Equals("Maintenance"))
                            dataPoint.IndependentValue = 0.3 * totalFebruary;
                        if (seriesData.Title.Equals("Server Failure"))
                            dataPoint.IndependentValue = 0.25 * totalFebruary;
                        if (seriesData.Title.Equals("Network Failure"))
                            dataPoint.IndependentValue = 0.45 * totalFebruary;
                    }
                    if (dataPoint.DependentValue.Equals("March"))
                    {
                        if (seriesData.Title.Equals("Maintenance"))
                            dataPoint.IndependentValue = 0.3 * totalMarch;
                        if (seriesData.Title.Equals("Server Failure"))
                            dataPoint.IndependentValue = 0.25 * totalMarch;
                        if (seriesData.Title.Equals("Network Failure"))
                            dataPoint.IndependentValue = 0.45 * totalMarch;
                    }
                    if (dataPoint.DependentValue.Equals("April"))
                    {
                        if (seriesData.Title.Equals("Maintenance"))
                            dataPoint.IndependentValue = 0.3 * totalApril;
                        if (seriesData.Title.Equals("Server Failure"))
                            dataPoint.IndependentValue = 0.25 * totalApril;
                        if (seriesData.Title.Equals("Network Failure"))
                            dataPoint.IndependentValue = 0.45 * totalApril;
                    }
                    if (dataPoint.DependentValue.Equals("Mei"))
                    {
                        if (seriesData.Title.Equals("Maintenance"))
                            dataPoint.IndependentValue = 0.3 * totalMei;
                        if (seriesData.Title.Equals("Server Failure"))
                            dataPoint.IndependentValue = 0.25 * totalMei;
                        if (seriesData.Title.Equals("Network Failure"))
                            dataPoint.IndependentValue = 0.45 * totalMei;
                    }
                }
            }

            this.Chart.RefreshDataPoint();

            this.TotalDownTime = totalDownTime;

            foreach (Series seriesData in this.Chart2.Series)
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    if (dataPoint.DependentValue.Equals("Maintenance"))
                        dataPoint.IndependentValue = this.TotalDownTime * 0.3;
                    if (dataPoint.DependentValue.Equals("Server Failure"))
                        dataPoint.IndependentValue = this.TotalDownTime * 0.25;
                    if (dataPoint.DependentValue.Equals("Network Failure"))
                        dataPoint.IndependentValue = this.TotalDownTime * 0.45;
                }
            }
            this.Chart2.RefreshDataPoint();

            foreach (Series seriesData in this.Chart3.Series)
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    if (dataPoint.DependentValue.Equals("00.00 - 06.00"))
                        dataPoint.IndependentValue = this.TotalDownTime * 0.3;
                    if (dataPoint.DependentValue.Equals("06.00 - 12.00"))
                        dataPoint.IndependentValue = this.TotalDownTime * 0.2;
                    if (dataPoint.DependentValue.Equals("12.00 - 18.00"))
                        dataPoint.IndependentValue = this.TotalDownTime * 0.1;
                    if (dataPoint.DependentValue.Equals("18.00 - 24.00"))
                        dataPoint.IndependentValue = this.TotalDownTime * 0.4;
                }
            }
            this.Chart3.RefreshDataPoint();
        }

        private void GenerateData()
        {
            this.TotalDownTime = 640;

            Series series;

            //Chart 1
            this.Chart = new Chart();
            this.Chart.Title.Text = "Website Downtime (Minutes)";
            this.Chart.Title.Font = new Font(".HelveticaNeueInterface-Light,14;Roboto,14,Bold");

            series = new ColumnSeries();
            series.Title = "Maintenance";
            series.Items = _dataManager.GetDownTimeDataBasedOnCauses("Maintenance");
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Title = "Server Failure";
            series.Items = _dataManager.GetDownTimeDataBasedOnCauses("Server Failure");
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Title = "Network Failure";
            series.Items = _dataManager.GetDownTimeDataBasedOnCauses("Network Failure");
            this.Chart.Series.Add(series);

            series = new LineSeries();
            series.Title = "Total DownTime (Minutes)";
            series.DataAnnotations.Add(new DataAnnotation("Need Attention", 150, "April", Colors.Red));
            series.Items = _dataManager.GetMonthlyTotalDownTimeData();
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
            this.Chart.ColorPalette.PaletteOrder = PaletteOrders.Random;

            //Chart 2
            this.Chart2 = new Chart();
            this.Chart2.Title.Text = "Causes";
            this.Chart2.Title.Font = new Font(".HelveticaNeueInterface-Light,14;Roboto,14,Bold");
            this.Chart2.ColorPalette.Palette = PaletteTypes.Pastel;

            series = new DoughnutSeries();
            series.Title = "Causes";
            series.IsDataLabelVisible = true;
            ((DoughnutSeries)series).TextFormat = "{PercentageIndependentValue}";
            series.Items = _dataManager.GetTotalDownTimeData();
            this.Chart2.Series.Add(series);

            independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>();

            this.Chart2.IndependentAxis = independentAxis;
            this.Chart2.DependentAxis = dependentAxis;

            //Chart 3
            this.Chart3 = new Chart();
            this.Chart3.Title.Text = "Period";
            this.Chart3.Title.Font = new Font(".HelveticaNeueInterface-Light,14;Roboto,14,Bold");

            series = new BarSeries();
            series.StyleSelector = new StyleSelectors();
            series.Title = "DownTime Period";
            series.Items = _dataManager.GetPeriodicDownTimeData();
            this.Chart3.Series.Add(series);

            independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            dependentAxis= Axis.CreateDefaultDependentAxis<CategoryAxis>();

            this.Chart3.IndependentAxis = independentAxis;
            this.Chart3.DependentAxis = dependentAxis;
            this.Chart3.Legend.Visibility = Visibility.Collapsed;
        }

        #endregion
    }
}