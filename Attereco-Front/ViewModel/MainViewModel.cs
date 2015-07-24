using FelicaLib;
using GalaSoft.MvvmLight;
using Attereco_Front.Model;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Attereco_Front.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// MainWindow の コンストラクタ
        /// </summary>
        public MainViewModel()
        {
            PollingAsync();
            TopVM = new TopViewModel();
        }

        #region TopViewModel TopVM

        /// <summary>
        /// TopViewModelのインスタンス
        /// </summary>
        public TopViewModel TopVM { get; set; }

        #endregion

        public async void PollingAsync()
        {
            await Task.Run(
                () =>
                {
                    TimerCallback timerDelegate = new TimerCallback(
                        (_) =>
                        {
                            bool isConnection = FelicaUtility.TryConnectionToCard(FelicaSystemCode.Edy);
                        	if (isConnection)
                        	{
                                try
                                {
                                    string idm = FelicaHelper.ToHexString(FelicaUtility.GetIDm(FelicaSystemCode.Edy));
                                    System.Console.WriteLine(idm);
                                }
                                catch (System.Exception)
                                {
                                    throw;
                                }
                        	}
                        });
                    Timer timer = new Timer(timerDelegate, null, 0, 1000);
                });
        }
    }
}