using GalaSoft.MvvmLight;

namespace Attereco_Front.ViewModel
{
    public abstract class AtterecoViewModelBase : ViewModelBase
    {
        public AtterecoViewModelBase()
        {
            UserVM = new UserViewModel();
        }

        /// <summary>
        /// UserViewModelのインスタンス
        /// </summary>
        private UserViewModel _UserVM;

        public UserViewModel UserVM
        {
            get { return _UserVM; }
            set
            {
                if (_UserVM != value)
                {
                    _UserVM = value;
                    RaisePropertyChanged("UserVM");
                }
            }
        }

    }
}