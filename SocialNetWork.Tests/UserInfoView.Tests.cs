using SocialNetwork.BLL.Models;
using SocialNetwork.PLL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetWork.Tests
{
    [TestFixture]
    internal class UserInfoViewTests
    {
        User user;
        [SetUp] 
        public void SetUp() 
        {
            user = new User(1, "test", "test", "12344321", "test@mail.ru", null, null, null, null, null);
        }

        [Test]
        public void UserInfoWisoutExeptionView()
        {
            UserInfoView userInfo = new UserInfoView();
            Assert.DoesNotThrow(() => userInfo.Show(user));
        }
    }
}
