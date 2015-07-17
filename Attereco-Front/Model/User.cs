using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codeplex.Data;

namespace Attereco_Front.Model
{
    public class User
    {
        #region コンストラクタ
        /// <summary>
        /// Userコンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="sid">学籍番号</param>
        public User(string name, string sid)
        {
            this.Name = name;
            this.Sid = sid;
            this.LoginTime = DateTime.Now;
            this.Json = this.SetJson();
        }

        /// <summary>
        /// Userコンストラクタ
        /// </summary>
        /// <param name="dynamic">Json</param>
        public User(dynamic dynamic)
        {
            this.Name = dynamic["User"];
            this.Sid = dynamic["Sid"];
            this.LoginTime = dynamic["LoginTime"];
            this.Json = dynamic.ToString();
        }
        #endregion

        #region フィールド
        /// <summary>
        /// Idm
        /// </summary>
        private string Idm { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 学籍番号
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// ログイン時間
        /// </summary>
        public DateTime LoginTime { get; set; }
        
        /// <summary>
        /// 所属プロジェクト
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// 学年
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Json
        /// </summary>
        public string Json { get; set; }
        #endregion

        /// <summary>
        /// SetJson
        /// </summary>
        /// <returns>json</returns>
        private string SetJson()
        {
            dynamic json = new DynamicJson();
            json["Name"] = this.Name;
            json["Sid"] = this.Sid;
            json["LoginTime"] = this.LoginTime;
            return json.ToString();
        }
    }
}
