using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace TioCompiler.Discord.Function
{
    public partial class Tio : Routing.Function
    {
        public Tio()
        {
            msg["--tio"] = async (message, list) =>
            {
                Console.WriteLine("asd2");
                await Task.Delay(2000);
                Console.WriteLine("asd");
            };
        }
    }
}
