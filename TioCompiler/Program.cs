using System;
using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Newtonsoft.Json;
using TioCompiler;
using TioCompiler.Routing;
using TioTests;

namespace TioCore
{
    public class Program
    {
        public static MessageSwitch msg;
        public static DiscordSocketClient client;
        public static Config config;

        public static void Main(string[] args)
        {
            string configPath = "config.json";
            config = File.Exists(configPath) ?
                JsonConvert.DeserializeObject<Config>(File.ReadAllText(configPath)) :
                new Config
                {
                    RunUrl = "https://tio.run/cgi-bin/run/api/no-cache/",
                    CheckUrl = "https://tryitonline.net/languages.json",
                    TestPath = Path.Combine(Utility.GetAncestor(AppContext.BaseDirectory, 3) ?? "", "HelloWorldTests"),
                    TrimWhitespacesFromResults = true,
                    DisplayDebugInfoOnError = true,
                    UseConsoleCodes = true,
                    BatchMode = true,
                    LocalRoot = "/srv"
                };

            FunctionScan.StartScan();
            new Program().MainAsync().GetAwaiter().GetResult();
        }
        public async Task MainAsync()
        {
            client = new DiscordSocketClient();
            msg = new MessageSwitch();
            client.Log += Log;
            string token = Define.DiscordBotToken;
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();
            client.MessageReceived += msg.MessageReceived;
            client.Ready += Client_Ready;
            client.GuildAvailable += Client_GuildAvailable;
            await Task.Delay(-1); // 프로그램 종료시까지 태스크 유지  
        }

        private Task Client_GuildAvailable(SocketGuild arg)
        {
            return Task.CompletedTask;
        }

        private Task Client_Ready() { return Task.CompletedTask; }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
