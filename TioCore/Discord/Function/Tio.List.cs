using System;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class List : Routing.Function
        {
            public List()
            {
                msg["--tio.list"] = (message, list) =>
                {
                    Console.WriteLine("asd");
                };
            }
        }
    }
}
