using GalaSoft.MvvmLight;
using Attereco_Front.Model.Common;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Attereco_Front.Model;
using System;

namespace Attereco_Front.ViewModel
{
    public class TopViewModel : AtterecoViewModelBase
    {
        private IClient client;
        private Action<UserViewModel> togglePage;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TopViewModel(IClient client, Action<UserViewModel> togglePage)
        {
            this.client = client;
            this.togglePage = togglePage;
        }

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
                            UserVM.Name = user.Name;
                            UserVM.Sid = user.Sid;
                            togglePage(UserVM);
                        });
                }
                return _SubmitCommand;
            }
        }

        #endregion
    }
}