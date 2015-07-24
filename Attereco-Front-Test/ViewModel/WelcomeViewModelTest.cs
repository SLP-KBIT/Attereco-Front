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
    public class WelcomeViewModelTest
    {
        [TestFixture]
        public class プロパティのテスト
        {
            [TestFixture]
            public class UserVM
            {
                PropertyInfo userVM;

                [SetUp]
                public void SetUp()
                {
                    userVM = typeof(WelcomeViewModel).GetProperty("UserVM");
                }

                [Test]
                public void 存在すること()
                {
                    Assert.AreEqual(userVM.Name, "UserVM");
                }

                [Test]
                public void 読み込めること()
                {
                    Assert.IsTrue(userVM.CanRead);
                }

                [Test]
                public void 書き込めること()
                {
                    Assert.IsTrue(userVM.CanWrite);
                }
            }
        }
    }
}
