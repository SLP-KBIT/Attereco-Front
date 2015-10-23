using FelicaLib;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Attereco_Register.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            felica = new Felica(FelicaSystemCode.Edy);
            PollingAsync();
        }

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

        public static Felica felica;
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
                            CreateUser();
                        });
                }
                return _SubmitCommand;
            }
        }

        public async void PollingAsync()
        {
            await Task.Run(
                () =>
                {
                    TimerCallback timerDelegate = new TimerCallback(
                        (_) =>
                        {
                            if (felica.TryConnectionToCard())
                            {
                                try
                                {
                                    Idm = FelicaHelper.ToHexString(felica.GetIDm());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.ToString());
                                }

                            }
                        });
                    Timer timer = new Timer(timerDelegate, null, 0, 1000);
                });
        }

        public void CreateUser()
        {
            if (Sid == null || Idm == null) { return; }
            string url = "http://chausson0.eng.kagawa-u.ac.jp/attereco/api/v1/users/create"
                         + "?token=0f45eacc30076aed8efb5a2eff2536a94d6d779c8df849bc3a1d32da420c5bbd075455551a124e7e1bc355ba72825669dc2229cfd1d3f4ea51bc22353ffdd391"
                         + "&sid=" + Sid
                         + "&idm=" + Idm;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Headers[HttpRequestHeader.ContentEncoding] = "utf-8";
                try
                {
                    string response = client.UploadString(url, "POST", "");
                    Idm = "“o˜^Š®—¹‚µ‚Ü‚µ‚½";
                    Sid = "";
                }
                catch (WebException e)
                {
                    Console.WriteLine(e.Source);
                    Idm = "“o˜^Ž¸”s‚µ‚Ü‚µ‚½";
                    Sid = "";
                }
            }
        }
    }
}