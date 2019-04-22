using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public partial class Args
        {
            public class Reset : Routing.Function
            {
                public Reset()
                {
                    msg["--tio.args.reset"] = (message, list) =>
                    {
                        Console.WriteLine("asd");
                    };
                }
            }
        }
    }
}
