using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

using NUnit.Framework;
using Attereco_Front.ViewModel;
using Attereco_Front.Model.Common;
using System.Reflection;

namespace Attereco_Front_Test.ViewModel
{
    /// <summary>
    /// TopViewModelTestのテスト
    /// </summary>
    [TestFixture]
    public class TopViewModelTest
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
            public class UserVM
            {
                PropertyInfo userVM;

                [SetUp]
                public void SetUp()
                {
                    userVM = typeof(TopViewModel).GetProperty("UserVM");
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

            [TestFixture]
            public class SubmitCommand
            {
                PropertyInfo submitCommand;

                [SetUp]
                public void SetUp()
                {
                    submitCommand = typeof(TopViewModel).GetProperty("SubmitCommand");
                }

                [Test]
                public void 存在すること()
                {
                    Assert.AreEqual(submitCommand.Name, "SubmitCommand");
                }

                [Test]
                public void 読み込めること()
                {
                    Assert.IsTrue(submitCommand.CanRead);
                }

                [Test]
                public void 書き込めないこと()
                {
                    Assert.IsFalse(submitCommand.CanWrite);
                }
            }
        }
    }
}
