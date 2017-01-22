using ChartingSample.ViewModels;
using Intersoft.Crosslight;

namespace ChartingSample.Infrastructure
{
    public sealed class CrosslightAppAppService : ApplicationServiceBase
    {
        #region Constructors

        public CrosslightAppAppService(IApplicationContext context)
            : base(context)
        {
        }

        #endregion

        #region Methods

        protected override void OnStart(StartParameter parameter)
        {
            base.OnStart(parameter);
            this.SetRootViewModel<DrawerViewModel>();
        }

        #endregion
    }
}