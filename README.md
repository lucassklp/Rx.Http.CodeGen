# Rx.Http.CodeGen


<p align="center">
  <img src="resources/rx.http.mini.png">
</p>


## Installation

```sh
dotnet tool install -g rx.http.codegen
```

## Usage (Example)

```sh
dotnet rx-http-codegen -- --namespace Keycloak --output Keycloak --url https://raw.githubusercontent.com/ccouzens/keycloak-openapi/main/keycloak/22.0.0.json
```

### Avalable options
```
-f, --file         Set the OpenApi definition file location
-u, --url          Set the OpenApi definition url location
-n, --namespace    Required. The name of the namespace of generated source
-o, --output       Required. The output Consumer Class Name
-t, --type         (Default: object) Set the default type for unknown models. Possible values: 'object' or 'dictionary'
-v, --verbose      (Default: false) Define if debug logs will appear
--help             Display this help screen.
--version          Display version information.
```