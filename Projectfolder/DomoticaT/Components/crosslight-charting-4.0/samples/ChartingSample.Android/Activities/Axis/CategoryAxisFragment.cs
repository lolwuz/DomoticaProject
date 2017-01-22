using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Category Axis")]
    [ImportBinding(typeof(CategoryAxisBindingProvider))]
    public class CategoryAxisFragment : ChartViewSampleFragment<CategoryAxisViewModel>
    {
    }

}