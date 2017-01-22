using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "GridLines Style")]
    [ImportBinding(typeof(GridLinesStyleBindingProvider))]
    public class GridLinesStyleFragment : ChartViewSampleFragment<GridLinesStyleViewModel>
    {
    }

}