using ChartingSample.Models;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class StepLineViewModel : ViewModelBase
    {
        #region Fields

        private Chart _chart;
        private DataManager _dataManager = DataManager.Instance;

        #endregion

        #region Properties

        public Chart Chart
        {
            get { return _chart; }
            set
            {
                _chart = value;
                OnPropertyChanged("Chart");
            }
        }

        public DelegateCommand ShowPresenterCommand { get; set; }

        #endregion

        #region Constructors

        public StepLineViewModel()
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
                    "Add Series",
                    "Delete Series",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangeData();
                                          else if (resultIndex == 1)
                                              this.AddSeries();
                                          else if (resultIndex == 2)
                                              this.DeleteSeries();
                                          else if (resultIndex == 3)
                                              this.ResetSeries();

                                      });
        }

        private void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                StepLineSeries series = new StepLineSeries();
                series.Items.Add(new DataPoint(new DateTime(2006, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2007, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2008, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2009, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2010, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2011, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2012, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2013, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2014, 1, 1), random.Next(10000000, 100000000)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 1), random.Next(10000000, 100000000)));
                this.Chart.Series.Add(series);
            }
        }

        private void DeleteSeries()
        {
            if (this.Chart.Series.Count > 1)
                this.Chart.Series.RemoveAt(this.Chart.Series.Count - 1);
        }

		private void ResetSeries()
		{
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            StepLineSeries series = new StepLineSeries();
            series.Title = "United States";
            series.Items = _dataManager.GetPopulationCountBasedOnCountry("United States");
            seriesSource.Add(series);

            series = new StepLineSeries();
            series.Title = "United Kingdom";
            series.Items = _dataManager.GetPopulationCountBasedOnCountry("United Kingdom");
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
		}

        private void ChangeData()
        {
            Random random = new Random();
            foreach (Series seriesData in this.Chart.Series)
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    dataPoint.IndependentValue = random.Next(10000000, 100000000);
                }
            }
            this.Chart.RefreshDataPoint();
        }

        private void GenerateData()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Population Count";

            StepLineSeries series = new StepLineSeries();
            series.Title = "United States";
            series.Items = _dataManager.GetPopulationCountBasedOnCountry("United States");
            this.Chart.Series.Add(series);

            series = new StepLineSeries();
            series.Title = "United Kingdom";
            series.Items = _dataManager.GetPopulationCountBasedOnCountry("United Kingdom");
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>
                (o=>{
                    o.NumberFormat = "#,##0,,M";
                    o.IsOriginVisible = false;
                });
            DateTimeAxis dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;

        }

        #endregion
    }
}