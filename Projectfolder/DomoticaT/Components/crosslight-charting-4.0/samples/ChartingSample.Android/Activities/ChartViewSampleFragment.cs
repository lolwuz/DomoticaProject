using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    public class ChartViewSampleFragment<TViewModel> : Fragment<TViewModel> where TViewModel : class, IViewModel
    {
        #region Constructors

        public ChartViewSampleFragment()
            : base(Resource.Layout.MainLayout)
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