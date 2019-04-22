using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class Lang : Routing.Function
        {
            public Lang()
            {
                msg["--tio.lang"] = (message, list) =>
                {
                    Console.WriteLine("asd");
                };
            }
        }
    }
}
