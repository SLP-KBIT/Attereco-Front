using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Attereco_Front.Model.Common;

namespace Attereco_Front.ViewModel
{
    public class FormViewModel : ViewModelBase
    {
        private IClient client;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormViewModel(IClient client)
        {
            this.client = client;
        }

        #region String Sid

        /// <summary>
        /// 学籍番号
        /// </summary>

        private string _Sid;

        public string Sid
        {
            get { return _Sid; }
            set
            {
                if (_Sid != value)
                {
                    _Sid = value;
                    RaisePropertyChanged("Sid");
                }
            }
        }

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
                            client.PostUser(Sid);
                        });
                }
                return _SubmitCommand;
            }
        }

        #endregion
    }
}