using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Attereco_Front.ViewModel
{
    public class FormViewModel : ViewModelBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormViewModel()
        {
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
        /// 出席処理のコマンド
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
                        });
                }
                return _SubmitCommand;
            }
        }

        #endregion
    }
}