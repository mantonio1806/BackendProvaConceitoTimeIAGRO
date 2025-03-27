Um cliente tem necessidade de buscar livros em um catálogo. Esse cliente quer ler e buscar esse catálogo de um arquivo JSON, e esse arquivo não pode ser modificado. Então com essa informação, é preciso desenvolver:

    Criar uma API para buscar produtos no arquivo JSON disponibilizado.
    Que seja possível buscar livros por suas especificações(autor, nome do livro ou outro atributo)
    É preciso que o resultado possa ser ordenado pelo preço.(asc e desc)
    Disponibilizar um método que calcule o valor do frete em 20% o valor do livro.

Será avaliado no desafio:

    Organização de código;
    Manutenibilidade;
    Princípios de orientação à objetos;
    Padrões de projeto;
    Teste unitário

Para nos enviar o código, crie um fork desse repositório e quando finalizar, mande um pull-request para nós.

O projeto deve ser desenvolvido em C#, utilizando o .NET Core 3.1 ou superior.

Gostaríamos que fosse evitado a utilização de frameworks, e que tivesse uma explicação do que é necessário para funcionar o projeto e os testes.



//=========
Explicação rádida do que é necessário para funcionar o projeto e os testes criados:

- Foi utilizado o Visual Studio 2022;
- .NET 6.0
- Para testes biblioteca XUnit 2.9.3
Nome da solução: ApiLivrosJson

Para API basta executar o projeto: ApiLivros e utilizar o navegador ou Swagger:

Foram criadas 2 requisições GET uma para buscar os livros pelos diversos atributos e ordenar pelo preço e outra para calcular o frete pelo id do livro

Casos de exemplo:

1 - Caso queira buscar todos os livros, sendo ordernado em ordem ascendente pelo preço
Pelo navegador: https://localhost:7113/api/livros?sortOrder=asc
Pelo Swagger: Parâmetro search: deixar em branco / Parâmetro sortOrder = asc

2 - Caso queria buscar pelo gênero: "Adventure Fiction"
Pelo navegador: https://localhost:7113/api/livros?search=Adventure%20Fiction&sortOrder=asc
Pelo Swagger: Parâmetro search: Adventure Fiction / Parâmetro sortOrder = desc

Para o teste unitário criei o porojeto: ApiLivros.Tests usando biblioteca XUnit

Criei 2 casos de testes: uma para testar o método de cálculo do frete e outro para testar o método de busca, para executar basta selecionar o projeto e clicar em Test -> Run All Tests (uso o Visual Studio em inglês aqui)
