using NUnit.Framework;
using UnitTestApp1.Model;
using HelloAndroid.ViewModel;

namespace UnitTestApp1
{
    [TestFixture]
    public class TestsSample
    {
        [Test]
        public void MainViewModel_TestRefresh_ShouldSucceed()
        {
            var service = new TestYoutubeService();
            var vm = new MainViewModel(service);

            vm.RefreshCommand.Execute(null);

            Assert.AreEqual(TestYoutubeService.ResultPassed, vm.Result);
        }

        [Test]
        public void MainViewModel_TestRefreshFail_ShouldCopyExceptionMessageInResult()
        {
            var service = new TestYoutubeService(true);
            var vm = new MainViewModel(service);

            vm.RefreshCommand.Execute(null);

            Assert.AreEqual(TestYoutubeService.ExceptionMessage, vm.Result);
        }
    }
}