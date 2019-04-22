using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public partial class Args
        {
            public class Add : Routing.Function
            {
                public Add()
                {
                    msg["--tio.args.add"] = (message, s) =>
                    {
                        Console.WriteLine("asd");
                    };
                }
            }
        }
    }
}
