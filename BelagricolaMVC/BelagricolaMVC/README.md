# Belagricola

> #### QUESTÃO 04: Criar uma Api Rest
> 
> Pensando no cadastro do cliente, considere os seguintes requisitos:
> - Cada cliente no sistema deve possuir, além das suas informações cadastrais (limitadas em 6 informações a sua escolha), uma lista de contatos associados.
>
> - Cada contato é representado pelas informações código, nome, lista de telefones e tipo de relacionamento com o cliente (Pai, mãe, irmão...).
>
> - Criar uma api Rest de consumo de clientes, onde ela deverá inserir, alterar e deletar as informações.
>
> - O banco de dados fica a escolha do desenvolvedor.
>
> - Criar uma aplicação para consumir a Api criada.

Projeto desenvolvido em .Net Core.
O banco de dados foi criado usando o modelo Code-First, ou seja, foram criados os Models e, a partir deles, as Migrations.
Foi criado um serviço de Seed para popular o banco de dados para teste.

A aplicação para consumir a API foi criada em Asp.net, utilizando o conceito MVC e conceitos de Bootstrap para o layout.
Algumas telas padrão do MVC foram retiradas para uma melhor usabilidade (como as telas de Detalhes de cada item).

Para rodar esse projeto, você precisa ter instalado o [.Net Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) e o [MySql](https://downloads.mysql.com/archives/installer/) em seu sistema operacional.
É recomendavel que para alterações você instale um dos seguintes editores:  [Visual Studio](https://visualstudio.microsoft.com/pt-br/vs/)  | [Visual Studio Code](https://code.visualstudio.com/download)

### Rodando a aplicação - API

Antes rodar a API, utilize o comando abaixo no Visual Studio para executar as migrations:

    Update-database
Após isso inicie o projeto normalmente (control + F5)

### Vídeo explicativo:
[Vídeo explicativo do projeto](https://www.loom.com/share/c96ac1c2a47944c0a03dbc2730429039)

## Construido com:

-   [.Net Core Framework](https://dotnet.microsoft.com/download/dotnet-core)  - Free, cross-platform, open-source framework;
- [MySQL](https://www.mysql.com/) - The world's most popular open source database.

## [](https://github.com/gcrestani/Resolutte#autor)Autor

-   **Guilherme Crestani**  -  [gcrestani](https://github.com/gcrestani/)
