using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Website Statistics")]
    [ImportBinding(typeof(ReferenceSampleBindingProvider))]
    public class ReferenceSampleFragment : Fragment<ReferenceSampleViewModel>
    {
        #region Constructors

        public ReferenceSampleFragment()
            : base(Resource.Layout.ReferenceSample)
        {
        }

        #endregion

        #region Properties

        protected override int MenuLayoutId
        {
            get
            {
                return Resource.Layout.menu;
            }
        }

        #endregion
    }

}