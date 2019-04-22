using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TioCompiler.Routing
{
    class FunctionScan
    {
        public static void StartScan()
        {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in asm.GetTypes())
                {
                    if (type.BaseType != null)
                    {
                        if (type.BaseType.Name == "Function")
                        {
                            dynamic instance = Activator.CreateInstance(type);
                        }
                    }
                }
            }
        }
    }
}
