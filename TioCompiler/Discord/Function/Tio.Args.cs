using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public partial class Args : Routing.Function
        {
            public Args()
            {
                msg["--tio.args"] = (message, list) =>
                {
                    Console.WriteLine("asd");
                };
            }
        }
    }
}
