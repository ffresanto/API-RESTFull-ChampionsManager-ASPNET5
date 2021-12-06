# API RESTFull ChampionsManager ASPNET5

Repositório responsável pela API da ChampionsManager. Essa API é RESTFull e foi desenvolvida em ASP.NET 5, contendo Swagger, HATEOAS e Banco de Dados MySQL. Com foco principal em aprimoração nos meus conhecimentos em desenvolvimento.

## ☕ Sobre esse Projeto

Estou desenvolvendo esse projeto em minhas horas vagas e com o tempo atualizando no github. O objetivo desse projeto é ter controle de conquistas em games de futebol, mas com foco no rumo ao estrelato do PES, como quantidade de trófeus ganhos pelo club, gols, assistências marcadas e etc..

## :computer: Recursos Utilizados: 

Se faz necessário realizar a instalação das aplicações/frameworks abaixo:

* Visual Studio 2019

    - **[Visual Studio 2019](https://docs.microsoft.com/pt-br/visualstudio/releases/2019/release-notes)**
    - **[.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)**

* MySQL 8.0

    - **[MySQL Installer](https://dev.mysql.com/downloads/installer/)**
    - **[MySQL Workbench](https://dev.mysql.com/downloads/workbench/)**
    
## 🚩 Dependências Utilizadas no Projeto: 

- Evolve (2.4.0)
- Microsoft.AspNetCore.Mvc.Formatters.Xml (2.2.0)
- Microsoft.AspNetCore.Mvc.Versioning (4.1.1)
- Pomelo.EntityFrameworkCore.MySql (3.2.0)
- Serilog (2.10.0)
- Serilog.AspNetCore (3.4.0)
- Serilog.Sinks.Console (3.1.1)
- Swashbuckle.AspNetCore (5.6.1)
    
## :fire: Configurando o Projeto Localmente 

1) Abra o MySql Workbench e execute a seguinte Query para criação do Banco de Dados.

```sql
CREATE DATABASE db_championsmanager;
```
2) Na pasta do projeto, abra a solution **API_Champions_Manager.sln**

  - Com o projeto aberto em seu visual studio, abra o **appsetting.json** e altere a **MySQLConnectionString** com seu usuário e senha do MySQL.

```json
{
  "MySQLConnection": {
    "MySQLConnectionString": "Server=localhost;DataBase=db_championsmanager;Uid=youruser;Pwd=yourpassword"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
 }
```

3) Após mudar as configuração do banco, pode dar **Run** no projeto, automaticamente será criada as tabelas no banco de dados, e em seguido abrira o Swagger no navegador contendo os Endpoint da API.

<div align="left">
<img src="https://user-images.githubusercontent.com/44379238/144937847-90db6cc6-70fd-4cd5-9a2b-204181696181.png" width="600px" />
</div>


(Caso não crie as tabelas no banco de dados, há como criar manualmente com as querys dentro do projeto, na pasta **DB > migrations**)

## ⌨️ Exemplos de Requisições

Awards (Prêmios)

`GET /api/award/v1/`
 
 ```
 https://localhost:44322/api/award/v1/1
 ```
   
   Retorno:
   ```json
    {
        "id": 1,
        "name": "Ballon d´Or",
        "origin": "Europe",
        "organization": "FIFA",
        "national": false,
        "links": [
            {
                "rel": "self",
                "href": "https://localhost:44322/api/award/v1/1",
                "type": "application/json",
                "action": "GET"
            },
            {
                "rel": "self",
                "href": "https://localhost:44322/api/award/v1/1",
                "type": "application/json",
                "action": "POST"
            },
            {
                "rel": "self",
                "href": "https://localhost:44322/api/award/v1/1",
                "type": "application/json",
                "action": "PUT"
            },
            {
                "rel": "self",
                "href": "https://localhost:44322/api/award/v1/1",
                "type": "int",
                "action": "DELETE"
            }
        ]
    }
```
