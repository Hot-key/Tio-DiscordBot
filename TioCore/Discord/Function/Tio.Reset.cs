using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class Reset : Routing.Function
        {
            public Reset()
            {
                msg["--tio.reset"] = (message, list) =>
                {
                    Console.WriteLine("asd");
                };
            }
        }
    }
}
