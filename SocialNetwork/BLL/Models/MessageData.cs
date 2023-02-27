using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class MessageData
    {
        public int senderId { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
    }
}
