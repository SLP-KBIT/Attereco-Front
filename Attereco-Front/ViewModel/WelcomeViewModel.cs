using GalaSoft.MvvmLight;

namespace Attereco_Front.ViewModel
{
    public class WelcomeViewModel : ViewModelBase
    {
        public WelcomeViewModel()
        {
            UserVM = new UserViewModel();
        }

        /// <summary>
        /// UserViewModelのインスタンス
        /// </summary>
        public UserViewModel UserVM { get; set; }
    }
}