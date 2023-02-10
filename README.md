# Granito.Calculadora

# Important

Issues of this repository are tracked on https://github.com/aspnetboilerplate/aspnetboilerplate. Please create your issues on 

This template is a simple startup project to start with ABP
using ASP.NET Core and EntityFramework Core.

## Prerequirements

* Visual Studio 2019 ou Visual Code
* .NET Core SDK

## How To Run

* Open solution in Visual Studio 2017
* Set .Web project as Startup Project and build the project.
* Run the application.

## Docker

Navegar até a pasta src/CalculaJuros 
Executar os comandos abaixo:

 docker build -t calculajuros:1.0 .
 docker run -d -p 5001:80 calculajuros:1.0
 
Navegar até a pasta src/Taxas 
Executar os comandos abaixo:

 docker build -t taxas:1.0 .
 docker run -d -p 5002:80 taxas:1.0
