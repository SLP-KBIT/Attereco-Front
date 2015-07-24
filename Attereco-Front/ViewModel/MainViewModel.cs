using GalaSoft.MvvmLight;
using Attereco_Front.Model;
using Attereco_Front.Model.Common;
using System.Collections.Generic;
using System.Linq;

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
            Pages = new List<ViewModelBase>()
            {
                new TopViewModel(new DummyClient(), TogglePage),
                new WelcomeViewModel()
            };
            SelectedPage = Pages.First();
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

        #region Pages

        /// <summary>
        /// Pageのリスト
        /// </summary>
        public List<ViewModelBase> Pages { get; set; }

        #endregion


        private ViewModelBase _SelectedPage;

        /// <summary>
        /// 選ばれているpage
        /// </summary>
        public ViewModelBase SelectedPage
        {
            get { return _SelectedPage; }
            set
            {
                if (_SelectedPage != value)
                {
                    _SelectedPage = value;
                    RaisePropertyChanged("SelectedPage");
                }
            }
        }

        /// <summary>
        /// ページを切り変えるメソッド
        /// </summary>
        public void TogglePage()
        {
            SelectedPage = Pages.Last();
        }
    }
}