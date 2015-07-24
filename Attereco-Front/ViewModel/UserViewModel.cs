using GalaSoft.MvvmLight;

namespace Attereco_Front.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        public UserViewModel()
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

        #region String Name

        /// <summary>
        /// 学籍番号
        /// </summary>
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        #endregion

        #region String Idm

        /// <summary>
        /// 学籍番号
        /// </summary>
        private string _Idm;

        public string Idm
        {
            get { return _Idm; }
            set
            {
                if (_Idm != value)
                {
                    _Idm = value;
                    RaisePropertyChanged("Idm");
                }
            }
        }
        #endregion

        #region String LoginTime

        /// <summary>
        /// 学籍番号
        /// </summary>
        private string _LoginTime;

        public string LoginTime
        {
            get { return _LoginTime; }
            set
            {
                if (_LoginTime != value)
                {
                    _LoginTime = value;
                    RaisePropertyChanged("LoginTime");
                }
            }
        }
        #endregion
    }
}