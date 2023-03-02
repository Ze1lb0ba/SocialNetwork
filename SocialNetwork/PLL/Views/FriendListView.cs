using SocialNetwork.BLL.Models;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendListView
    {
        public void Show(IEnumerable<Friend> friendList)
        {
            Console.WriteLine("Ваш список друзей:");

            if (friendList.Count() == 0)
            {
               SuccessMessage.Show("У вас нет добавленных друзей");
                return;
            }

            int i = 1;

            friendList.ToList().ForEach(friend =>
            {
                Console.WriteLine("{0}. Имя: {1}, Фамилия:{2}.", i, friend.friendName, friend.friendLastName);
                i++;
            });
        }
    }
}
