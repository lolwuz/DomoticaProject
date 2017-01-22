using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Title Position")]
    [ImportBinding(typeof(TitlePositionBindingProvider))]
    public class TitlePositionFragment : ChartViewSampleFragment<TitlePositionViewModel>
    {
    }

}