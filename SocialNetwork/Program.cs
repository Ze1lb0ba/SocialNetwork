using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Service;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;

namespace SocialNetwork
{
    class Program
    {
        static MessageService messageService;
        static UserService userService;
        static FriendService friendService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncommingMessageView userIncomingMessageView;
        public static UserOutcommingMessageView userOutcomingMessageView;
        public static FriendsShowView friendsShowView;
        public static FriendListView FriendListView;
        public static UserFriendAddView userFriendAddView;

        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();
            friendService= new FriendService();

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncommingMessageView();
            userOutcomingMessageView = new UserOutcommingMessageView();
            friendsShowView = new FriendsShowView();
            FriendListView = new FriendListView();
            userFriendAddView = new UserFriendAddView(friendService, userService);

            while (true)
            {
                mainView.Show();
            }
        }
    }
}
