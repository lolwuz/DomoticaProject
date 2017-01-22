using Android.App;
using ChartingSample.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using Android.Graphics;

namespace ChartingSample.Android
{
    [Activity(Icon = "@drawable/icon")]
    [ImportBinding(typeof(MainDrawerBindingProvider))]
    [RegisterNavigation(IsRootView = true)]
    public class MainDrawerActivity : DrawerActivity<DrawerViewModel>
    {
        #region Properties

        protected override DrawerSettings DrawerSettings
        {
            get
            {
                DrawerSettings setting = new DrawerSettings();
                setting.LeftDrawerBackgroundColor = Color.White;
                return setting;
            }
        }

        #endregion
    }
}