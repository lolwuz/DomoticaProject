using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Website DownTime Statistics")]
    [ImportBinding(typeof(ReferenceSample2BindingProvider))]
    public class ReferenceSample2Fragment : Fragment<ReferenceSample2ViewModel>
    {
        #region Constructors

        public ReferenceSample2Fragment()
            : base(Resource.Layout.ReferenceSample2)
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