using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace TioCompiler.Tio
{
    public class Json
    {
        public string lang = default;
        public string code = default;
        public string input = default;
        public List<string> args = new List<string>();

        public override string ToString()
        {
            JObject json = new JObject();
            JArray inputJson = new JArray();

            json.RemoveAll();
            json.Add("input", inputJson);

            var tmpLangJson = new JObject();
            var tmpLangPayload = new JObject();

            tmpLangPayload.Add("lang", new JArray(lang));
            tmpLangJson.Add("Command", "V");
            tmpLangJson.Add("Payload", tmpLangPayload);
            inputJson.Add(tmpLangJson);

            var tmpCodeJson = new JObject();
            var tmpCodePayload = new JObject();

            tmpCodePayload.Add(".code.tio", code);
            tmpCodeJson.Add("Command", "F");
            tmpCodeJson.Add("Payload", tmpCodePayload);
            inputJson.Add(tmpCodeJson);

            var tmpInputJson = new JObject();
            var tmpInputPayload = new JObject();

            tmpInputPayload.Add(".input.tio", input);
            tmpInputJson.Add("Command", "F");
            tmpInputJson.Add("Payload", tmpInputPayload);
            inputJson.Add(tmpInputJson);

            var tmpArgsJson = new JObject();
            var tmpArgsPayload = new JObject();

            tmpArgsPayload.Add("args", new JArray(args.ToArray()));
            tmpArgsJson.Add("Command", "V");
            tmpArgsJson.Add("Payload", tmpArgsPayload);
            inputJson.Add(tmpArgsJson);

            var tmpEndJson = new JObject();

            tmpEndJson.Add("Command", "R");
            inputJson.Add(tmpEndJson);

            return json.ToString();
        }

        //{
        //    "Input":  [
        //    { "Command" : "V" , "Payload" : { "lang" : ["c-gcc"]} },
        //    { "Command" : "F" , "Payload" : { ".code.tio": "#include <stdio.h>\nint main(int argc, char **argv) { printf(\"Hello, Worldsdasdsad!\"); }" } },
        //    { "Command" : "F" , "Payload" : { ".input.tio" : "" } },
        //    { "Command" : "V" , "Payload" : { "args": [] } },
        //    { "Command" : "R" }
        //    ],
        //    "Output": "Hello, World!"
        //}

        //{
        //    "input": [
        //    { "Command": "V", "Payload": {"lang": [ "c-gcc"  ]} },
        //    { "Command": "F", "Payload": { ".code.tio": "#include <stdio.h>\\nint main(int argc, char **argv) { printf(\\\"Hello, World!%d\\\", argc); }"
        //        }
        //    },
        //    {
        //        "Command": "V",
        //        "Payload": {
        //            ".input.tio": ""
        //        }
        //    },
        //    {
        //        "Command": "V",
        //        "Payload": {
        //            "args": [
        //            "asdff",
        //            "asd"
        //                ]
        //        }
        //    },
        //    {
        //        "Command": "R"
        //    }
        //    ]
        //}
    }
}
