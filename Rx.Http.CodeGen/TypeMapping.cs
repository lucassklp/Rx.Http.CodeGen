using CaseConverter;
using Microsoft.OpenApi.Models;

namespace Rx.Http.CodeGen
{
    static class TypeMapping
    {
        private static Dictionary<JsonSchemaType, string> TypesMap = new()
        {
            { JsonSchemaType.Null, "object" },
            { JsonSchemaType.Boolean, "bool" },
            { JsonSchemaType.Integer, "int" },
            { JsonSchemaType.Number, "double" },
            { JsonSchemaType.String, "string" },
            { JsonSchemaType.Object, "object" },
            { JsonSchemaType.Array, "List<object>" }
        };

        private static List<string> UnderlyingMap = new()
        {
            "Version"
        };

        public static string GetAssociatedType(OpenApiSchema element)
        {
            if(element.Type == JsonSchemaType.Number)
            {
                return string.IsNullOrEmpty(element.Format) ? "double" : element.Format;
            }

            if(element.Type is JsonSchemaType jsonType && TypesMap.ContainsKey(jsonType))
            {
                var type = TypesMap[jsonType];
                if (type == "object")
                {
                    return element?.Reference?.Id?.ToPascalCase() ?? "object";
                }
                return type;
            }

            if(element?.Type is null && !string.IsNullOrWhiteSpace(element?.Reference?.Id))
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
