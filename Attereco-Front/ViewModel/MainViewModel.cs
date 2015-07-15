using GalaSoft.MvvmLight;
using Attereco_Front.Model;
using System.Collections.Generic;
using Attereco_Front.ViewModel.Dummy;

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
        }

        public DummyUserFormViewModel DummyUserFormViewModel { get; private set; }

    }
}