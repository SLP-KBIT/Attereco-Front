using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

using NUnit.Framework;
using Attereco_Front.ViewModel;

namespace Attereco_Front_Test.ViewModel
{
    /// <summary>
    /// TopViewModelTestのテスト
    /// </summary>
    [TestFixture]
    public class TopViewModelTest
    {
        TopViewModel TopVM;
        
        [SetUp]
        public void SetUp()
        {
            TopVM = new TopViewModel();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void FormViewModelを持っていること()
        {
            Assert.AreEqual(TopVM.FormVM.GetType().Name, (new FormViewModel()).GetType().Name);
        }
    }
}
