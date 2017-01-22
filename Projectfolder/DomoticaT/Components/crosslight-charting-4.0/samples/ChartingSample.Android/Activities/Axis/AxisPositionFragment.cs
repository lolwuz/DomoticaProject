using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Axis Position")]
    [ImportBinding(typeof(AxisPositionBindingProvider))]
    public class AxisPositionFragment : ChartViewSampleFragment<AxisPositionViewModel>
    {
    }

}