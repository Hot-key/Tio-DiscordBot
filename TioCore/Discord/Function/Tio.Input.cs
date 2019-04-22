using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class Input : Routing.Function
        {
            public Input()
            {
                msg["--tio.input"] = (message, list) =>
                {
                    Console.WriteLine("asd");
                };
            }
        }
    }
}
