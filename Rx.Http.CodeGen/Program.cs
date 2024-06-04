// See https://aka.ms/new-console-template for more information
using Rx.Http.CodeGen;
using Rx.Http;
using System.Reactive.Linq;

var httpClient = RxHttpClient.Create();
var path = "";


var keycloakOpenApiDefinition = httpClient.Get("https://raw.githubusercontent.com/ccouzens/keycloak-openapi/main/keycloak/22.0.0.json")
    .SelectMany(httpResp => httpResp.Content.ReadAsStringAsync())
    .Wait();

var keycloakConsumerGen = new ConsumerGenerator(
    path: Path.Combine(path, "Keycloak"), 
    @namespace: "Keycloak", 
    openApiDefinition: keycloakOpenApiDefinition,
    consumerName: "Keycloak",
    defaultType: "IDictionary<string, object>");
keycloakConsumerGen.GenerateFiles();


var petStoreOpenApiDefinition = httpClient.Get("https://petstore3.swagger.io/api/v3/openapi.json")
    .SelectMany(httpResp => httpResp.Content.ReadAsStringAsync())
    .Wait();

var petstoreConsumerGen = new ConsumerGenerator(
    path: Path.Combine(path, "PetStore"), 
    @namespace: "Petstore.Swagger", 
    openApiDefinition: petStoreOpenApiDefinition,
    consumerName: "PetStore");
petstoreConsumerGen.GenerateFiles();