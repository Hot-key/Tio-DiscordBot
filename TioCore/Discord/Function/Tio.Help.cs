using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class Help : Routing.Function
        {
            public Help()
            {
                msg["--tio.help"] = (message, list) =>
                {
                    Console.WriteLine("asd");
                };
            }
        }

    }
}
