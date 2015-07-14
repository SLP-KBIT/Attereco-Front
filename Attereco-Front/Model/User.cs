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

        /// <summary>
        /// Userコンストラクタ
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="dynamic">new DynamicJson()</param>
        public User(string name, dynamic dynamic)
        {
            this.Name = name;
            this.LoginTime = DateTime.Now;
            this.SetJson(this, dynamic);
        }

        public String Name { get; private set; }

        public DateTime LoginTime { get; private set; }

        public String Json { get; private set; }

        private void SetJson(User user, dynamic dynamic)
        {
            dynamic["User"] = this.Name;
            dynamic["LoginTime"] = this.LoginTime;
            this.Json = dynamic.toString();
        }
    }
}
