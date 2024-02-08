# Projeto Ciclo de vida de aplicações

Este projeto tem o intuito de demonstrar o `ciclo de vida` disponíveis em uma aplicação .NET.

Para demonstrar isso, foi configurado um mesmo serviço de 3 maneiras diferentes:

- `Transient`: a cada utilização do serviço é criada uma `nova instância`.
- `Scoped`: utiliza a mesma instância do começo ao final da `requisição`.
- `Singleton`: a mesma instância durante `todo o ciclo de vida` de uma aplicação.

`Obs`: esse serviço foi consumido de duas formas, diretamente no front e através de um serviço intermediário para facilitar o entendimento.

## Entendendo na prática

Toda vez que a tela é carregada, a tabela é atualizada conforme os 3 conceitos descritos acima, onde:

- `Transient`: IDs diferentes chamando o serviço direto e através do intermediário.
- `Scoped`: IDs iguais a cada requisição.
- `Singleton`: IDs iguais durante toda a utilização da aplicação.