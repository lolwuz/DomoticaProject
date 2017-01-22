using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Additional DateTime GridLines")]
    [ImportBinding(typeof(AdditionalDateTimeGridLinesBindingProvider))]
    public class AdditionalDateTimeGridLinesFragment : ChartViewSampleFragment<AdditionalDateTimeGridLinesViewModel>
    {
    }

}