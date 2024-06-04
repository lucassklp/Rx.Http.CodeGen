using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Http.CodeGen
{
    static class Consts
    {
        public static Dictionary<string, string> TypesMap = new()
        {
            { "int16", "short" },
            { "int32", "int" },
            { "int64", "long" },
            { "boolean", "bool" },
            { "date-time", "DateTime" },
            { "string", "string" },
            { "integer", "int" },
            { "array", "List<object>" },
            { "object", "object" },
        };
    }
}
