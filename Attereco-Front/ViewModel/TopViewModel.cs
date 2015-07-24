using GalaSoft.MvvmLight;
using Attereco_Front.Model.Common;

namespace Attereco_Front.ViewModel
{
    public class TopViewModel : ViewModelBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TopViewModel()
        {
            FormVM = new FormViewModel(new AtterecoClient());
        }

        #region FormViewModel FormVM

        /// <summary>
        /// FormViewModelのインスタンス
        /// </summary>
        public FormViewModel FormVM { get; set; }

        #endregion
    }
}