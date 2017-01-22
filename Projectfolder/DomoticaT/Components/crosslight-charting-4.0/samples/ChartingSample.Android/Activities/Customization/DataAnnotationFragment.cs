using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Data Annotation")]
    [ImportBinding(typeof(DataAnnotationBindingProvider))]
    public class DataAnnotationFragment : ChartViewSampleFragment<DataAnnotationViewModel>
    {
    }

}