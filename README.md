# Rx.Http.CodeGen


<p align="center">
  <img src="resources/rx.http.mini.png">
</p>

<p align="center">
    <img alt="nuget" src="https://img.shields.io/nuget/dt/Rx.Http.CodeGen.svg">
    <a href="https://app.codacy.com/gh/lucassklp/Rx.Http.CodeGen/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade">
      <img src="https://app.codacy.com/project/badge/Grade/4e6b1046b6f148ae8d769c0555901e24"/>
    </a>
    <a href="https://app.codacy.com/gh/lucassklp/Rx.Http.CodeGen/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_coverage">
      <img src="https://app.codacy.com/project/badge/Coverage/4e6b1046b6f148ae8d769c0555901e24"/>
    </a>
    <a href="https://www.nuget.org/packages/Rx.Http.CodeGen/">
      <img alt="nuget version" src="https://img.shields.io/nuget/v/Rx.Http.CodeGen.svg">
    </a>
</p>



This tool is used to generate [Rx.Http consumer](https://github.com/lucassklp/Rx.Http?tab=readme-ov-file#consumers) based on OpenApi definition file.

## Installation

```sh
dotnet tool install -g rx.http.codegen
```

## Usage (Example)

```sh
rx-http-codegen --namespace Swagger.Petstore --output Petstore --url https://petstore.swagger.io/v2/swagger.json
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