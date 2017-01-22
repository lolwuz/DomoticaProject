using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class PopulationCountViewModel<TSeriesType> : ChartViewModelBase<TSeriesType> where TSeriesType : Series, new()
    {
        #region Methods

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                Series series = this.CreateSeries();
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

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Population Count";

            Series series = this.CreateSeries();
            series.Title = "United States";
            series.Items = this.DataManager.GetPopulationCountBasedOnCountry("United States");
            this.Chart.Series.Add(series);

            series = this.CreateSeries();
            series.Title = "United Kingdom";
            series.Items = this.DataManager.GetPopulationCountBasedOnCountry("United Kingdom");
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>
                (o =>
                {
                    o.NumberFormat = "#,##0,,M";
                    o.IsOriginVisible = false;
                });
            DateTimeAxis dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            Series series = this.CreateSeries();
            series.Title = "United States";
            series.Items = this.DataManager.GetPopulationCountBasedOnCountry("United States");
            seriesSource.Add(series);

            series = this.CreateSeries();
            series.Title = "United Kingdom";
            series.Items = this.DataManager.GetPopulationCountBasedOnCountry("United Kingdom");
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
        }

        protected override void ChangeData()
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

        #endregion
    }
}