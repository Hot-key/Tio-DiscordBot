using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using TioCompiler.Discord.Data;

namespace TioCompiler
{
    class Define
    {
        public static string DiscordBotToken = "";
        public static Dictionary<SocketUser,User> userList = new Dictionary<SocketUser, User>();
        public static Dictionary<SocketUser, User> tioRunList = new Dictionary<SocketUser, User>();
    }
}
