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
            Pages = new List<AtterecoViewModelBase>()
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
        public List<AtterecoViewModelBase> Pages { get; set; }

        #endregion


        private AtterecoViewModelBase _SelectedPage;

        /// <summary>
        /// 選ばれているpage
        /// </summary>
        public AtterecoViewModelBase SelectedPage
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