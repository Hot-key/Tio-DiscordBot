using System;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;
using TioCompiler.Discord.Data;
using TioTests;

namespace TioCompiler.Discord.Function
{
    public partial class Tio
    {
        public class Run : Routing.Function
        {
            public Run()
            {
                msg["--tio.run"] = (message, list) =>
                {
                    if (!Define.tioRunList.ContainsKey(message.Author))
                    {
                        Define.tioRunList.Add(message.Author, new User());
                        message.Channel.SendMessageAsync("코드를 입력하여 주십시오.");
                    }
                };
            }
        }
    }
}
