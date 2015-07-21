using GalaSoft.MvvmLight;
using Attereco_Front.Model;
using System.Collections.Generic;

namespace Attereco_Front.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// MainWindow の コンストラクタ
        /// </summary>
        public MainViewModel()
        {
            TopVM = new TopViewModel();
        }

        #region TopViewModel TopVM

        /// <summary>
        /// TopViewModelのインスタンス
        /// </summary>
        public TopViewModel TopVM { get; set; }

        #endregion
    }
}