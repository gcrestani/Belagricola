# Belagricola

> #### QUESTÃO 03:
> Escreva um algoritmo que simule o funcionamento de um caixa eletrônico.
> 
> O programa deverá receber o valor desejado para saque e ele retornará à quantidade de cédulas de cada valor. As cédulas consideradas pelo caixa eletrônico são: 100, 50, 20, 10, 5 e 2. Deve ser retornado a menor quantidade de cédulas possível para o valor do saque.

Foi criada uma classe CaixaEletronico.cs com o método Withdraw(int) que faz a divisão com resto (%) do valor solicitado, utilizando o valor de cada nota (da mais alta para a mais baixa) como divisor.
Se o resto da divisão der 0, é retornada a quantidade de cada nota que será utilizada. Caso o resto for diferente de zero, o valor é dividido pelo valor da próxima nota. Caso após a divisão por 2 (menor nota) o valor continuar sendo maior que zero é retornado um erro.
Além do solicitado no exercício, foi criado um retorno caso o valor solicitado seja impossível de ser sacado, utilizando a estrutura Try/Catch.

Para rodar esse projeto, você precisa ter instalado o .net core SDK 3.1 em seu sistema operacional  [.Net Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1).
É recomendavel que para alterações você instale um dos seguintes editores:  [Visual Studio](https://visualstudio.microsoft.com/pt-br/vs/)  | [Visual Studio Code](https://code.visualstudio.com/download)

### Rodando a aplicação

Abra a solução no Visual Studo e inicie o projeto normalmente (control + F5).

## Construido com:

-   [.Net Core Framework](https://dotnet.microsoft.com/download/dotnet-core)  - Free, cross-platform, open-source framework;

## [](https://github.com/gcrestani/Resolutte#autor)Autor

-   **Guilherme Crestani**  -  [gcrestani](https://github.com/gcrestani/)
