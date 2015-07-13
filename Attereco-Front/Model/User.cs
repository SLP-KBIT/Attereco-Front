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
        public User(string name)
        {
            this.Name = name;
            this.LoginTime = DateTime.Now;
        }

        public String Name { get; set; }

        public DateTime LoginTime { get; set; }

        /// <summary>
        /// データをサーバにpostする
        /// </summary>
        /// <param name="json">user情報</param>
        public void postData(string json)
        {
            //TODO
        }

        private string ToJson()
        {
            dynamic json = new DynamicJson();
            json["User"] = this.Name;
            json["LoginTime"] = this.LoginTime;
            return json.toString();
        }
    }
}
