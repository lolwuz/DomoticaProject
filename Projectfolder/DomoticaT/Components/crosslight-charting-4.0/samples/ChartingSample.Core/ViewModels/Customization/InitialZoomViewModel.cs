using Intersoft.Crosslight;
using Intersoft.Crosslight.UI.DataVisualization;

namespace ChartingSample.ViewModels
{
    public class InitialZoomViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region

        protected override void InitializeChart()
        {
            base.InitializeChart();

            this.Chart.InitialZoomFactor = 2;
            this.Chart.InitialZoomPoint = new Point(0.5f, 0.5f);

            this.ToastPresenter.Show("Initial Zoom Factor : 2 \nInitial Zoom Point = 0.5 , 0.5", ToastDisplayDuration.Short);
        }

        #endregion
    }
}