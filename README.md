# OdontoPrevApplication - Sorriso Ativo

<p>👥 Integrantes:  </p>
<p>Ellie de Oliveira  </p>
<p>RM: 552824  </p>
<p>🎯 Responsável pela integração dos serviços de backend com a API. </p> 

<p>Ives Jundi Chiba  </p>
<p>RM: 553243  </p>
<p>💻 Responsável pelo desenvolvimento das funcionalidades de comunicação com a API.  </p>

<p>Nathalia Comeron Freire  </p>
<p>RM: 553233  </p>
<p>💻 Responsável pelo desenvolvimento e consumo da API em Kotlin  </p>


## Definição do Projeto

### Objetivo do Projeto
O projeto Sorriso Ativo visa incentivar e recompensar os usuários pela manutenção de cuidados diários com a saúde bucal. A plataforma interativa permite que os beneficiários acumulem pontos ao realizar consultas, completar desafios e registrar hábitos de saúde bucal. Esses pontos podem ser trocados por prêmios e benefícios exclusivos, promovendo um estilo de vida mais saudável.

### Escopo
O escopo do projeto abrange o desenvolvimento de uma API que gerencia beneficiários, recompensas, missões e serviços relacionados à saúde bucal. As funcionalidades principais incluem:
- Registro e gerenciamento de beneficiários.
- Acompanhamento de missões e hábitos de saúde bucal.
- Sistema de recompensas por interações dos usuários.
- Integração com prestadores de serviços e empresas contratantes.
- Consulta e gerenciamento de endereços.

### Requisitos Funcionais e Não Funcionais

#### Requisitos Funcionais
- Cadastro e gerenciamento de beneficiários.
- Registro de missões e acompanhamento de progresso.
- Sistema de pontos e recompensas.
- Integração com prestadores de serviços e empresas contratantes.
- Consulta e gerenciamento de endereços.

#### Requisitos Não Funcionais
- A aplicação deve ser desenvolvida utilizando .NET Core.
- Implementação da arquitetura limpa (Clean Architecture) para garantir a separação de responsabilidades.
- Segurança nas operações de cadastro e acesso a dados.
- Escalabilidade para suportar um número crescente de usuários e dados.

## Desenho da Arquitetura

### Monolito x Microserviços
| Característica         | Monolito                                    | Microserviços                                   |
|------------------------|--------------------------------------------|------------------------------------------------|
| **Arquitetura**        | Aplicação única e centralizada            | Dividida em múltiplos serviços independentes  |
| **Complexidade**       | Baixa (mais fácil de entender e gerenciar) | Alta (requer orquestração e comunicação)      |
| **Escalabilidade**     | Vertical (mais difícil de escalar)         | Horizontal (permite escalabilidade individual) |
| **Manutenção**         | Simples no início, mas pode dificultar mudanças | Mais flexível, mas exige maior coordenação |
| **Desempenho**         | Melhor para sistemas pequenos              | Melhor para grandes sistemas distribuídos     |
| **Deploy**            | Único, afetando toda a aplicação           | Independente para cada serviço                |
| **Comunicação**       | Interna, sem latência extra                | Requer APIs e comunicação entre serviços      |
| **Tolerância a falhas** | Falha pode afetar toda a aplicação        | Falhas podem ser isoladas em um único serviço |
| **Exemplo de uso**    | Aplicações pequenas e médias               | Sistemas complexos e distribuídos             |


### Arquitetura do Projeto: Monolito
#### Por que?
Optamos por uma arquitetura monolítica devido à simplicidade e pequeno porte da API. Com poucos controllers e regras de negócio, o monolito facilita a manutenção, a navegação no código e o deploy, sem a complexidade extra dos microservices. Além disso, evita o overhead de comunicação entre serviços e mantém a infraestrutura mais simples. Caso o projeto cresça e demande escalabilidade, podemos reavaliar essa decisão no futuro.

### Clean Architecture
O projeto utiliza a Clean Architecture para promover um código desacoplado, onde cada camada tem responsabilidades bem definidas. Essa abordagem facilita a manutenção e evolução da aplicação.

### Camadas da Aplicação

#### Padrão de Criação da API
#### Service Layer (Application Service Pattern)
Camada intermediária entre controllers e repositórios, centralizando regras de negócio.
Uso: Para separar responsabilidades e manter a API modular.

### Controllers
Aqui se encontra a exposição dos endpoints utilizados. Sendo eles GET, POST, PUT, DELETE.

#### Services
Nesta camada estão localizados os serviços e casos de uso da aplicação. Aqui, são implementadas as regras de negócios e a lógica que coordena as operações entre as camadas de domínio e apresentação.

#### Entites
A camada de entidade contém os modelos e as regras de negócio. Aqui são definidos os objetos que representam os conceitos principais da aplicação, como `Beneficiario`, `Missao`, `Recompensa`, entre outros.

#### Repositories
Onde ocorre a comunicação entre a aplicação e o Banco de Dados.

#### Infraestrutura
A camada de infraestrutura é responsável pelo acesso a dados, integração com APIs externas e outros serviços de backend. Essa camada implementa os repositórios que facilitam a comunicação com o banco de dados, utilizando Entity Framework Core.

## Estrutura do Projeto
A estrutura do projeto é organizada em pastas que correspondem às camadas da arquitetura. 

## Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

## Licença
Este projeto está licenciado sob a MIT License. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Contato
Para mais informações, entre em contato com a equipe de desenvolvimento da Adaptive Dialogs.
