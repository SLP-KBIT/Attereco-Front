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
        private Action togglePage;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TopViewModel(IClient client, Action togglePage)
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
                            AttendSid(client);
                            togglePage();
                        });
                }
                return _SubmitCommand;
            }
        }

        #endregion
    }
}