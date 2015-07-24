using FelicaLib;
using GalaSoft.MvvmLight;
using Attereco_Front.Model;
using System.Collections.Generic;
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
                    while (true)
                    {
                        bool isConnection = FelicaUtility.TryConnectionToCard(FelicaSystemCode.Edy);
                        if (isConnection)
                        {
                            string idm = FelicaHelper.ToHexString(FelicaUtility.GetIDm(FelicaSystemCode.Edy));
                            System.Console.WriteLine(idm);
                        }
                    }
                });
        }
    }
}