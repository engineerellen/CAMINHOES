Procedimentos tecnologia usados:

- migration do banco DB_Volvo, tabela Truck (code first)
- arquitetura DDD usando principios do SOLID com isolacao de responsabillidade e injecao de dependencia
- .net core
- ORM Entity Framework
- Teste Unitario xunity
- inclusao de swagger
- Visual Studio 2022
- .net Core 6.0


Obs: Abrir na branch master
1-  restaurar pacotes nuget
2- estou usando code first, então, executar os comandos abaixo:
 a- add-migration {DB_VOLVO}
 b- update-database
 
