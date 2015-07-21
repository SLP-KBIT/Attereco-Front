using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

using NUnit.Framework;
using Attereco_Front.ViewModel;

namespace Attereco_Front_Test
{
    /// <summary>
    /// MainViewModelのテスト
    /// </summary>
    [TestFixture]
    public class MainViewModelTest
    {
        MainViewModel MainVM;
        
        [SetUp]
        public void SetUp()
        {
            MainVM = new MainViewModel();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void TopViewModelを持っていること()
        {
            Assert.AreEqual(MainVM.TopVM.GetType().Name, (new TopViewModel()).GetType().Name);
        }
    }
}
