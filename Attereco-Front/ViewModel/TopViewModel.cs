using GalaSoft.MvvmLight;
using Attereco_Front.Model.Common;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Attereco_Front.Model;

namespace Attereco_Front.ViewModel
{
    public class TopViewModel : ViewModelBase
    {
        private IClient client;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TopViewModel(IClient client)
        {
            this.client = client;
            UserVM = new UserViewModel();
        }

        #region FormViewModel UserVM

        /// <summary>
        /// FormViewModelのインスタンス
        /// </summary>
        public UserViewModel UserVM { get; set; }

        #endregion

        #region ICommand SubmitCommand

        /// <summary>
        /// 学籍番号による出席処理
        /// </summary>

        private ICommand _SubmitCommand;

        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(
                        () =>
                        {
                            // 出席処理
                            User user = new User()
                            {
                                Sid = UserVM.Sid
                            };
                            user = client.PostUser(user);
                        });
                }
                return _SubmitCommand;
            }
        }

        #endregion
    }
}