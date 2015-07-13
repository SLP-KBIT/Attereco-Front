using GalaSoft.MvvmLight;
using Attereco_Front.Model;
using Attereco_Front.ViewModel.MenuList;
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
            Contents = new List<ViewModelBase>() {
                new MenuListViewModel()
            };
        }

        public List<ViewModelBase> Contents { get; private set; }
    }
}