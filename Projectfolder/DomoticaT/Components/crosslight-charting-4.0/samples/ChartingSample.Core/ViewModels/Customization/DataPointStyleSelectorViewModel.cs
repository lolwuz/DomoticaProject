using ChartingSample.Core;
using Intersoft.Crosslight.UI.DataVisualization;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class DataPointStyleSelectorViewModel : SurplusOrDeficitViewModel<ColumnSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Surplus or Deficit (Million US $) in 2014";
            this.Chart.Title.Font.FontSize = 16;

            ColumnSeries series = new ColumnSeries();
            series.Title = "Oil";
            series.StyleSelector = new StyleSelectors();
            series.Items = this.DataManager.GetSurplusOrDeficitDataBasedOnYearAndSource("Oil", 2014);
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            ColumnSeries series = new ColumnSeries();
            series.Title = "Oil";
            series.StyleSelector = new StyleSelectors();
            series.Items = this.DataManager.GetSurplusOrDeficitDataBasedOnYearAndSource("Oil", 2014);
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
        }

        #endregion
    }
}