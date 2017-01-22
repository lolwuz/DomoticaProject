using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Line Series")]
    [ImportBinding(typeof(LineBindingProvider))]
    public class LineFragment : ChartViewSampleFragment<LineViewModel>
    {
    }

}