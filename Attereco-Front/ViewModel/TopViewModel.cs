using GalaSoft.MvvmLight;
using Attereco_Front.Model.Common;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Attereco_Front.Model;
using System;
using System.Threading.Tasks;

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
                        async () =>
                        {
                            AttendSid(client);
                            togglePage();
                            await Task.Delay(1000);
                            UserVM.Sid = "";
                            UserVM.Name = "";
                            togglePage();
                        });
                }
                return _SubmitCommand;
            }
        }

        #endregion
    }
}