using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class SurplusOrDeficitViewModel<TSeriesType> : ChartViewModelBase<TSeriesType> where TSeriesType : Series,new()
    {
        #region Methods

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                Series series = this.CreateSeries();
                series.Items.Add(new DataPoint("Indonesia", random.Next(-100, 100)));
                series.Items.Add(new DataPoint("Singapore", random.Next(-100, 100)));
                series.Items.Add(new DataPoint("Malaysia", random.Next(-100, 100)));
                series.Items.Add(new DataPoint("Australia", random.Next(-100, 100)));
                series.Items.Add(new DataPoint("Brunei", random.Next(-100, 100)));

                this.Chart.Series.Add(series);
            }
        }

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Surplus or Deficit (Million US $) in 2014";
            this.Chart.Title.Font.FontSize = 16;

            Series series = this.CreateSeries();
            series.Title = "Oil";
            series.Items = this.DataManager.GetSurplusOrDeficitDataBasedOnYearAndSource("Oil", 2014);
            this.Chart.Series.Add(series);

            series = this.CreateSeries();
            series.Title = "Coal";
            series.Items = this.DataManager.GetSurplusOrDeficitDataBasedOnYearAndSource("Coal", 2014);
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
            series.Title = "Oil";
            series.Items = this.DataManager.GetSurplusOrDeficitDataBasedOnYearAndSource("Oil", 2014);
            seriesSource.Add(series);

            series = this.CreateSeries();
            series.Title = "Coal";
            series.Items = this.DataManager.GetSurplusOrDeficitDataBasedOnYearAndSource("Coal", 2014);
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
                    dataPoint.IndependentValue = random.Next(-100, 100);
                }
            }
            this.Chart.RefreshDataPoint();
        }

        #endregion
    }
}