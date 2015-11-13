using Attereco_Register.Model.Common;
using Attereco_Register.Model;
using FelicaLib;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Attereco_Front.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        private Settings settings;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            felica = new Felica(FelicaSystemCode.Edy);
            settings = XMLFileManager.ReadXml<Settings>("Settings.xml");
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
                    _SubmitCommand = new RelayCommand( () => CreateUser() );
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
            string url = settings.Url + "?token=" + settings.Token + "&sid=" + Sid + "&idm=" + Idm; 
            using (var client = new WebClient())
            {
                try
                {
                    string response = client.UploadString(url, "POST", "");
                    Idm = "“o˜^Š®—¹‚µ‚Ü‚µ‚½";
                    Sid = "";
                    Task.Delay(1000);
                }
                catch (WebException e)
                {
                    Console.WriteLine(e.Source);
                    Idm = "“o˜^Ž¸”s‚µ‚Ü‚µ‚½";
                    Sid = "";
                    Task.Delay(1000);
                }
            }
        }
    }
}