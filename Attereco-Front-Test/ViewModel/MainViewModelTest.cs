using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

using NUnit.Framework;
using Attereco_Front.ViewModel;
using System.Reflection;

namespace Attereco_Front_Test
{
    /// <summary>
    /// MainViewModelのテスト
    /// </summary>
    [TestFixture]
    public class MainViewModelTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [TestFixture]
        public class プロパティのテスト
        {
            [TestFixture]
            public class TopVM
            {
                PropertyInfo topVM;

                [SetUp]
                public void SetUp()
                {
                    topVM = typeof(MainViewModel).GetProperty("TopVM");
                }

                [Test]
                public void 存在すること()
                {
                    Assert.AreEqual(topVM.Name, "TopVM");
                }

                [Test]
                public void 読み込めること()
                {
                    Assert.IsTrue(topVM.CanRead);
                }

                [Test]
                public void 書き込めること()
                {
                    Assert.IsTrue(topVM.CanWrite);
                }
            }

            [TestFixture]
            public class WelcomeVM
            {
                PropertyInfo welcomeVM;

                [SetUp]
                public void SetUp()
                {
                    welcomeVM = typeof(MainViewModel).GetProperty("WelcomeVM");
                }

                [Test]
                public void 存在すること()
                {
                    Assert.AreEqual(welcomeVM.Name, "WelcomeVM");
                }

                [Test]
                public void 読み込めること()
                {
                    Assert.IsTrue(welcomeVM.CanRead);
                }

                [Test]
                public void 書き込めること()
                {
                    Assert.IsTrue(welcomeVM.CanWrite);
                }
            }
        }
    }
}
