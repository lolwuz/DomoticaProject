using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class VehicleCountViewModel<TSeriesType> : ChartViewModelBase<TSeriesType> where TSeriesType : Series, new()
    {
        #region Methods

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                Series series = this.CreateSeries();
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 12, 4, 0, 0), random.Next(-100, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 12, 8, 0, 0), random.Next(-100, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 12, 12, 0, 0), random.Next(-100, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 12, 16, 0, 0), random.Next(-100, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 12, 20, 0, 0), random.Next(-100, 100)));

                this.Chart.Series.Add(series);
            }
        }

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Vehicle Count 12 January 2015";

            Series series = this.CreateSeries();
            series.Title = "Car";
            series.Items = this.DataManager.GetVehicleCountDataBasedOnCategoryAndDay("Car", new DateTime(2015, 1, 12));
            this.Chart.Series.Add(series);

            series = this.CreateSeries();
            series.Title = "Truck";
            series.Items = this.DataManager.GetVehicleCountDataBasedOnCategoryAndDay("Truck", new DateTime(2015, 1, 12));
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            DateTimeAxis dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>(o => { o.DateTimeFormat = "dd-hh:mm tt"; });

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            Series series = this.CreateSeries();
            series.Title = "Car";
            series.Items = this.DataManager.GetVehicleCountDataBasedOnCategoryAndDay("Car", new DateTime(2015, 1, 12));
            seriesSource.Add(series);

            series = this.CreateSeries();
            series.Title = "Truck";
            series.Items = this.DataManager.GetVehicleCountDataBasedOnCategoryAndDay("Truck", new DateTime(2015, 1, 12));
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
        }

        #endregion
    }
}