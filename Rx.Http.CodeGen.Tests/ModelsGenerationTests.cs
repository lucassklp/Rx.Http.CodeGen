using Rx.Http.CodeGen;

namespace Rx.Http.CodeGen.Tests;

public class ModelsGenerationTests
{
    [Fact]
    public void CreateAccessModel()
    {
        var openApiDefinition = """"
            {
                "openapi": "3.0.2",
                "info": {
                    "title": "Keycloak Admin REST API",
                    "description": "This is a REST API reference for the Keycloak Admin REST API.",
                    "contact": {
                        "url": "https://www.keycloak.org/documentation"
                    },
                    "version": "1.0"
                },
                "servers": [
                    {
                        "url": "https://keycloak.example.com/admin/realms"
                    }
                ],
                "components": {
                    "securitySchemes": {
                        "access_token": {
                            "type": "http",
                            "scheme": "bearer"
                        }
                    },
                    "schemas": {
                        "Access": {
                            "type": "object",
                            "properties": {
                                "roles": {
                                    "type": "array",
                                    "items": {
                                        "type": "string"
                                    },
                                    "uniqueItems": true
                                },
                                "verify_caller": {
                                    "type": "boolean"
                                }
                            }
                        }
                    }
                }
            }
            """";

        var consumerConfig = new ConsumerGenerationConfig()
        {
            Path = "",
            OpenApiDefinition = openApiDefinition,
            ConsumerName = "ConsumerTest",
            Namespace = "Consumer.Test"
        };


        var consumerGenerator = new ConsumerGenerator(consumerConfig);
        var classes = consumerGenerator.GenerateModelsClassGen();


        Assert.Contains("Access", classes.Select(x => x.ClassName));
    }
}