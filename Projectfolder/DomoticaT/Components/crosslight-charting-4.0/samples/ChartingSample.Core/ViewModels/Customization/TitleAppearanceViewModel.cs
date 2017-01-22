using Intersoft.Crosslight.UI.DataVisualization;

namespace ChartingSample.ViewModels
{
    public class TitleAppearanceViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        protected override void InitializeChart()
        {
            base.InitializeChart();

            this.Chart.Title.TitleAlignment = TitleAlignments.Left;
            this.Chart.Title.Text = "Intersoft Agile Status";
            this.Chart.Title.Font = new Font("Helvetica,20,Bold,#0000FF;Arial,20,Bold,Italic,#0000FF");
            this.Chart.Title.Margin = new Thickness(0, 10, 0, 0);
        }
    }
}