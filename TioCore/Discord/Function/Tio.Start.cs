using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class Start : Routing.Function
        {
            public Start()
            {
                msg["--tio.start"] = (message, list) =>
                {
                    Console.WriteLine("asd");
                };
            }
        }
    }
}
