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
        
        [SetUp]
        public void SetUp()
        {
            MainViewModel hoge = new MainViewModel();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void サンプル()
        {
            Assert.AreEqual(1 + 1, 2);
        }
    }
}
