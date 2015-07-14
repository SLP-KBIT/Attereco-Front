using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model
{
    public static class Api
    {
        private const String basedUrl = "";

        public static Boolean PostData()
        {
            try
            {
                //TODO
            }
            catch (System.Runtime.Remoting.RemotingTimeoutException ex)
            {
                Log.WriteLog("TimeOutException", ex);
                return false;
            }
            catch (NullReferenceException ex)
            {
                Log.WriteLog("NullReferenceException", ex);
                return false;
            }
            return true;
        }

        public static String GetData(String url)
        {
            try
            {
                //TODO
            }
            catch (System.Runtime.Remoting.RemotingTimeoutException ex)
            {
                Log.WriteLog("TimeOutException", ex);
                return null;
            }
            catch (NullReferenceException ex)
            {
                Log.WriteLog("NullReferenceException", ex);
                return null;
            }
            return "";
        }
    }
}
