using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codeplex.Data;

using NUnit.Framework;
using Attereco_Front.Model;

namespace Attereco_Front_Test.Model
{
    /// <summary>
    /// UserModelのテスト
    /// </summary>
    [TestFixture]
    public class User
    {
        private string name = "tsujiken";
        private string sid = "s12t241";
        private Attereco_Front.Model.User user;
        private dynamic json;

        [SetUp]
        public void SetUp()
        {
            this.user = new Attereco_Front.Model.User(name, sid);
            this.json = new DynamicJson();
            this.json["Name"] = this.name;
            this.json["Sid"] = this.sid;
            this.json["LoginTime"] = user.LoginTime;
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void カラムテスト()
        {
            Assert.AreEqual(user.Name, name);
            Assert.AreEqual(user.Sid, sid);
        }

        [Test]
        public void Json生成テスト()
        {
            Assert.AreEqual(user.Json, json.ToString());
        }
    }
}
