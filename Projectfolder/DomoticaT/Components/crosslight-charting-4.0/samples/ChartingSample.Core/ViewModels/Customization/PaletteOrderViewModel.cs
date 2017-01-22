using ChartingSample.Models;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class PaletteOrderViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Change Palette Order",
                    "Change Data",
                    "Add Series",
                    "Delete Series",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangePaletteOrder();
                                          else if (resultIndex == 1)
                                              this.ChangeData();
                                          else if (resultIndex == 2)
                                              this.AddSeries();
                                          else if (resultIndex == 3)
                                              this.DeleteSeries();
                                          else if (resultIndex == 4)
                                              this.ResetSeries();

                                      });
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            ColumnSeries series = new ColumnSeries();
            series.Title = "Open";
            series.Items.Add(new DataPoint("Android", 42));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Title = "In Progress";
            series.Items.Add(new DataPoint("Android", 72));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Title = "Waiting for Review";
            series.Items.Add(new DataPoint("Android", 31));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Title = "Resolved";
            series.Items.Add(new DataPoint("Android", 52));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Title = "Closed";
            series.Items.Add(new DataPoint("Android", 45));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Title = "Unresolved";
            series.Items.Add(new DataPoint("Android", 65));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Items.Add(new DataPoint("Android", 35));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Items.Add(new DataPoint("Android", 15));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Items.Add(new DataPoint("Android", 54));
            seriesSource.Add(series);

            series = new ColumnSeries();
            series.Items.Add(new DataPoint("Android", 34));
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
        }

        private void ChangePaletteOrder()
        {
            if (this.Chart.ColorPalette.PaletteOrder == PaletteOrders.Sequential)
                this.Chart.ColorPalette.PaletteOrder = PaletteOrders.Random;
            else if (this.Chart.ColorPalette.PaletteOrder == PaletteOrders.Custom)
                this.Chart.ColorPalette.PaletteOrder = PaletteOrders.Sequential;
            else if (this.Chart.ColorPalette.PaletteOrder == PaletteOrders.Random)
            {
                this.Chart.ColorPalette.PaletteOrder = PaletteOrders.Custom;
                this.Chart.ColorPalette.PaletteOrderSequence="1,4,7,10,0";
            }
            

            if (this.Chart.ColorPalette.PaletteOrder == PaletteOrders.Sequential)
                this.ToastPresenter.Show("Sequential", ToastDisplayDuration.Short);
            if (this.Chart.ColorPalette.PaletteOrder == PaletteOrders.Custom)
                this.ToastPresenter.Show("Custom", ToastDisplayDuration.Short);
            if (this.Chart.ColorPalette.PaletteOrder == PaletteOrders.Random)
                this.ToastPresenter.Show("Random", ToastDisplayDuration.Short);

            this.Chart.Refresh();
        }

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Intersoft Agile Status";

            ColumnSeries series = new ColumnSeries();
            series.Title = "Open";
            series.Items.Add(new DataPoint("Android", 42));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Title = "In Progress";
            series.Items.Add(new DataPoint("Android", 72));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Title = "Waiting for Review";
            series.Items.Add(new DataPoint("Android", 31));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Title = "Resolved";
            series.Items.Add(new DataPoint("Android", 52));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Title = "Closed";
            series.Items.Add(new DataPoint("Android", 45));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Title = "Unresolved";
            series.Items.Add(new DataPoint("Android", 65));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Items.Add(new DataPoint("Android", 35));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Items.Add(new DataPoint("Android", 15));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Items.Add(new DataPoint("Android", 54));
            this.Chart.Series.Add(series);

            series = new ColumnSeries();
            series.Items.Add(new DataPoint("Android", 34));
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        #endregion
    }
}