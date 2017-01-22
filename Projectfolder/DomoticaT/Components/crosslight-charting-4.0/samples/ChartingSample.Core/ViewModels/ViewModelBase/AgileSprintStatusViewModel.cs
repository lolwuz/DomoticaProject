using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class AgileSprintStatusViewModel<TSeriesType> : ChartViewModelBase<TSeriesType> where TSeriesType : Series, new()
    {
        #region Methods

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                Series series = this.CreateSeries();
                series.Items.Add(new DataPoint("Android", random.Next(0, 100)));
                series.Items.Add(new DataPoint("iOS", random.Next(0, 100)));
                series.Items.Add(new DataPoint("Windows Phone", random.Next(0, 100)));
                series.Items.Add(new DataPoint("Data", random.Next(0, 100)));
                series.Items.Add(new DataPoint("Framework", random.Next(0, 100)));

                this.Chart.Series.Add(series);
            }
        }

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Agile Sprint Status";

            Series series = this.CreateSeries();
            series.Title = "In Progress";
            series.Items = this.DataManager.GetAgileDataBasedOnStatus("InProgress");
            this.Chart.Series.Add(series);

            if (typeof(TSeriesType) != typeof(DoughnutSeries) && typeof(TSeriesType) != typeof(PieSeries))
            {
                if (!(this is AreaFillStyleViewModel))
                {
                    series = this.CreateSeries();
                    series.Title = "Resolved";
                    series.Items = this.DataManager.GetAgileDataBasedOnStatus("Resolved");
                    this.Chart.Series.Add(series);
                }
            }

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            Series series = this.CreateSeries();
            series.Title = "In Progress";
            series.Items = this.DataManager.GetAgileDataBasedOnStatus("InProgress");
            seriesSource.Add(series);

            if (typeof(TSeriesType) != typeof(DoughnutSeries) && typeof(TSeriesType) != typeof(PieSeries))
            {
                if (!(this is AreaFillStyleViewModel))
                {
                    series = this.CreateSeries();
                    series.Title = "Resolved";
                    series.Items = this.DataManager.GetAgileDataBasedOnStatus("Resolved");
                    seriesSource.Add(series);
                }
            }

            this.Chart.Series = seriesSource;
        }

        #endregion
    }
}