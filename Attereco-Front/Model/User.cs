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
        /// <summary>
        /// Userコンストラクタ
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="dynamic">Postで獲得したJson</param>
        public User(dynamic dynamic)
        {
            this.Name = dynamic["User"];
            this.LoginTime = dynamic["LoginTime"];
            this.Project = dynamic["Project"];
            this.Lank = dynamic["Lank"];
            this.Json = dynamic.ToString();
        }

        /// <summary>
        /// 名前
        /// </summary>
        public String Name { get; private set; }

        /// <summary>
        /// ログイン時間
        /// </summary>
        public DateTime LoginTime { get; private set; }
        
        /// <summary>
        /// 所属プロジェクト
        /// </summary>
        public String Project { get; private set; }

        /// <summary>
        /// 学年
        /// </summary>
        public int Lank { get; private set; }

        public String Json { get; private set; }
    }
}
