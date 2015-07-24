using GalaSoft.MvvmLight;
using Attereco_Front.Model;
using Attereco_Front.Model.Common;
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
            FelicaManager.PollingAsync();
            TopVM = new TopViewModel();
            WelcomeVM = new WelcomeViewModel();
        }

        #region TopViewModel TopVM

        /// <summary>
        /// TopViewModelのインスタンス
        /// </summary>
        public TopViewModel TopVM { get; set; }

        #endregion

        #region WelcomeViewModel WelcomeVM

        /// <summary>
        /// WelcomeViewModelのインスタンス
        /// </summary>
        public WelcomeViewModel WelcomeVM { get; set; }

        #endregion
    }
}