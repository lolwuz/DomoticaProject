using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Additional Numeric GridLines")]
    [ImportBinding(typeof(AdditionalNumericGridLinesBindingProvider))]
    public class AdditionalNumericGridLinesFragment : ChartViewSampleFragment<AdditionalNumericGridLinesViewModel>
    {
    }

}