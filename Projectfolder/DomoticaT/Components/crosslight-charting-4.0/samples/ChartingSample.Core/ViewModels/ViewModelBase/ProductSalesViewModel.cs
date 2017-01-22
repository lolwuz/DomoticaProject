using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class ProductSalesViewModel<TSeriesType> : ChartViewModelBase<TSeriesType> where TSeriesType : Series, new()
    {
        #region Methods

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                Series series = new TSeriesType();
                series.Items.Add(new DataPoint(new DateTime(2014, 1, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 2, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 3, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 4, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 5, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 6, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 7, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 8, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 9, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 10, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 11, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2014, 12, 1), random.Next(0, 100)));
                this.Chart.Series.Add(series);
            }
        }

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Product Sales in 2014";

            Series series = this.CreateSeries();
            series.Title = "Crosslight";
            series.Items = this.DataManager.GetProductSalesDataBasedOnCategoryAndYear("Crosslight", 2014);
            this.Chart.Series.Add(series);

            series = this.CreateSeries();
            series.Title = "Client UI";
            series.Items = this.DataManager.GetProductSalesDataBasedOnCategoryAndYear("ClientUI", 2014);
            this.Chart.Series.Add(series);

            series = this.CreateSeries();
            series.Title = "WebGrid";
            series.Items = this.DataManager.GetProductSalesDataBasedOnCategoryAndYear("WebGrid", 2014);
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            DateTimeAxis dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            Series series = this.CreateSeries();
            series.Title = "Crosslight";
            series.Items = this.DataManager.GetProductSalesDataBasedOnCategoryAndYear("Crosslight", 2014);
            seriesSource.Add(series);

            series = this.CreateSeries();
            series.Title = "Client UI";
            series.Items = this.DataManager.GetProductSalesDataBasedOnCategoryAndYear("ClientUI", 2014);
            seriesSource.Add(series);

            series = this.CreateSeries();
            series.Title = "WebGrid";
            series.Items = this.DataManager.GetProductSalesDataBasedOnCategoryAndYear("WebGrid", 2014);
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
        }

        #endregion
    }
}