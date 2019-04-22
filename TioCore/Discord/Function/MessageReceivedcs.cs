using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TioCompiler.Tio;

namespace TioCompiler.Discord.Function
{
    class MessageReceivedcs : Routing.Function
    {
        public MessageReceivedcs()
        {
            msg["MessageReceived"] = (message, s) =>
            {
                if (Define.tioRunList.ContainsKey(message.Author))
                {
                    Define.tioRunList.Remove(message.Author);
                    var data = s.Replace("`", "");
                    var dataArr = data.Split(new string[]{"\n"}, StringSplitOptions.None);
                    message.Channel.SendMessageAsync(Runner.Run(dataArr[0], data.Remove(0, dataArr[0].Length + 1)));
                }
            };
        }
    }
}
