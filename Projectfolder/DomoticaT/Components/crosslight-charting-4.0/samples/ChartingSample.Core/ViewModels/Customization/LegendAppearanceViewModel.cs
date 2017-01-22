using Intersoft.Crosslight.UI.DataVisualization;

namespace ChartingSample.ViewModels
{
    public class LegendAppearanceViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        protected override void InitializeChart()
        {
            base.InitializeChart();

            this.Chart.Legend.Header = "Legend";
            this.Chart.Legend.Font = new Font("Helvetica,12,Bold,#0000FF;Arial,12,Bold,Italic,#0000FF");
            this.Chart.Legend.Margin = new Thickness(0, 0, 10, 0);
        }
    }
}