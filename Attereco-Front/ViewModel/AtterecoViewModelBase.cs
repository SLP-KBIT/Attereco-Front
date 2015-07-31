using Attereco_Front.Model;
using Attereco_Front.Model.Common;
using GalaSoft.MvvmLight;
using System;

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

        public void AttendSid(IClient client)
        {
            User user = new User()
            {
                Sid = UserVM.Sid
            };
            user = client.PostUser(user);
            UserVM.Name = user.Name;
            UserVM.Sid = user.Sid;
        }
    }
}