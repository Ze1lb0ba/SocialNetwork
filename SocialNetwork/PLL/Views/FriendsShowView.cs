using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    internal class FriendsShowView
    {
        public void Show(IEnumerable<Friend> friendses, User user)
        {
            Console.WriteLine("Меню взаимодействия со списком друзей:");
            Console.WriteLine("Для просмотра списка друзей нажмите: 1.");
            Console.WriteLine("Для добавления человека в список друзей нажмите: 2.");
            Console.WriteLine("Для удаления друга нажмите: 3.");

            switch(Console.ReadLine())
            {
                case "1":
                    {
                        var friends = new List<Friend>();
                        Program.FriendListView.Show(friends);
                        break;
                    }
                case "2":
                    {
                        Program.userFriendAddView.Show(user);
                        break;
                    }
                case "3":
                    {

                        break;
                    }
            }
        }

    }
}
