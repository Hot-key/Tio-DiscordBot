using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class Code : Routing.Function
        {
            public Code()
            {
                msg["--tio.code"] = (message, list) =>
                {
                    Console.WriteLine("asd");
                };
            }
        }
    }
}
