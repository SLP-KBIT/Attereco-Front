using FelicaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Attereco_Front.Model.Common
{
    /// <summary>
    /// FelicaLibのラッパー
    /// </summary>
    public static class FelicaManager
    {
        /// <summary>
        /// 非同期処理によるPolling
        /// </summary>
        public static async void PollingAsync()
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
