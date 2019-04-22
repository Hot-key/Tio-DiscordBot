using System;
using TioCompiler.Discord.Data;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class Create : Routing.Function
        {
            public Create()
            {
                msg["--tio.create"] = (message, list) =>
                {
                    if (Define.userList.ContainsKey(message.Author))
                    {

                    }
                    else
                    {
                        Define.userList.Add(message.Author,new User());
                    }
                    Console.WriteLine("asd");
                };
            }
        }
    }
}
