using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model
{
    /// <summary>
    /// Logを簡単に取ることを可能にするクラス
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// ログの書き込み
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="ex">例外，初期値:null</param>
        public static void WriteLog(String message, Exception ex = null)
        {
            try
            {
                DateTime time = DateTime.Now;
                String logFolder = System.AppDomain.CurrentDomain.BaseDirectory + "Log";
                System.IO.Directory.CreateDirectory(logFolder);
                String logFile = logFolder + time.ToString("yyyy_mm_dd") + ".log";
                String logString = time.ToString("[yyyy:MM:dd] HH:mm:ss") + "\t" + message;
                if (ex != null) { logString += ex.ToString(); }
                System.IO.StreamWriter sw = null;
                try
                {
                    sw = new System.IO.StreamWriter(logFile, true, System.Text.Encoding.GetEncoding("UTF-8"));
                    sw.WriteLine(logString);
                }
                catch { }
                finally
                {
                    if (sw != null) { sw.Close(); }
                }
            }
            catch { }
        }
    }
}
