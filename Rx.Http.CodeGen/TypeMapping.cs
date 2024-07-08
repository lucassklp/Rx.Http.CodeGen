using CaseConverter;
using Microsoft.OpenApi.Models;

namespace Rx.Http.CodeGen
{
    static class TypeMapping
    {
        private static Dictionary<string, string> TypesMap = new()
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
            { "file", "FileStream" }
        };

        private static List<string> UnderlyingMap = new()
        {
            "Version"
        };

        public static string GetAssociatedType(OpenApiSchema element)
        {
            if(element.Type == "number")
            {
                return string.IsNullOrEmpty(element.Format) ? "double" : element.Format;
            }

            if(!string.IsNullOrEmpty(element.Type) && TypesMap.ContainsKey(element.Type))
            {
                var type = TypesMap[element.Type];
                if (type == "object")
                {
                    return element?.Reference?.Id?.ToPascalCase() ?? "object";
                }
                return type;
            }

            if(string.IsNullOrWhiteSpace(element?.Type) && !string.IsNullOrWhiteSpace(element?.Reference?.Id))
            {
                return element.Reference.Id.ToPascalCase();
            }

            return "object";
        }

        public static bool HasUnderlyingType(string type)
        {
            return UnderlyingMap.Contains(type);
        }

    }
}
