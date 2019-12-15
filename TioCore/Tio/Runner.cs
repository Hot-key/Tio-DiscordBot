using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TioCore;
using TioTests;

namespace TioCompiler.Tio
{
    public static class Runner
    {
        public static string Run(string lang, string code)
        {
            return Run(lang, code, "", new List<string>());
        }


        public static string Run(string lang, string code, string input, params string[] args)
        {
            return Run(lang, code, input, args.ToList());
        }

        public static string Run(string lang, string code, string input, List<string> args)
        {
            Tio.Json tioJson = new Json()
            {
                lang = lang,
                code = code,
                input = input,
                args = args
            };

            TestDescription test = JsonConvert.DeserializeObject<TestDescription>(tioJson.ToString());

            RunResult result;
            int retried = 0;


            while (true)
            {
                byte[] compressed = TestRunner.CompressAndDump(test.GetInputBytes(), Program.config.DebugDumpFile, "Remote");

                result = TestRunner.ExecuteRemote(compressed, Program.config.RunUrl, Program.config.DebugDumpFile);

                if (!result.HttpFailure || retried++ >= Program.config.Retries)
                {
                    break;
                }
            }

            DisplayTestResultParams p = new DisplayTestResultParams
            {
                ExpectedOutput = test.Output,
                Output = result?.Output?[0],
                Debug = result?.Debug?[0],
                Warnings = result.Warnings
            };

            return $"Output : \r\n" +
                   $"```{p.Output} ```\r\n" +
                   $"Debug : \r\n" +
                   $"```{p.Debug}```";
        }
    }
}
