using GalaSoft.MvvmLight;
using Attereco_Front.Model;
using System.Collections.Generic;
using Attereco_Front.ViewModel.Dummy;
using Attereco_Front.ViewModel.StaticContent;

namespace Attereco_Front.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// MainWindow の コンストラクタ
        /// </summary>
        public MainViewModel()
        {
            this.DummyUserFormViewModel = new DummyUserFormViewModel();
            this.StaticContentViewModel = new StaticContentViewModel();
        }

        public DummyUserFormViewModel DummyUserFormViewModel { get; private set; }
        public StaticContentViewModel StaticContentViewModel { get; private set; }

    }
}