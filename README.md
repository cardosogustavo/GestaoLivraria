# GestaoLivraria

## PT-BR
Repositório para um pequeno exercício de introdução a criação de WEB API com .NET, da formação C# da [Rocketseat](https://www.rocketseat.com.br/assinatura)

## EN-US
Git repo for an introductory exercise about web APIs in .NET framework. This is part of the C# certification path from [Rocketseat](https://www.rocketseat.com.br/assinatura)

# The project
It is a simple CRUD web API simulating a library.

We have the Book.cs entity containing book information.

BookController contains the Create, Read, Update and Delete logic for the HTTP calls.

The MainAPIController inherits from BaseController. This is to simplify the endpoint, for example if I want to change the main endpoint I can only change it in one place.
