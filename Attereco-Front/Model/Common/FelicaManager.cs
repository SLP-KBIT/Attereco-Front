using Attereco_Front.ViewModel;
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
        private static Felica felica;
        private static IClient client;

        private const int pollingAsyncInterval = 1000;

        static FelicaManager()
        {
            felica = new Felica(FelicaSystemCode.Edy);
        }

        /// <summary>
        /// 非同期処理によるPolling
        /// </summary>
        public static async void PollingAsync(Action<UserViewModel> togglePage,  UserViewModel userVM)
        {
            client = new DummyClient();
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
                                    string idm = FelicaHelper.ToHexString(felica.GetIDm());
                                    if (idm != null)
                                    {
                                        User user = client.AttendIdm(idm);
                                        userVM.Sid = user.Sid;
                                        userVM.Name = user.Name;
                                        togglePage(userVM);
                                    }
                                }
                                catch (AccessViolationException e)
                                {
                                    Log.Write(e.ToString());
                                    Console.WriteLine(e.ToString());
                                }
                                catch (NullReferenceException e)
                                {
                                    Log.Write(e.ToString());
                                    Console.WriteLine(e.ToString());
                                }
                                catch (InvalidOperationException e)
                                {
                                    Log.Write(e.ToString());
                                    Console.WriteLine(e.ToString());
                                }

                            }
                        });
                    Timer timer = new Timer(timerDelegate, null, 0, pollingAsyncInterval);
                });
        }
    }
}
