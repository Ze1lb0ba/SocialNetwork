using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Service;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendAddView
    {
        UserService userService;
        FriendService friendService;

        public UserFriendAddView(FriendService friendService, UserService userService)
        {
            this.friendService = friendService;
            this.userService = userService;
        }

        public void Show(User user)
        {
            var addFriendData = new FriendAddData();

            Console.WriteLine("Введите электронный адресс человека которого бы хотели добавить в друзья:");
            addFriendData.FriendEmail = Console.ReadLine();

            addFriendData.UserId = user.Id;
            

            try
            {
                friendService.AddFriend(addFriendData);
                SuccessMessage.Show("Друг успешно добавлен");
                user = userService.FindById(user.Id);
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

            catch(Exception ex)
            {
                AlertMessage.Show(ex.Message);
            }
        }
    }
}
