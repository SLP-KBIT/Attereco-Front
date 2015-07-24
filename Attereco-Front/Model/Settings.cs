using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attereco_Front.Model
{
    /// <summary>
    /// HTTPリクエストのための設定
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// HTTPリクエストのベースとなるURL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// APIアクセス用のシークレットキー
        /// </summary>
        public string Token { get; set; }
    }
}
