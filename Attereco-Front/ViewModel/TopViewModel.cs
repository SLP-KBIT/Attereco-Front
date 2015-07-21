using GalaSoft.MvvmLight;

namespace Attereco_Front.ViewModel
{
    public class TopViewModel : ViewModelBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TopViewModel()
        {
            FormVM = new FormViewModel();
        }

        #region FormViewModel FormVM

        /// <summary>
        /// FormViewModelのインスタンス
        /// </summary>
        public FormViewModel FormVM { get; set; }

        #endregion
    }
}