using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class MultipleSeriesViewModel<TSeriesType,TSeriesType2> : ChartViewModelBase 
        where TSeriesType : Series, new()
        where TSeriesType2 : Series, new()
    {
        #region Methods

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                if (this.Chart.Series[this.Chart.Series.Count - 1] is TSeriesType2)
                {
                    Series series = new TSeriesType();
                    series.Items.Add(new DataPoint("Indonesia", random.Next(0, 100)));
                    series.Items.Add(new DataPoint("Singapore", random.Next(0, 100)));
                    series.Items.Add(new DataPoint("Australia", random.Next(0, 100)));
                    series.Items.Add(new DataPoint("Malaysia", random.Next(0, 100)));
                    series.Items.Add(new DataPoint("Philippine", random.Next(0, 100)));
                    this.Chart.Series.Add(series);
                }
                else
                {
                    Series series = new TSeriesType2();
                    series.Items.Add(new DataPoint("Indonesia", random.Next(0, 100)));
                    series.Items.Add(new DataPoint("Singapore", random.Next(0, 100)));
                    series.Items.Add(new DataPoint("Australia", random.Next(0, 100)));
                    series.Items.Add(new DataPoint("Malaysia", random.Next(0, 100)));
                    series.Items.Add(new DataPoint("Philippine", random.Next(0, 100)));
                    this.Chart.Series.Add(series);
                }
            }
        }

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Olympic Medals Distribution";

            Series series = new TSeriesType();
            series.Title = "Gold Medal";
            series.Items = this.DataManager.GetOlympicMedalDistributionDataBasedOnMedalType("Gold");
            this.Chart.Series.Add(series);

            series = new TSeriesType2();
            series.Title = "Expected Gold Medal";
            series.Items = this.DataManager.GetExpectedOlympicMedalDistributionDataBasedOnMedalType("Gold");
            this.Chart.Series.Add(series);

            series = new TSeriesType();
            series.Title = "Silver Medal";
            series.Items = this.DataManager.GetOlympicMedalDistributionDataBasedOnMedalType("Silver");
            this.Chart.Series.Add(series);

            series = new TSeriesType2();
            series.Title = "Expected Silver Medal";
            series.Items = this.DataManager.GetExpectedOlympicMedalDistributionDataBasedOnMedalType("Silver");
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>(o => { o.Title.Text = "Count"; });
            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>(o => { o.Title.Text = "Country"; });

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            Series series = new ColumnSeries();
            series.Title = "Gold Medal";
            series.Items = this.DataManager.GetOlympicMedalDistributionDataBasedOnMedalType("Gold");
            seriesSource.Add(series);

            series = new TSeriesType2();
            series.Title = "Expected Gold Medal";
            series.Items = this.DataManager.GetExpectedOlympicMedalDistributionDataBasedOnMedalType("Gold");
            seriesSource.Add(series);

            series = new TSeriesType();
            series.Title = "Silver Medal";
            series.Items = this.DataManager.GetOlympicMedalDistributionDataBasedOnMedalType("Silver");
            seriesSource.Add(series);

            series = new TSeriesType2();
            series.Title = "Expected Silver Medal";
            series.Items = this.DataManager.GetExpectedOlympicMedalDistributionDataBasedOnMedalType("Silver");
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
        }

        #endregion
    }
}