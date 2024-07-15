#!/bin/sh

cd Rx.Http.CodeGen
dotnet run -- -u https://raw.githubusercontent.com/ccouzens/keycloak-openapi/main/keycloak/22.0.0.json -o Keycloak -n Keycloak
dotnet run -- -u https://raw.githubusercontent.com/ccouzens/keycloak-openapi/main/keycloak/22.0.0.json -o Keycloak -n Keycloak.Dict -t dictionary
dotnet run -- -u https://api.codacy.com/api/api-docs/swagger.yaml -o Codacy -n Codacy
dotnet run -- -u https://raw.githubusercontent.com/docusign/OpenAPI-Specifications/master/admin.rest.swagger-v2.1.json -o DocuSign -n DocuSign
dotnet run -- -u https://petstore.swagger.io/v2/swagger.json -o Petstore -n Swagger.Petstore