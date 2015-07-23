using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

using NUnit.Framework;
using Attereco_Front.ViewModel;
using Attereco_Front.Model.Common;

namespace Attereco_Front_Test.ViewModel
{
    /// <summary>
    /// FormViewModelTestのテスト
    /// </summary>
    [TestFixture]
    public class FormViewModelTest
    {
        FormViewModel FormVM;
        
        [SetUp]
        public void SetUp()
        {
            FormVM = new FormViewModel(new DummyClient());
        }

        [TearDown]
        public void TearDown()
        {
        }

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
                     sid = typeof(FormViewModel).GetProperty("Sid");
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
        	public class SubmitCommand
        	{
                PropertyInfo submitCommand;

                [SetUp]
                public void SetUp()
                {
                    submitCommand = typeof(FormViewModel).GetProperty("SubmitCommand");
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
