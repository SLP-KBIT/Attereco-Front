using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

using NUnit.Framework;
using Attereco_Front.ViewModel;
using System.Reflection;

namespace Attereco_Front_Test.ViewModel
{
    [TestFixture]
    public class UserViewModelTest
    {
        [TestFixture]
        public class プロパティのテスト
        {
            [TestFixture]
            public class Sid
            {
                PropertyInfo sid;

                [SetUp]
                public void SetUp()
                {
                    sid = typeof(UserViewModel).GetProperty("Sid");
                }

                [Test]
                public void 存在すること()
                {
                    Assert.AreEqual(sid.Name, "Sid");
                }

                [Test]
                public void 読み込めること()
                {
                    Assert.IsTrue(sid.CanRead);
                }

                [Test]
                public void 書き込めること()
                {
                    Assert.IsTrue(sid.CanWrite);
                }
            }

            [TestFixture]
            public class Name
            {
                PropertyInfo name;

                [SetUp]
                public void SetUp()
                {
                    name = typeof(UserViewModel).GetProperty("Name");
                }

                [Test]
                public void 存在すること()
                {
                    Assert.AreEqual(name.Name, "Name");
                }

                [Test]
                public void 読み込めること()
                {
                    Assert.IsTrue(name.CanRead);
                }

                [Test]
                public void 書き込めること()
                {
                    Assert.IsTrue(name.CanWrite);
                }
            }

            [TestFixture]
            public class Idm
            {
                PropertyInfo idm;

                [SetUp]
                public void SetUp()
                {
                    idm = typeof(UserViewModel).GetProperty("Idm");
                }

                [Test]
                public void 存在すること()
                {
                    Assert.AreEqual(idm.Name, "Idm");
                }

                [Test]
                public void 読み込めること()
                {
                    Assert.IsTrue(idm.CanRead);
                }

                [Test]
                public void 書き込めること()
                {
                    Assert.IsTrue(idm.CanWrite);
                }
            }

            [TestFixture]
            public class LoginTime
            {
                PropertyInfo loginTime;

                [SetUp]
                public void SetUp()
                {
                    loginTime = typeof(UserViewModel).GetProperty("LoginTime");
                }

                [Test]
                public void 存在すること()
                {
                    Assert.AreEqual(loginTime.Name, "LoginTime");
                }

                [Test]
                public void 読み込めること()
                {
                    Assert.IsTrue(loginTime.CanRead);
                }

                [Test]
                public void 書き込めること()
                {
                    Assert.IsTrue(loginTime.CanWrite);
                }
            }
        }
    }
}
