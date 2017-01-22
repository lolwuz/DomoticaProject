using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Title Appearance")]
    [ImportBinding(typeof(TitleAppearanceBindingProvider))]
    public class TitleAppearanceFragment : ChartViewSampleFragment<TitleAppearanceViewModel>
    {
    }

}