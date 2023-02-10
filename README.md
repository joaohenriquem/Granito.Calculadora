# Granito.Calculadora

# Importante

Projeto criado para testes

## Prerequirements

* Visual Studio 2019 ou Visual Code
* .NET Core SDK

## How To Run

* Open solution in Visual Studio 2019
* Set .Web project as Startup Project and build the project.
* Run the application.

## Docker

Navegar até a pasta src/CalculaJuros e executar os comandos abaixo:
 docker build -t calculajuros:1.0 .
 docker run -d -p 5001:80 calculajuros:1.0
 
Navegar até a pasta src/Taxas e executar os comandos abaixo:
 docker build -t taxas:1.0 .
 docker run -d -p 5002:80 taxas:1.0
