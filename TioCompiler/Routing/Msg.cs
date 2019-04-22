using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace TioCompiler.Routing
{
    public class Msg
    {
        public Action<SocketMessage, string> this[dynamic i]
        {
            set
            {
                Console.WriteLine(i);
                this.Add(i, value);
            }
        }

        public static Dictionary<dynamic, Action<SocketMessage, string>> BufferDictionary = new Dictionary<dynamic, Action<SocketMessage, string>>();

        public void Add(dynamic type, Action<SocketMessage , string> action)
        {
            BufferDictionary.Add(type, action);
        }
    }
}
