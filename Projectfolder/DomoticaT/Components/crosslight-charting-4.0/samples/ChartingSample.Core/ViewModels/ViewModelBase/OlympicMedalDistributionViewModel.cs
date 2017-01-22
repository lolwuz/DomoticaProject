using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class OlympicMedalDistributionViewModel<TSeriesType> : ChartViewModelBase<TSeriesType> where TSeriesType : Series, new()
    {
        #region Methods

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                Series series = this.CreateSeries();
                series.Items.Add(new DataPoint("Indonesia", random.Next(0, 100)));
                series.Items.Add(new DataPoint("Singapore", random.Next(0, 100)));
                series.Items.Add(new DataPoint("Malaysia", random.Next(0, 100)));
                series.Items.Add(new DataPoint("Australia", random.Next(0, 100)));
                series.Items.Add(new DataPoint("Brunei", random.Next(0, 100)));

                this.Chart.Series.Add(series);
            }
        }

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Olympic Medals Distribution";

            Series series = this.CreateSeries();
            series.Title = "Gold Medal";
            series.Items = this.DataManager.GetOlympicMedalDistributionDataBasedOnMedalType("Gold");
            this.Chart.Series.Add(series);

            series = this.CreateSeries();
            series.Title = "Silver Medal";
            series.Items = this.DataManager.GetOlympicMedalDistributionDataBasedOnMedalType("Silver");
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            Series series = this.CreateSeries();
            series.Title = "Gold Medal";
            series.Items = this.DataManager.GetOlympicMedalDistributionDataBasedOnMedalType("Gold");
            seriesSource.Add(series);

            series = this.CreateSeries();
            series.Title = "Silver Medal";
            series.Items = this.DataManager.GetOlympicMedalDistributionDataBasedOnMedalType("Silver");
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
        }

        #endregion
    }
}