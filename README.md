# SisecomChallenge

App Ranking de Volta mais Rapida

Desafio promovido pela Sisecom com o objetivo de explorar nossos conhecimentos em programação web com o uso do Blazor.

Design:
O Design da interface foi inspirado na estetica automotiva, tendo uma interface simples e direta que remeta a velocidade das corridas.

Caracteristicas internas de Desenvimento:
Esse projeto foi desenvolvido no Visual Studio 2022 usando o template de projeto Blazor Web Server App 
Para executar esse projeto é necessário ter instalado o .NET 8.0

Arquitetura:
Nesse desenvolvimento optei pela Arquitetura em Camadas, visando facilitar futuras atualizações e correções do codigo 
A principio o codigo está dividido em 3 pastas: Data, Models e Components.

Models: Responsavel por armazenar as classes do projeto
Data: Definir as regras de negocios que serão executadas por meio dos services
Components: Responsavel pelos componentes visuais do projeto

      +-------------------------------------------------+
      |        Camada de Apresentação (UI)              |
      |-------------------------------------------------|
      | • Componentes Razor (.razor)                    |  <-- O usuário interage aqui
      |   - RankingGrid.razor (Página Principal)        |
      |   - GroupCard.razor (Componente Reutilizável)   |
      |   - Filtros, Layouts, etc.                      |
      +----------------------^--------------------------+
                             |
              (Injeção de Dependência via Interface)
                             |
      +----------------------v--------------------------+
      |     Camada de Lógica de Negócio (Serviços)      |
      |-------------------------------------------------|
      | • Classes de Serviço (.cs)                      |
      |   - IPilotoService (Contrato)                   |  <-- Regras de negócio, filtros,
      |   - PilotoService (Implementação)               |      agrupamentos, ordenação
      +----------------------^--------------------------+
                             |
                   (Chamada de Método)
                             |
      +----------------------v--------------------------+
      |       Camada de Acesso a Dados (DAL)            |
      |-------------------------------------------------|
      | • Lógica de Acesso aos Dados                    |
      |   - [Inicialmente]: Lista "hardcoded" na classe |  <-- Fonte dos dados (lista,
      |     de serviço.                       |      JSON, banco de dados)
      |   - [Futuro]: Repositório (Repository Pattern)  |
      +-------------------------------------------------+

      | Modelos de Dados (DTOs/Entidades)               |
      | • Piloto.cs, Categoria.cs, etc.                 |  <-- Transitando por todas as camadas
      +-------------------------------------------------+

Requisitos Atendidos do desafio e observações:
Consegui entregar uma interface condizente com o tema de corridas, facil de usar e com as principais solicitações atendidas
Confesso que tive que aprender a utilizar o Blazor, pois já havia quase um ano que não tinha contato com essa tecnologia
Hoje se tivesse um prazo um pouco maior, poderia completar esse projeto com um backend e banco de dados funcional
De qualquer forma essa foi uma experiencia boa para me desenvolver ainda mais como um desenvolvedor maduro
