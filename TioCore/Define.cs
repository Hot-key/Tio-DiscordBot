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
        public static string DiscordBotToken = "NDkyMTM0MjI1MzExNTYzNzg2.XYyjrQ.QujKSGw26fdpWiM-bc1ccivNOgE";
        public static Dictionary<SocketUser,User> userList = new Dictionary<SocketUser, User>();
        public static Dictionary<SocketUser, User> tioRunList = new Dictionary<SocketUser, User>();
    }
}
