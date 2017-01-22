using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Legend Position")]
    [ImportBinding(typeof(LegendPositionBindingProvider))]
    public class LegendPositionFragment : ChartViewSampleFragment<LegendPositionViewModel>
    {
    }

}