using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public int id { get;}
        public int userId { get;}
        public int friendId { get;}
        public string friendName { get;}
        public string friendLastName { get;}

        public Friend(int id, string friendName, string friendLastName, int userId, int friendId)
        {
            this.id = id;
            this.friendName = friendName;
            this.friendLastName = friendLastName;
            this.userId= userId;
            this.friendId = friendId;
        }
    }
}
