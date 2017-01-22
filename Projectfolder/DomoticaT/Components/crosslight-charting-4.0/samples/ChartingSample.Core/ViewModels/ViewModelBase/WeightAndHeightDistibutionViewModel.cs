using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class WeightAndHeightViewModel<TSeriesType> : ChartViewModelBase<TSeriesType> where TSeriesType : Series, new()
    {
        #region Methods

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                Series series = this.CreateSeries();
                series.Items.Add(new DataPoint(44, random.Next(150, 200)));
                series.Items.Add(new DataPoint(50, random.Next(150, 200)));
                series.Items.Add(new DataPoint(72, random.Next(150, 200)));
                series.Items.Add(new DataPoint(62, random.Next(150, 200)));
                series.Items.Add(new DataPoint(54, random.Next(150, 200)));

                this.Chart.Series.Add(series);
            }
        }

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Weight and Height Distribution";

            Series series = this.CreateSeries();
            series.Title = "Male";
            series.Items = this.DataManager.GetWeightAndHeightDistributionDataBasedOnSex("Male");
            this.Chart.Series.Add(series);

            series = this.CreateSeries();
            series.Title = "Female";
            series.Items = this.DataManager.GetWeightAndHeightDistributionDataBasedOnSex("Female");
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>(o => { o.IsOriginVisible = false; });
            NumericAxis dependentAxis = Axis.CreateDefaultDependentAxis<NumericAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            Series series = this.CreateSeries();
            series.Title = "Male";
            series.Items = this.DataManager.GetWeightAndHeightDistributionDataBasedOnSex("Male");
            seriesSource.Add(series);

            series = this.CreateSeries();
            series.Title = "Female";
            series.Items = this.DataManager.GetWeightAndHeightDistributionDataBasedOnSex("Female");
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
                    dataPoint.IndependentValue = random.Next(150, 200);
                }
            }
            this.Chart.RefreshDataPoint();
        }

        #endregion
    }
}